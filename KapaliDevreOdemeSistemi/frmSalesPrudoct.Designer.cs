namespace KapaliDevreOdemeSistemi
{
    partial class frmSalesPrudoct
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
            if(disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        /// <summary>
        /// Required method for Designer support - do not modify the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbData = new System.Windows.Forms.GroupBox();
            this.nudBalance = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMName = new System.Windows.Forms.TextBox();
            this.pbMImage = new System.Windows.Forms.PictureBox();
            this.txtMSurname = new System.Windows.Forms.TextBox();
            this.txtAccountName = new System.Windows.Forms.TextBox();
            this.pnlData = new System.Windows.Forms.Panel();
            this.nudTotarPrice = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.gbProductData = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtAdet = new System.Windows.Forms.TextBox();
            this.pbPImage = new System.Windows.Forms.PictureBox();
            this.txtPSalePrice = new System.Windows.Forms.TextBox();
            this.gvList = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.colSil = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colBarkod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUrunAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSatisFiyati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAdet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colToplamTutar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colYasakDurumu = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gbData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBalance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMImage)).BeginInit();
            this.pnlData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotarPrice)).BeginInit();
            this.gbProductData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvList)).BeginInit();
            this.SuspendLayout();
            // 
            // gbData
            // 
            this.gbData.Controls.Add(this.nudBalance);
            this.gbData.Controls.Add(this.label6);
            this.gbData.Controls.Add(this.label2);
            this.gbData.Controls.Add(this.label7);
            this.gbData.Controls.Add(this.label1);
            this.gbData.Controls.Add(this.txtMName);
            this.gbData.Controls.Add(this.pbMImage);
            this.gbData.Controls.Add(this.txtMSurname);
            this.gbData.Controls.Add(this.txtAccountName);
            this.gbData.Location = new System.Drawing.Point(22, 12);
            this.gbData.Name = "gbData";
            this.gbData.Size = new System.Drawing.Size(465, 186);
            this.gbData.TabIndex = 13;
            this.gbData.TabStop = false;
            // 
            // nudBalance
            // 
            this.nudBalance.Location = new System.Drawing.Point(277, 124);
            this.nudBalance.Maximum = new decimal(new int[] {
            -1454759936,
            465,
            0,
            0});
            this.nudBalance.Name = "nudBalance";
            this.nudBalance.ReadOnly = true;
            this.nudBalance.Size = new System.Drawing.Size(151, 20);
            this.nudBalance.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(180, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Bakiye : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(180, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "İsim : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(180, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Soyisim : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(180, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hesap Adi : ";
            // 
            // txtMName
            // 
            this.txtMName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMName.Location = new System.Drawing.Point(277, 27);
            this.txtMName.Name = "txtMName";
            this.txtMName.ReadOnly = true;
            this.txtMName.Size = new System.Drawing.Size(151, 22);
            this.txtMName.TabIndex = 5;
            // 
            // pbMImage
            // 
            this.pbMImage.Image = global::KapaliDevreOdemeSistemi.Properties.Resources.Student;
            this.pbMImage.Location = new System.Drawing.Point(24, 26);
            this.pbMImage.Name = "pbMImage";
            this.pbMImage.Size = new System.Drawing.Size(128, 128);
            this.pbMImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMImage.TabIndex = 3;
            this.pbMImage.TabStop = false;
            // 
            // txtMSurname
            // 
            this.txtMSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMSurname.Location = new System.Drawing.Point(277, 58);
            this.txtMSurname.Name = "txtMSurname";
            this.txtMSurname.ReadOnly = true;
            this.txtMSurname.Size = new System.Drawing.Size(151, 22);
            this.txtMSurname.TabIndex = 5;
            // 
            // txtAccountName
            // 
            this.txtAccountName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountName.Location = new System.Drawing.Point(277, 89);
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.ReadOnly = true;
            this.txtAccountName.Size = new System.Drawing.Size(151, 22);
            this.txtAccountName.TabIndex = 5;
            // 
            // pnlData
            // 
            this.pnlData.Controls.Add(this.nudTotarPrice);
            this.pnlData.Controls.Add(this.label5);
            this.pnlData.Controls.Add(this.txtSearch);
            this.pnlData.Controls.Add(this.gbData);
            this.pnlData.Controls.Add(this.gbProductData);
            this.pnlData.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlData.Location = new System.Drawing.Point(0, 0);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(1427, 240);
            this.pnlData.TabIndex = 15;
            // 
            // nudTotarPrice
            // 
            this.nudTotarPrice.Location = new System.Drawing.Point(908, 210);
            this.nudTotarPrice.Maximum = new decimal(new int[] {
            -1454759936,
            465,
            0,
            0});
            this.nudTotarPrice.Name = "nudTotarPrice";
            this.nudTotarPrice.ReadOnly = true;
            this.nudTotarPrice.Size = new System.Drawing.Size(151, 20);
            this.nudTotarPrice.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(805, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Toplam Tutar : ";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(22, 204);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(261, 20);
            this.txtSearch.TabIndex = 17;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // gbProductData
            // 
            this.gbProductData.Controls.Add(this.label4);
            this.gbProductData.Controls.Add(this.label3);
            this.gbProductData.Controls.Add(this.lblProductName);
            this.gbProductData.Controls.Add(this.txtProductName);
            this.gbProductData.Controls.Add(this.txtAdet);
            this.gbProductData.Controls.Add(this.pbPImage);
            this.gbProductData.Controls.Add(this.txtPSalePrice);
            this.gbProductData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbProductData.Location = new System.Drawing.Point(507, 12);
            this.gbProductData.Name = "gbProductData";
            this.gbProductData.Size = new System.Drawing.Size(885, 186);
            this.gbProductData.TabIndex = 14;
            this.gbProductData.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(309, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Adet : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(309, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Satış Fiyatı : ";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(309, 26);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(59, 16);
            this.lblProductName.TabIndex = 4;
            this.lblProductName.Text = "Ürun Adi";
            // 
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.Location = new System.Drawing.Point(401, 26);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.ReadOnly = true;
            this.txtProductName.Size = new System.Drawing.Size(151, 22);
            this.txtProductName.TabIndex = 5;
            // 
            // txtAdet
            // 
            this.txtAdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdet.Location = new System.Drawing.Point(401, 90);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.ReadOnly = true;
            this.txtAdet.Size = new System.Drawing.Size(151, 22);
            this.txtAdet.TabIndex = 7;
            // 
            // pbPImage
            // 
            this.pbPImage.Image = global::KapaliDevreOdemeSistemi.Properties.Resources.urun;
            this.pbPImage.Location = new System.Drawing.Point(140, 26);
            this.pbPImage.Name = "pbPImage";
            this.pbPImage.Size = new System.Drawing.Size(129, 111);
            this.pbPImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPImage.TabIndex = 3;
            this.pbPImage.TabStop = false;
            // 
            // txtPSalePrice
            // 
            this.txtPSalePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPSalePrice.Location = new System.Drawing.Point(401, 56);
            this.txtPSalePrice.Name = "txtPSalePrice";
            this.txtPSalePrice.ReadOnly = true;
            this.txtPSalePrice.Size = new System.Drawing.Size(151, 22);
            this.txtPSalePrice.TabIndex = 7;
            // 
            // gvList
            // 
            this.gvList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gvList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSil,
            this.colBarkod,
            this.colUrunAdi,
            this.colSatisFiyati,
            this.colAdet,
            this.colToplamTutar,
            this.colYasakDurumu});
            this.gvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvList.Location = new System.Drawing.Point(0, 240);
            this.gvList.MultiSelect = false;
            this.gvList.Name = "gvList";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.gvList.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.gvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gvList.Size = new System.Drawing.Size(1427, 563);
            this.gvList.TabIndex = 16;
            this.gvList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvList_CellContentClick);
            this.gvList.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvList_CellValueChanged);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Sil";
            this.dataGridViewImageColumn1.Image = global::KapaliDevreOdemeSistemi.Properties.Resources.delete;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.Width = 200;
            // 
            // colSil
            // 
            this.colSil.HeaderText = "Sil";
            this.colSil.Name = "colSil";
            this.colSil.ReadOnly = true;
            this.colSil.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colSil.Text = "Sil";
            this.colSil.UseColumnTextForButtonValue = true;
            this.colSil.Width = 200;
            // 
            // colBarkod
            // 
            this.colBarkod.HeaderText = "Barkod";
            this.colBarkod.Name = "colBarkod";
            this.colBarkod.ReadOnly = true;
            this.colBarkod.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colBarkod.Width = 200;
            // 
            // colUrunAdi
            // 
            this.colUrunAdi.HeaderText = "Ürun Adi";
            this.colUrunAdi.Name = "colUrunAdi";
            this.colUrunAdi.Width = 200;
            // 
            // colSatisFiyati
            // 
            this.colSatisFiyati.HeaderText = "Satış Fiyatı";
            this.colSatisFiyati.Name = "colSatisFiyati";
            this.colSatisFiyati.Width = 200;
            // 
            // colAdet
            // 
            this.colAdet.HeaderText = "Adet";
            this.colAdet.Name = "colAdet";
            this.colAdet.Width = 200;
            // 
            // colToplamTutar
            // 
            this.colToplamTutar.HeaderText = "ToplamTutar";
            this.colToplamTutar.Name = "colToplamTutar";
            this.colToplamTutar.ReadOnly = true;
            this.colToplamTutar.Width = 200;
            // 
            // colYasakDurumu
            // 
            this.colYasakDurumu.HeaderText = "Yasak Durumu";
            this.colYasakDurumu.Name = "colYasakDurumu";
            this.colYasakDurumu.Width = 200;
            // 
            // frmSalesPrudoct
            // 
            this.ClientSize = new System.Drawing.Size(1427, 803);
            this.Controls.Add(this.gvList);
            this.Controls.Add(this.pnlData);
            this.Name = "frmSalesPrudoct";
            this.gbData.ResumeLayout(false);
            this.gbData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBalance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMImage)).EndInit();
            this.pnlData.ResumeLayout(false);
            this.pnlData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotarPrice)).EndInit();
            this.gbProductData.ResumeLayout(false);
            this.gbProductData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvList)).EndInit();
            this.ResumeLayout(false);

        }

        public System.Windows.Forms.GroupBox gbData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbMImage;
        private System.Windows.Forms.TextBox txtAccountName;
        private System.Windows.Forms.Panel pnlData;
        public System.Windows.Forms.GroupBox gbProductData;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.PictureBox pbPImage;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView gvList;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtPSalePrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAdet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudTotarPrice;
        private System.Windows.Forms.NumericUpDown nudBalance;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMName;
        private System.Windows.Forms.TextBox txtMSurname;
        private System.Windows.Forms.DataGridViewButtonColumn colSil;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBarkod;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUrunAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSatisFiyati;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAdet;
        private System.Windows.Forms.DataGridViewTextBoxColumn colToplamTutar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colYasakDurumu;
    }
}