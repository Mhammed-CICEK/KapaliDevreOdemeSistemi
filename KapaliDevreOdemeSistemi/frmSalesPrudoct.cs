using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServicesLayer;
using Models;
using System.Collections;
using DevExpress.XtraGrid;
using Library;
using System.IO;
using Common;

namespace KapaliDevreOdemeSistemi
{
    public partial class frmSalesPrudoct : Form

    {
        int eklenenUrunSayisi = 0;
        ProductService ps = new ProductService();
        Product product = new Product();
        Product findProduct = new Product();
        List<Product> products = new List<Product>();
        decimal toplamtutar;
        CardAccount findAccount = new CardAccount();
        Balance findBalance = new Balance();
        SalesService ss = new SalesService();
        public frmSalesPrudoct()
        {
            InitializeComponent();
        }
        public void endAddProduct(Product product)
        {
            txtProductName.Text = product.UrunAdi;
            txtPSalePrice.Text = product.SatisFiyati.ToString();
            if (findProduct.Resim != null)
            {
                MemoryStream mem = new MemoryStream(product.Resim);
                pbPImage.Image = Image.FromStream(mem);
            }
            else
            {
                pbPImage.Image = global::KapaliDevreOdemeSistemi.Properties.Resources.urun;
            }
            txtAdet.Text = product.Adet.ToString();
            gbProductData.Text = "Son Eklenen Urun";
        }
        public void AccontData(decimal yuklenenBakiye, decimal harcananBaiye)
        {
            MembersServices ms = new MembersServices();
            Members findMembers = new Members();
            findMembers = ms.Find(findAccount.HesapId);
            txtAccountName.Text = findAccount.HesapAdi;
            txtMName.Text = findMembers.Isim;
            txtMSurname.Text = findMembers.Soyisim;

            nudBalance.Value = (decimal)(yuklenenBakiye - harcananBaiye);
            if (findMembers.Resim != null)
            {
                MemoryStream mem = new MemoryStream(findProduct.Resim);
                pbMImage.Image = Image.FromStream(mem);
            }
            else
            {
                pbMImage.Image = global::KapaliDevreOdemeSistemi.Properties.Resources.Student;
            }
            txtAdet.Text = product.Adet.ToString();
            gbProductData.Text = "Üye Bilgileri";
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string cardNo;
            CardAccountService cas = new CardAccountService();
            Balance searchBalance = new Balance();
            BalanceService bs = new BalanceService();
            List<Sales> sales = new List<Sales>();
            Sales sale = new Sales();
            SalesService ss = new SalesService();
            ProductService ps = new ProductService();
            float Bakiye;
            bool bakiyeDurumu = false;
            int satisSonuc;
            try
            {
                product.Barkod = txtSearch.Text;
                findProduct = ps.Find(product);
                if (findProduct == null)
                {

                    cardNo = txtSearch.Text;
                    findAccount = cas.FindCardNo(cardNo);
                    if (findAccount == null)
                    {
                        return;
                    }
                    findBalance = bs.Find(findAccount.KartId);
                    if (findBalance == null)
                    {
                        return;
                    }
                    Bakiye = findBalance.YuklenenBakiye - findBalance.HarcananBakiye;
                    if (gvList.Rows.Count <= 1)
                    {
                        MessageBox.Show("Lütfen Önce Satmak istediğiniz Ürünleri Listeye Ekleyin !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        AccontData((decimal)findBalance.YuklenenBakiye, (decimal)findBalance.HarcananBakiye);
                        return;
                    }
                    bakiyeDurumu = Bakiye <= 0;
                    if (bakiyeDurumu)
                    {
                        MessageBox.Show("Yetersiz Bakiye !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        AccontData((decimal)findBalance.YuklenenBakiye, (decimal)findBalance.HarcananBakiye);
                        return;
                    }
                    Balance endbalance = new Balance()
                    {
                        KartId = findAccount.KartId,
                        HesapId = findAccount.HesapId,
                        YuklenenBakiye = findBalance.YuklenenBakiye,
                        HarcananBakiye = findBalance.HarcananBakiye + (float)nudTotarPrice.Value,
                        IslemTipi = 3,
                        MiktarTipi = 1,
                        Aciklama = $"{nudTotarPrice.Value.ToString()} tutarında ürün satın alınmıştır.",

                    };
                    satisSonuc = bs.Save(endbalance);
                    if (satisSonuc <= 0)
                    {
                        MessageBox.Show($"{txtAccountName.Text} hesabına ait {cardNo} kartında {nudTotarPrice.Value.ToString()} ₺ para çekilmemiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    MessageBox.Show($"{txtAccountName.Text} hesabına ait {cardNo} kartında {nudTotarPrice.Value.ToString()} ₺ para çekilmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AccontData((decimal)endbalance.YuklenenBakiye, (decimal)endbalance.HarcananBakiye);
                    foreach (var item in products)
                    {
                        sale.Adet = item.Adet;
                        sale.SatisFiyati = item.SatisFiyati;
                        sale.AccountId = findAccount.Id;
                        sale.UrunId = item.Id;
                        sale.ToplamTutar = item.Adet * item.SatisFiyati;
                        sale.KartId = findAccount.KartId;
                        sales.Add(sale);
                    }
                    ss.Save(sales);
                    ps.Update(products);
                    return;
                }

            }
            catch (Exception error)
            {
                MessageBox.Show("Sistem Hatası. Lütfen sistem yöneticinize başvurun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogService.LogSave("Ürün Satış İşlemi : " + error.Message, (byte)Enums.LogTipi.Hata);
            }
            try
            {
                if (products.Count == 0)
                {
                    products.Add(findProduct);
                    gvList.Rows.Add();
                    gvList.Rows[eklenenUrunSayisi].Cells[colBarkod.Index].Value = findProduct.Barkod;
                    gvList.Rows[eklenenUrunSayisi].Cells[colUrunAdi.Index].Value = findProduct.UrunAdi;
                    gvList.Rows[eklenenUrunSayisi].Cells[colSatisFiyati.Index].Value = findProduct.SatisFiyati;
                    gvList.Rows[eklenenUrunSayisi].Cells[colAdet.Index].Value = 1;
                    gvList.Rows[eklenenUrunSayisi].Cells[colToplamTutar.Index].Value = (1 * findProduct.SatisFiyati);
                    endAddProduct(findProduct);
                    eklenenUrunSayisi++;
                    return;
                }
                int urunsirasi = 0;
                bool bulunanUrun = true;
                foreach (var item in products)
                {
                    if (item.Barkod == findProduct.Barkod)
                    {
                        item.Adet++;
                        gvList.Rows[urunsirasi].Cells[colAdet.Index].Value = item.Adet;
                        gvList.Rows[urunsirasi].Cells[colToplamTutar.Index].Value = (item.Adet * findProduct.SatisFiyati);
                        endAddProduct(item);
                        bulunanUrun = false;
                        break;
                    }
                    urunsirasi++;
                }
                if (bulunanUrun)
                {
                    products.Add(findProduct);
                    gvList.Rows.Add();
                    gvList.Rows[eklenenUrunSayisi].Cells[colBarkod.Index].Value = findProduct.Barkod;
                    gvList.Rows[eklenenUrunSayisi].Cells[colUrunAdi.Index].Value = findProduct.UrunAdi;
                    gvList.Rows[eklenenUrunSayisi].Cells[colSatisFiyati.Index].Value = findProduct.SatisFiyati;
                    gvList.Rows[eklenenUrunSayisi].Cells[colAdet.Index].Value = 1;
                    gvList.Rows[eklenenUrunSayisi].Cells[colToplamTutar.Index].Value = (1 * findProduct.SatisFiyati);
                    eklenenUrunSayisi++;
                    endAddProduct(findProduct);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Sistem Hatası. Lütfen sistem yöneticinize başvurun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogService.LogSave("Ürün Satış için Seçme İşlemi : " + error.Message, (byte)Enums.LogTipi.Hata);
            }

        }


        private void gvList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (gvList.Rows.Count > 0 && e.RowIndex != gvList.NewRowIndex)
                {
                    foreach (var item in products)
                    {
                        if (item.Barkod == gvList.Rows[e.RowIndex].Cells[colBarkod.Index].Value.ToString())
                        {
                            gvList.Rows.Remove(gvList.Rows[e.RowIndex]);
                            products.Remove(item);
                            eklenenUrunSayisi--;
                            break;
                        }
                    }

                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Sistem Hatası. Lütfen sistem yöneticinize başvurun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogService.LogSave("Ürün SAtış Ekranında Silme İşlemi : " + error.Message, (byte)Enums.LogTipi.Hata);
            }
        }


        private void gvList_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int adetsonuc;
                decimal satisSonuc;
                if ((e.RowIndex >= 0))
                {
                    if (gvList.Rows[e.RowIndex].Cells[colAdet.Index].Value != null)
                    {
                        string adet = gvList.Rows[e.RowIndex].Cells[colAdet.Index].Value.ToString();
                        string satisFiyati = gvList.Rows[e.RowIndex].Cells[colSatisFiyati.Index].Value.ToString();
                        bool adetKontrol = int.TryParse(adet, out adetsonuc);
                        bool satisFiyatiKontrol = decimal.TryParse(satisFiyati, out satisSonuc);
                        if (satisFiyatiKontrol && adetKontrol)
                        {
                            decimal sontoplamtutar = Convert.ToInt32(gvList.Rows[e.RowIndex].Cells[colToplamTutar.Index].Value);

                            gvList.Rows[e.RowIndex].Cells[colToplamTutar.Index].Value = adetsonuc * satisSonuc;
                            findProduct.Adet = adetsonuc;
                            findProduct.SatisFiyati = (float)satisSonuc;
                            txtAdet.Text = findProduct.Adet.ToString();
                            txtPSalePrice.Text = findProduct.SatisFiyati.ToString();
                            toplamtutar += (Convert.ToDecimal(gvList.Rows[e.RowIndex].Cells[colToplamTutar.Index].Value) - sontoplamtutar);
                            nudTotarPrice.Value = toplamtutar;

                        }
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Sistem Hatası. Lütfen sistem yöneticinize başvurun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogService.LogSave("Ürün Satış Ekranında Ürün Adeti Değiştirme : " + error.Message, (byte)Enums.LogTipi.Hata);
            }
        }
    }
}
