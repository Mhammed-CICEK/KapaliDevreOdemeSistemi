namespace KapaliDevreOdemeSistemi
{
    partial class frmProductProcess
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery1 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductProcess));
            this.btnMUploadImage = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.pbPImage = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtProductContent = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbState = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.txtPrudoctName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbUnit = new System.Windows.Forms.ComboBox();
            this.cmbProcessType = new System.Windows.Forms.ComboBox();
            this.nudKDV = new System.Windows.Forms.NumericUpDown();
            this.nudPurchasePrice = new System.Windows.Forms.NumericUpDown();
            this.nudSalePrices = new System.Windows.Forms.NumericUpDown();
            this.nudTotalNumber = new System.Windows.Forms.NumericUpDown();
            this.nudStockWarningPiece = new System.Windows.Forms.NumericUpDown();
            this.nudAddPiece = new System.Windows.Forms.NumericUpDown();
            this.cmbStore = new System.Windows.Forms.ComboBox();
            this.sleuStokGroupKodu = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.queryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sdsStokGoupList = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ofdImageLoad = new System.Windows.Forms.OpenFileDialog();
            this.pnlDataPanel.SuspendLayout();
            this.gbData.SuspendLayout();
            this.pnlButton.SuspendLayout();
            this.gbButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKDV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPurchasePrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSalePrices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockWarningPiece)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddPiece)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sleuStokGroupKodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDataPanel
            // 
            this.pnlDataPanel.Size = new System.Drawing.Size(1904, 202);
            // 
            // gbData
            // 
            this.gbData.Controls.Add(this.sleuStokGroupKodu);
            this.gbData.Controls.Add(this.nudStockWarningPiece);
            this.gbData.Controls.Add(this.nudTotalNumber);
            this.gbData.Controls.Add(this.nudSalePrices);
            this.gbData.Controls.Add(this.nudPurchasePrice);
            this.gbData.Controls.Add(this.nudAddPiece);
            this.gbData.Controls.Add(this.nudKDV);
            this.gbData.Controls.Add(this.btnMUploadImage);
            this.gbData.Controls.Add(this.label12);
            this.gbData.Controls.Add(this.pbPImage);
            this.gbData.Controls.Add(this.label7);
            this.gbData.Controls.Add(this.txtProductContent);
            this.gbData.Controls.Add(this.label4);
            this.gbData.Controls.Add(this.label13);
            this.gbData.Controls.Add(this.cmbProcessType);
            this.gbData.Controls.Add(this.cmbUnit);
            this.gbData.Controls.Add(this.cmbStore);
            this.gbData.Controls.Add(this.cmbState);
            this.gbData.Controls.Add(this.label1);
            this.gbData.Controls.Add(this.label9);
            this.gbData.Controls.Add(this.label2);
            this.gbData.Controls.Add(this.label3);
            this.gbData.Controls.Add(this.label11);
            this.gbData.Controls.Add(this.label8);
            this.gbData.Controls.Add(this.label10);
            this.gbData.Controls.Add(this.label6);
            this.gbData.Controls.Add(this.label5);
            this.gbData.Controls.Add(this.label14);
            this.gbData.Controls.Add(this.txtPrudoctName);
            this.gbData.Controls.Add(this.txtBarkod);
            // 
            // pnlButton
            // 
            this.pnlButton.Size = new System.Drawing.Size(1904, 107);
            // 
            // iconlar
            // 
            this.iconlar.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconlar.ImageStream")));
            this.iconlar.Images.SetKeyName(0, "Ekle.png");
            this.iconlar.Images.SetKeyName(1, "Kaydet.png");
            this.iconlar.Images.SetKeyName(2, "Güncelle.png");
            this.iconlar.Images.SetKeyName(3, "Sil.png");
            this.iconlar.Images.SetKeyName(4, "search.png");
            this.iconlar.Images.SetKeyName(5, "temizle.png");
            this.iconlar.Images.SetKeyName(6, "Vazgeç.png");
            // 
            // btnFormClear
            // 
            this.btnFormClear.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnFormClear.FlatAppearance.BorderSize = 0;
            this.btnFormClear.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnFormClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnFormClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFormClear.Click += new System.EventHandler(this.btnFormClear_Click_1);
            // 
            // btnNewRecord
            // 
            this.btnNewRecord.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNewRecord.FlatAppearance.BorderSize = 0;
            this.btnNewRecord.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnNewRecord.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnNewRecord.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNewRecord.Click += new System.EventHandler(this.btnNewRecord_Click_1);
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // btnReturn
            // 
            this.btnReturn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnReturn.FlatAppearance.BorderSize = 0;
            this.btnReturn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnReturn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnReturn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click_1);
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // btnMUploadImage
            // 
            this.btnMUploadImage.Location = new System.Drawing.Point(102, 156);
            this.btnMUploadImage.Name = "btnMUploadImage";
            this.btnMUploadImage.Size = new System.Drawing.Size(106, 23);
            this.btnMUploadImage.TabIndex = 43;
            this.btnMUploadImage.Text = "Resim Yükle";
            this.btnMUploadImage.UseVisualStyleBackColor = true;
            this.btnMUploadImage.Click += new System.EventHandler(this.btnMUploadImage_Click_1);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(655, 167);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 16);
            this.label12.TabIndex = 28;
            this.label12.Text = "Depo : ";
            // 
            // pbPImage
            // 
            this.pbPImage.Image = global::KapaliDevreOdemeSistemi.Properties.Resources.urun;
            this.pbPImage.Location = new System.Drawing.Point(92, 22);
            this.pbPImage.Name = "pbPImage";
            this.pbPImage.Size = new System.Drawing.Size(128, 128);
            this.pbPImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPImage.TabIndex = 21;
            this.pbPImage.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(602, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 16);
            this.label7.TabIndex = 30;
            this.label7.Text = "İşlem Türü : ";
            // 
            // txtProductContent
            // 
            this.txtProductContent.Location = new System.Drawing.Point(422, 77);
            this.txtProductContent.Multiline = true;
            this.txtProductContent.Name = "txtProductContent";
            this.txtProductContent.Size = new System.Drawing.Size(151, 77);
            this.txtProductContent.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(292, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 16);
            this.label4.TabIndex = 32;
            this.label4.Text = "Ürün İçeriği : ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(915, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 16);
            this.label13.TabIndex = 33;
            this.label13.Text = "KDV : ";
            // 
            // cmbState
            // 
            this.cmbState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbState.FormattingEnabled = true;
            this.cmbState.Items.AddRange(new object[] {
            "AKTİF",
            "PASİF"});
            this.cmbState.Location = new System.Drawing.Point(733, 75);
            this.cmbState.Name = "cmbState";
            this.cmbState.Size = new System.Drawing.Size(151, 24);
            this.cmbState.TabIndex = 45;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(602, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 16);
            this.label9.TabIndex = 36;
            this.label9.Text = "Durumu : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 34;
            this.label2.Text = "Barkod : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(292, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 31;
            this.label3.Text = "Ürün Adi : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(602, 138);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 16);
            this.label11.TabIndex = 26;
            this.label11.Text = "Eklenecek Adet : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(602, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 16);
            this.label8.TabIndex = 25;
            this.label8.Text = "Birim : ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(915, 49);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 16);
            this.label14.TabIndex = 23;
            this.label14.Text = "Alış Fiyatı : ";
            // 
            // txtBarkod
            // 
            this.txtBarkod.Location = new System.Drawing.Point(422, 19);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(151, 23);
            this.txtBarkod.TabIndex = 37;
            // 
            // txtPrudoctName
            // 
            this.txtPrudoctName.Location = new System.Drawing.Point(422, 48);
            this.txtPrudoctName.Name = "txtPrudoctName";
            this.txtPrudoctName.Size = new System.Drawing.Size(151, 23);
            this.txtPrudoctName.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(292, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 16);
            this.label1.TabIndex = 36;
            this.label1.Text = "Stok Grup Kodu : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(915, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "Satış Fiyatı : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(915, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "Toplam Adet : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(915, 136);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 16);
            this.label10.TabIndex = 23;
            this.label10.Text = "Stok Uyarı Adedi :";
            // 
            // cmbUnit
            // 
            this.cmbUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnit.FormattingEnabled = true;
            this.cmbUnit.Items.AddRange(new object[] {
            "ADET",
            "KG",
            "PAKET",
            "LİTRE",
            "METRE"});
            this.cmbUnit.Location = new System.Drawing.Point(733, 41);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.Size = new System.Drawing.Size(151, 24);
            this.cmbUnit.TabIndex = 45;
            // 
            // cmbProcessType
            // 
            this.cmbProcessType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProcessType.FormattingEnabled = true;
            this.cmbProcessType.Items.AddRange(new object[] {
            "STOK",
            "HİZMET",
            "MASRAF"});
            this.cmbProcessType.Location = new System.Drawing.Point(733, 11);
            this.cmbProcessType.Name = "cmbProcessType";
            this.cmbProcessType.Size = new System.Drawing.Size(151, 24);
            this.cmbProcessType.TabIndex = 45;
            // 
            // nudKDV
            // 
            this.nudKDV.DecimalPlaces = 2;
            this.nudKDV.Location = new System.Drawing.Point(1057, 18);
            this.nudKDV.Name = "nudKDV";
            this.nudKDV.Size = new System.Drawing.Size(120, 23);
            this.nudKDV.TabIndex = 57;
            // 
            // nudPurchasePrice
            // 
            this.nudPurchasePrice.DecimalPlaces = 2;
            this.nudPurchasePrice.Location = new System.Drawing.Point(1057, 46);
            this.nudPurchasePrice.Name = "nudPurchasePrice";
            this.nudPurchasePrice.Size = new System.Drawing.Size(120, 23);
            this.nudPurchasePrice.TabIndex = 58;
            // 
            // nudSalePrices
            // 
            this.nudSalePrices.DecimalPlaces = 2;
            this.nudSalePrices.Location = new System.Drawing.Point(1057, 75);
            this.nudSalePrices.Name = "nudSalePrices";
            this.nudSalePrices.Size = new System.Drawing.Size(120, 23);
            this.nudSalePrices.TabIndex = 59;
            // 
            // nudTotalNumber
            // 
            this.nudTotalNumber.Enabled = false;
            this.nudTotalNumber.Location = new System.Drawing.Point(1057, 104);
            this.nudTotalNumber.Name = "nudTotalNumber";
            this.nudTotalNumber.Size = new System.Drawing.Size(120, 23);
            this.nudTotalNumber.TabIndex = 60;
            // 
            // nudStockWarningPiece
            // 
            this.nudStockWarningPiece.Location = new System.Drawing.Point(1057, 131);
            this.nudStockWarningPiece.Name = "nudStockWarningPiece";
            this.nudStockWarningPiece.Size = new System.Drawing.Size(120, 23);
            this.nudStockWarningPiece.TabIndex = 61;
            // 
            // nudAddPiece
            // 
            this.nudAddPiece.Location = new System.Drawing.Point(733, 134);
            this.nudAddPiece.Name = "nudAddPiece";
            this.nudAddPiece.Size = new System.Drawing.Size(151, 23);
            this.nudAddPiece.TabIndex = 57;
            // 
            // cmbStore
            // 
            this.cmbStore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStore.FormattingEnabled = true;
            this.cmbStore.Items.AddRange(new object[] {
            "GENEL",
            "VAN",
            "BINGOL",
            "ANKARA"});
            this.cmbStore.Location = new System.Drawing.Point(733, 160);
            this.cmbStore.Name = "cmbStore";
            this.cmbStore.Size = new System.Drawing.Size(151, 24);
            this.cmbStore.TabIndex = 45;
            // 
            // sleuStokGroupKodu
            // 
            this.sleuStokGroupKodu.Location = new System.Drawing.Point(422, 158);
            this.sleuStokGroupKodu.Name = "sleuStokGroupKodu";
            this.sleuStokGroupKodu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sleuStokGroupKodu.Properties.DataSource = this.queryBindingSource;
            this.sleuStokGroupKodu.Properties.DisplayMember = "Adi";
            this.sleuStokGroupKodu.Properties.PopupView = this.searchLookUpEdit1View;
            this.sleuStokGroupKodu.Properties.ValueMember = "StokId";
            this.sleuStokGroupKodu.Size = new System.Drawing.Size(151, 20);
            this.sleuStokGroupKodu.TabIndex = 62;
            // 
            // queryBindingSource
            // 
            this.queryBindingSource.DataMember = "Query";
            this.queryBindingSource.DataSource = this.sdsStokGoupList;
            // 
            // sdsStokGoupList
            // 
            this.sdsStokGoupList.ConnectionName = "sqlBaglanti";
            this.sdsStokGoupList.Name = "sdsStokGoupList";
            customSqlQuery1.Name = "Query";
            customSqlQuery1.Sql = "Select * from vwStokGroupList";
            this.sdsStokGoupList.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery1});
            this.sdsStokGoupList.ResultSchemaSerializable = resources.GetString("sdsStokGoupList.ResultSchemaSerializable");
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAdi});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colAdi
            // 
            this.colAdi.FieldName = "Adi";
            this.colAdi.Name = "colAdi";
            this.colAdi.Visible = true;
            this.colAdi.VisibleIndex = 0;
            // 
            // ofdImageLoad
            // 
            this.ofdImageLoad.FileName = "openFileDialog1";
            // 
            // frmProductProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Name = "frmProductProcess";
            this.Text = "frmProductProcess";
            this.Load += new System.EventHandler(this.frmProductProcess_Load);
            this.pnlDataPanel.ResumeLayout(false);
            this.gbData.ResumeLayout(false);
            this.gbData.PerformLayout();
            this.pnlButton.ResumeLayout(false);
            this.gbButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKDV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPurchasePrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSalePrices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockWarningPiece)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddPiece)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sleuStokGroupKodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnMUploadImage;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pbPImage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtProductContent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbState;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtBarkod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrudoctName;
        private System.Windows.Forms.NumericUpDown nudStockWarningPiece;
        private System.Windows.Forms.NumericUpDown nudTotalNumber;
        private System.Windows.Forms.NumericUpDown nudSalePrices;
        private System.Windows.Forms.NumericUpDown nudPurchasePrice;
        private System.Windows.Forms.NumericUpDown nudKDV;
        private System.Windows.Forms.ComboBox cmbProcessType;
        private System.Windows.Forms.ComboBox cmbUnit;
        private System.Windows.Forms.NumericUpDown nudAddPiece;
        private System.Windows.Forms.ComboBox cmbStore;
        private DevExpress.XtraEditors.SearchLookUpEdit sleuStokGroupKodu;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colAdi;
        private System.Windows.Forms.OpenFileDialog ofdImageLoad;
        private System.Windows.Forms.BindingSource queryBindingSource;
        private DevExpress.DataAccess.Sql.SqlDataSource sdsStokGoupList;
    }
}