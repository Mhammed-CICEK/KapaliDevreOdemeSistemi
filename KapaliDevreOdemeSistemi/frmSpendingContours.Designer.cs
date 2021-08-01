namespace KapaliDevreOdemeSistemi
{
    partial class frmSpendingContours
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
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery3 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSpendingContours));
            this.btnFormClear = new System.Windows.Forms.Button();
            this.btnSpendingContour = new System.Windows.Forms.Button();
            this.nudBalance = new System.Windows.Forms.NumericUpDown();
            this.nudTopUp = new System.Windows.Forms.NumericUpDown();
            this.sleuKartNo = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.spCardListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colKartNo1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbProcessType = new System.Windows.Forms.ComboBox();
            this.cmbBalanceType = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.txtInformation = new System.Windows.Forms.TextBox();
            this.txtAccountName = new System.Windows.Forms.TextBox();
            this.txtExplanation = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.btnCardRetrieve = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudBalance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTopUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sleuKartNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCardListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFormClear
            // 
            this.btnFormClear.FlatAppearance.BorderSize = 0;
            this.btnFormClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFormClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormClear.Location = new System.Drawing.Point(588, 461);
            this.btnFormClear.Name = "btnFormClear";
            this.btnFormClear.Size = new System.Drawing.Size(135, 65);
            this.btnFormClear.TabIndex = 73;
            this.btnFormClear.Text = "Temizle";
            this.btnFormClear.UseVisualStyleBackColor = true;
            this.btnFormClear.Click += new System.EventHandler(this.btnFormClear_Click);
            // 
            // btnSpendingContour
            // 
            this.btnSpendingContour.FlatAppearance.BorderSize = 0;
            this.btnSpendingContour.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSpendingContour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpendingContour.Location = new System.Drawing.Point(738, 461);
            this.btnSpendingContour.Name = "btnSpendingContour";
            this.btnSpendingContour.Size = new System.Drawing.Size(135, 65);
            this.btnSpendingContour.TabIndex = 72;
            this.btnSpendingContour.Text = "Kantür Harca";
            this.btnSpendingContour.UseVisualStyleBackColor = true;
            this.btnSpendingContour.Click += new System.EventHandler(this.btnSpendingContour_Click);
            // 
            // nudBalance
            // 
            this.nudBalance.DecimalPlaces = 2;
            this.nudBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudBalance.Location = new System.Drawing.Point(497, 199);
            this.nudBalance.Name = "nudBalance";
            this.nudBalance.ReadOnly = true;
            this.nudBalance.Size = new System.Drawing.Size(226, 31);
            this.nudBalance.TabIndex = 71;
            // 
            // nudTopUp
            // 
            this.nudTopUp.DecimalPlaces = 2;
            this.nudTopUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudTopUp.Location = new System.Drawing.Point(497, 397);
            this.nudTopUp.Name = "nudTopUp";
            this.nudTopUp.Size = new System.Drawing.Size(396, 31);
            this.nudTopUp.TabIndex = 70;
            // 
            // sleuKartNo
            // 
            this.sleuKartNo.EditValue = "";
            this.sleuKartNo.Location = new System.Drawing.Point(497, 106);
            this.sleuKartNo.Name = "sleuKartNo";
            this.sleuKartNo.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sleuKartNo.Properties.Appearance.Options.UseFont = true;
            this.sleuKartNo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sleuKartNo.Properties.DataSource = this.spCardListBindingSource;
            this.sleuKartNo.Properties.DisplayMember = "KartNo";
            this.sleuKartNo.Properties.PopupView = this.searchLookUpEdit1View;
            this.sleuKartNo.Properties.ValueMember = "Id";
            this.sleuKartNo.Size = new System.Drawing.Size(226, 32);
            this.sleuKartNo.TabIndex = 69;
            this.sleuKartNo.EditValueChanged += new System.EventHandler(this.sleuKartNo_EditValueChanged);
            // 
            // spCardListBindingSource
            // 
            this.spCardListBindingSource.DataMember = "spCardList";
            this.spCardListBindingSource.DataSource = this.sqlDataSource1;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "sqlBaglanti";
            this.sqlDataSource1.Name = "sqlDataSource1";
            storedProcQuery3.Name = "spCardList";
            storedProcQuery3.StoredProcName = "spCardList";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery3});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colKartNo1});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colKartNo1
            // 
            this.colKartNo1.FieldName = "KartNo";
            this.colKartNo1.Name = "colKartNo1";
            this.colKartNo1.Visible = true;
            this.colKartNo1.VisibleIndex = 0;
            // 
            // cmbProcessType
            // 
            this.cmbProcessType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProcessType.FormattingEnabled = true;
            this.cmbProcessType.Items.AddRange(new object[] {
            "KART BEDELLİ ALMA",
            "TUTAR GİREREK HARCAMA"});
            this.cmbProcessType.Location = new System.Drawing.Point(497, 297);
            this.cmbProcessType.Name = "cmbProcessType";
            this.cmbProcessType.Size = new System.Drawing.Size(226, 33);
            this.cmbProcessType.TabIndex = 68;
            this.cmbProcessType.Text = "Seçiniz";
            // 
            // cmbBalanceType
            // 
            this.cmbBalanceType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBalanceType.FormattingEnabled = true;
            this.cmbBalanceType.Items.AddRange(new object[] {
            "Kontor",
            "Bonus",
            "Kart Bedeli"});
            this.cmbBalanceType.Location = new System.Drawing.Point(497, 244);
            this.cmbBalanceType.Name = "cmbBalanceType";
            this.cmbBalanceType.Size = new System.Drawing.Size(226, 33);
            this.cmbBalanceType.TabIndex = 67;
            this.cmbBalanceType.Text = "Seçiniz";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(191, 159);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(107, 20);
            this.label23.TabIndex = 63;
            this.label23.Text = "Hesap Adi : ";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(193, 113);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(84, 20);
            this.label27.TabIndex = 62;
            this.label27.Text = "Kart No : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(194, 398);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 20);
            this.label1.TabIndex = 61;
            this.label1.Tag = "";
            this.label1.Text = "Yüklenecek Miktar :";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(193, 352);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(91, 20);
            this.label31.TabIndex = 60;
            this.label31.Tag = "";
            this.label31.Text = "Açıklama :";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(193, 205);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(72, 20);
            this.label32.TabIndex = 59;
            this.label32.Text = "Bakiye :";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(193, 304);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(95, 20);
            this.label33.TabIndex = 58;
            this.label33.Text = "İşlem Tipi :";
            // 
            // txtInformation
            // 
            this.txtInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInformation.Location = new System.Drawing.Point(198, 449);
            this.txtInformation.Multiline = true;
            this.txtInformation.Name = "txtInformation";
            this.txtInformation.Size = new System.Drawing.Size(347, 92);
            this.txtInformation.TabIndex = 65;
            // 
            // txtAccountName
            // 
            this.txtAccountName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountName.Location = new System.Drawing.Point(497, 152);
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.ReadOnly = true;
            this.txtAccountName.Size = new System.Drawing.Size(226, 31);
            this.txtAccountName.TabIndex = 66;
            // 
            // txtExplanation
            // 
            this.txtExplanation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExplanation.Location = new System.Drawing.Point(497, 345);
            this.txtExplanation.Name = "txtExplanation";
            this.txtExplanation.Size = new System.Drawing.Size(226, 31);
            this.txtExplanation.TabIndex = 64;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(193, 251);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(101, 20);
            this.label36.TabIndex = 57;
            this.label36.Text = "Miktar Tipi :";
            // 
            // btnCardRetrieve
            // 
            this.btnCardRetrieve.FlatAppearance.BorderSize = 0;
            this.btnCardRetrieve.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCardRetrieve.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCardRetrieve.Location = new System.Drawing.Point(903, 461);
            this.btnCardRetrieve.Name = "btnCardRetrieve";
            this.btnCardRetrieve.Size = new System.Drawing.Size(181, 121);
            this.btnCardRetrieve.TabIndex = 72;
            this.btnCardRetrieve.Text = "Kartı Geri Alma";
            this.btnCardRetrieve.UseVisualStyleBackColor = true;
            this.btnCardRetrieve.Click += new System.EventHandler(this.btnCardRetrieve_Click);
            // 
            // frmSpendingContours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 749);
            this.Controls.Add(this.btnFormClear);
            this.Controls.Add(this.btnCardRetrieve);
            this.Controls.Add(this.btnSpendingContour);
            this.Controls.Add(this.nudBalance);
            this.Controls.Add(this.nudTopUp);
            this.Controls.Add(this.sleuKartNo);
            this.Controls.Add(this.cmbProcessType);
            this.Controls.Add(this.cmbBalanceType);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.txtInformation);
            this.Controls.Add(this.txtAccountName);
            this.Controls.Add(this.txtExplanation);
            this.Controls.Add(this.label36);
            this.Name = "frmSpendingContours";
            this.Text = "frmSpendingContours";
            ((System.ComponentModel.ISupportInitialize)(this.nudBalance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTopUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sleuKartNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCardListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFormClear;
        private System.Windows.Forms.Button btnSpendingContour;
        private System.Windows.Forms.NumericUpDown nudBalance;
        private System.Windows.Forms.NumericUpDown nudTopUp;
        private DevExpress.XtraEditors.SearchLookUpEdit sleuKartNo;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colKartNo1;
        private System.Windows.Forms.ComboBox cmbProcessType;
        private System.Windows.Forms.ComboBox cmbBalanceType;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox txtInformation;
        private System.Windows.Forms.TextBox txtAccountName;
        private System.Windows.Forms.TextBox txtExplanation;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.BindingSource spCardListBindingSource;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private System.Windows.Forms.Button btnCardRetrieve;
    }
}