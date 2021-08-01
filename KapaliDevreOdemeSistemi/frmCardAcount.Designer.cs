namespace KapaliDevreOdemeSistemi
{
    partial class frmCardAcount
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
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery1 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCardAcount));
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery2 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            this.sleuMembersList = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.spMembersListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sdsMemberList = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIsim1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoyisim1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoyisim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sleuKartNo = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.spCardListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sdsCardList = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colKartNo1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKartTipi1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gbMCALimit = new System.Windows.Forms.GroupBox();
            this.deMCAStatringDate = new DevExpress.XtraEditors.DateEdit();
            this.label37 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.nudRefreshInterval = new System.Windows.Forms.NumericUpDown();
            this.nudMCAAmountSpend = new System.Windows.Forms.NumericUpDown();
            this.cmbState = new System.Windows.Forms.ComboBox();
            this.cmbAcountType = new System.Windows.Forms.ComboBox();
            this.mtxtCardPassword = new System.Windows.Forms.MaskedTextBox();
            this.nudMCABonus = new System.Windows.Forms.NumericUpDown();
            this.nudMCANegativeBalance = new System.Windows.Forms.NumericUpDown();
            this.cbMCABonus = new System.Windows.Forms.CheckBox();
            this.cbMCANegativeBalance = new System.Windows.Forms.CheckBox();
            this.cbMCALimitSpending = new System.Windows.Forms.CheckBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.txtAcountName = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.pnlDataPanel.SuspendLayout();
            this.gbData.SuspendLayout();
            this.pnlButton.SuspendLayout();
            this.gbButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sleuMembersList.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spMembersListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sleuKartNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCardListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.gbMCALimit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deMCAStatringDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deMCAStatringDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRefreshInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMCAAmountSpend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMCABonus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMCANegativeBalance)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDataPanel
            // 
            this.pnlDataPanel.Size = new System.Drawing.Size(1904, 202);
            // 
            // gbData
            // 
            this.gbData.Controls.Add(this.sleuMembersList);
            this.gbData.Controls.Add(this.sleuKartNo);
            this.gbData.Controls.Add(this.gbMCALimit);
            this.gbData.Controls.Add(this.cmbState);
            this.gbData.Controls.Add(this.cmbAcountType);
            this.gbData.Controls.Add(this.mtxtCardPassword);
            this.gbData.Controls.Add(this.nudMCABonus);
            this.gbData.Controls.Add(this.nudMCANegativeBalance);
            this.gbData.Controls.Add(this.cbMCABonus);
            this.gbData.Controls.Add(this.cbMCANegativeBalance);
            this.gbData.Controls.Add(this.cbMCALimitSpending);
            this.gbData.Controls.Add(this.label23);
            this.gbData.Controls.Add(this.label27);
            this.gbData.Controls.Add(this.label31);
            this.gbData.Controls.Add(this.label32);
            this.gbData.Controls.Add(this.label33);
            this.gbData.Controls.Add(this.txtAcountName);
            this.gbData.Controls.Add(this.label36);
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
            // 
            // btnNewRecord
            // 
            this.btnNewRecord.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNewRecord.FlatAppearance.BorderSize = 0;
            this.btnNewRecord.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnNewRecord.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnNewRecord.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // btnReturn
            // 
            this.btnReturn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnReturn.FlatAppearance.BorderSize = 0;
            this.btnReturn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnReturn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnReturn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            //
            // sleuMembersList
            // 
            this.sleuMembersList.EditValue = "";
            this.sleuMembersList.Location = new System.Drawing.Point(178, 22);
            this.sleuMembersList.Name = "sleuMembersList";
            this.sleuMembersList.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sleuMembersList.Properties.DataSource = this.spMembersListBindingSource;
            this.sleuMembersList.Properties.DisplayMember = "Isim";
            this.sleuMembersList.Properties.PopupView = this.gridView2;
            this.sleuMembersList.Properties.ValueMember = "id";
            this.sleuMembersList.Size = new System.Drawing.Size(150, 20);
            this.sleuMembersList.TabIndex = 36;
            // 
            // spMembersListBindingSource
            // 
            this.spMembersListBindingSource.DataMember = "spMembersList";
            this.spMembersListBindingSource.DataSource = this.sdsMemberList;
            // 
            // sdsMemberList
            // 
            this.sdsMemberList.ConnectionName = "sqlBaglanti";
            this.sdsMemberList.Name = "sdsMemberList";
            storedProcQuery1.Name = "spMembersList";
            storedProcQuery1.StoredProcName = "spMembersList";
            this.sdsMemberList.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
            this.sdsMemberList.ResultSchemaSerializable = resources.GetString("sdsMemberList.ResultSchemaSerializable");
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIsim1,
            this.colSoyisim1});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colIsim1
            // 
            this.colIsim1.FieldName = "Isim";
            this.colIsim1.Name = "colIsim1";
            this.colIsim1.Visible = true;
            this.colIsim1.VisibleIndex = 0;
            // 
            // colSoyisim1
            // 
            this.colSoyisim1.FieldName = "Soyisim";
            this.colSoyisim1.Name = "colSoyisim1";
            this.colSoyisim1.Visible = true;
            this.colSoyisim1.VisibleIndex = 1;
            // 
            // colIsim
            // 
            this.colIsim.FieldName = "Isim";
            this.colIsim.Name = "colIsim";
            this.colIsim.Visible = true;
            this.colIsim.VisibleIndex = 0;
            // 
            // colSoyisim
            // 
            this.colSoyisim.FieldName = "Soyisim";
            this.colSoyisim.Name = "colSoyisim";
            this.colSoyisim.Visible = true;
            this.colSoyisim.VisibleIndex = 1;
            // 
            // sleuKartNo
            // 
            this.sleuKartNo.EditValue = "";
            this.sleuKartNo.Location = new System.Drawing.Point(178, 51);
            this.sleuKartNo.Name = "sleuKartNo";
            this.sleuKartNo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sleuKartNo.Properties.DataSource = this.spCardListBindingSource;
            this.sleuKartNo.Properties.DisplayMember = "KartNo";
            this.sleuKartNo.Properties.PopupView = this.searchLookUpEdit1View;
            this.sleuKartNo.Properties.ValueMember = "Id";
            this.sleuKartNo.Size = new System.Drawing.Size(150, 20);
            this.sleuKartNo.TabIndex = 35;
            // 
            // spCardListBindingSource
            // 
            this.spCardListBindingSource.DataMember = "spCardList";
            this.spCardListBindingSource.DataSource = this.sdsCardList;
            // 
            // sdsCardList
            // 
            this.sdsCardList.ConnectionName = "sqlBaglanti";
            this.sdsCardList.Name = "sdsCardList";
            storedProcQuery2.Name = "spCardList";
            storedProcQuery2.StoredProcName = "spCardList";
            this.sdsCardList.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery2});
            this.sdsCardList.ResultSchemaSerializable = resources.GetString("sdsCardList.ResultSchemaSerializable");
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colKartNo1,
            this.colKartTipi1});
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
            // colKartTipi1
            // 
            this.colKartTipi1.FieldName = "KartTipi";
            this.colKartTipi1.Name = "colKartTipi1";
            this.colKartTipi1.Visible = true;
            this.colKartTipi1.VisibleIndex = 1;
            // 
            // gbMCALimit
            // 
            this.gbMCALimit.Controls.Add(this.deMCAStatringDate);
            this.gbMCALimit.Controls.Add(this.label37);
            this.gbMCALimit.Controls.Add(this.label34);
            this.gbMCALimit.Controls.Add(this.label28);
            this.gbMCALimit.Controls.Add(this.nudRefreshInterval);
            this.gbMCALimit.Controls.Add(this.nudMCAAmountSpend);
            this.gbMCALimit.Enabled = false;
            this.gbMCALimit.Location = new System.Drawing.Point(448, 37);
            this.gbMCALimit.Name = "gbMCALimit";
            this.gbMCALimit.Size = new System.Drawing.Size(394, 115);
            this.gbMCALimit.TabIndex = 34;
            this.gbMCALimit.TabStop = false;
            this.gbMCALimit.Text = "Harcama Limit Ayarları";
            // 
            // deMCAStatringDate
            // 
            this.deMCAStatringDate.EditValue = null;
            this.deMCAStatringDate.Location = new System.Drawing.Point(191, 18);
            this.deMCAStatringDate.Name = "deMCAStatringDate";
            this.deMCAStatringDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deMCAStatringDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deMCAStatringDate.Size = new System.Drawing.Size(150, 20);
            this.deMCAStatringDate.TabIndex = 12;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(21, 78);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(160, 16);
            this.label37.TabIndex = 1;
            this.label37.Text = "Harcanabilecek Miktar :";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(57, 49);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(124, 16);
            this.label34.TabIndex = 1;
            this.label34.Text = "Yenileme Aralığı : ";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(61, 19);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(120, 16);
            this.label28.TabIndex = 1;
            this.label28.Text = "Başlangıç Tarihi : ";
            // 
            // nudRefreshInterval
            // 
            this.nudRefreshInterval.Location = new System.Drawing.Point(191, 44);
            this.nudRefreshInterval.Name = "nudRefreshInterval";
            this.nudRefreshInterval.Size = new System.Drawing.Size(58, 23);
            this.nudRefreshInterval.TabIndex = 14;
            // 
            // nudMCAAmountSpend
            // 
            this.nudMCAAmountSpend.DecimalPlaces = 2;
            this.nudMCAAmountSpend.Location = new System.Drawing.Point(190, 74);
            this.nudMCAAmountSpend.Name = "nudMCAAmountSpend";
            this.nudMCAAmountSpend.Size = new System.Drawing.Size(59, 23);
            this.nudMCAAmountSpend.TabIndex = 14;
            // 
            // cmbState
            // 
            this.cmbState.FormattingEnabled = true;
            this.cmbState.Items.AddRange(new object[] {
            "AKTİF",
            "PASİF"});
            this.cmbState.Location = new System.Drawing.Point(178, 106);
            this.cmbState.Name = "cmbState";
            this.cmbState.Size = new System.Drawing.Size(148, 24);
            this.cmbState.TabIndex = 33;
            this.cmbState.Text = "Seçiniz";
            // 
            // cmbAcountType
            // 
            this.cmbAcountType.FormattingEnabled = true;
            this.cmbAcountType.Items.AddRange(new object[] {
            "Ogrenci",
            "Personel",
            "Ogretmen",
            "Idareci"});
            this.cmbAcountType.Location = new System.Drawing.Point(178, 78);
            this.cmbAcountType.Name = "cmbAcountType";
            this.cmbAcountType.Size = new System.Drawing.Size(148, 24);
            this.cmbAcountType.TabIndex = 32;
            this.cmbAcountType.Text = "Seçiniz";
            // 
            // mtxtCardPassword
            // 
            this.mtxtCardPassword.Location = new System.Drawing.Point(177, 136);
            this.mtxtCardPassword.Mask = "0000";
            this.mtxtCardPassword.Name = "mtxtCardPassword";
            this.mtxtCardPassword.Size = new System.Drawing.Size(149, 23);
            this.mtxtCardPassword.TabIndex = 31;
            this.mtxtCardPassword.ValidatingType = typeof(int);
            // 
            // nudMCABonus
            // 
            this.nudMCABonus.DecimalPlaces = 2;
            this.nudMCABonus.Enabled = false;
            this.nudMCABonus.Location = new System.Drawing.Point(1046, 90);
            this.nudMCABonus.Name = "nudMCABonus";
            this.nudMCABonus.Size = new System.Drawing.Size(59, 23);
            this.nudMCABonus.TabIndex = 29;
            // 
            // nudMCANegativeBalance
            // 
            this.nudMCANegativeBalance.DecimalPlaces = 2;
            this.nudMCANegativeBalance.Enabled = false;
            this.nudMCANegativeBalance.Location = new System.Drawing.Point(972, 52);
            this.nudMCANegativeBalance.Name = "nudMCANegativeBalance";
            this.nudMCANegativeBalance.Size = new System.Drawing.Size(59, 23);
            this.nudMCANegativeBalance.TabIndex = 30;
            // 
            // cbMCABonus
            // 
            this.cbMCABonus.AutoSize = true;
            this.cbMCABonus.Location = new System.Drawing.Point(865, 94);
            this.cbMCABonus.Name = "cbMCABonus";
            this.cbMCABonus.Size = new System.Drawing.Size(179, 20);
            this.cbMCABonus.TabIndex = 28;
            this.cbMCABonus.Text = "Bonus Kazanma Oranı : ";
            this.cbMCABonus.UseVisualStyleBackColor = true;
            this.cbMCABonus.CheckedChanged += new System.EventHandler(this.cbMCABonus_CheckedChanged);
            // 
            // cbMCANegativeBalance
            // 
            this.cbMCANegativeBalance.AutoSize = true;
            this.cbMCANegativeBalance.Location = new System.Drawing.Point(865, 52);
            this.cbMCANegativeBalance.Name = "cbMCANegativeBalance";
            this.cbMCANegativeBalance.Size = new System.Drawing.Size(110, 20);
            this.cbMCANegativeBalance.TabIndex = 27;
            this.cbMCANegativeBalance.Text = "Eksi Bakiye : ";
            this.cbMCANegativeBalance.UseVisualStyleBackColor = true;
            this.cbMCANegativeBalance.CheckedChanged += new System.EventHandler(this.cbMCANegativeBalance_CheckedChanged);
            // 
            // cbMCALimitSpending
            // 
            this.cbMCALimitSpending.AutoSize = true;
            this.cbMCALimitSpending.Location = new System.Drawing.Point(477, 11);
            this.cbMCALimitSpending.Name = "cbMCALimitSpending";
            this.cbMCALimitSpending.Size = new System.Drawing.Size(152, 20);
            this.cbMCALimitSpending.TabIndex = 26;
            this.cbMCALimitSpending.Text = "Harcama Sınırlandır";
            this.cbMCALimitSpending.UseVisualStyleBackColor = true;
            this.cbMCALimitSpending.CheckedChanged += new System.EventHandler(this.cbMCALimitSpending_CheckedChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(45, 23);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(70, 16);
            this.label23.TabIndex = 24;
            this.label23.Text = "Uye Adı : ";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(45, 52);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(69, 16);
            this.label27.TabIndex = 23;
            this.label27.Text = "Kart No : ";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(45, 170);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(82, 16);
            this.label31.TabIndex = 22;
            this.label31.Tag = "";
            this.label31.Text = "Hesap Adı :";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(45, 81);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(86, 16);
            this.label32.TabIndex = 21;
            this.label32.Text = "Hesap Tipi : ";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(45, 139);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(93, 16);
            this.label33.TabIndex = 20;
            this.label33.Text = "Kart Şifresi : ";
            // 
            // txtAcountName
            // 
            this.txtAcountName.Location = new System.Drawing.Point(175, 167);
            this.txtAcountName.Name = "txtAcountName";
            this.txtAcountName.Size = new System.Drawing.Size(151, 23);
            this.txtAcountName.TabIndex = 25;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(45, 110);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(71, 16);
            this.label36.TabIndex = 19;
            this.label36.Text = "Durumu : ";
            // 
            // frmCardAcount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Name = "frmCardAcount";
            this.Text = "frmCardAcount";
            this.pnlDataPanel.ResumeLayout(false);
            this.gbData.ResumeLayout(false);
            this.gbData.PerformLayout();
            this.pnlButton.ResumeLayout(false);
            this.gbButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sleuMembersList.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spMembersListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sleuKartNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCardListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.gbMCALimit.ResumeLayout(false);
            this.gbMCALimit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deMCAStatringDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deMCAStatringDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRefreshInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMCAAmountSpend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMCABonus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMCANegativeBalance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SearchLookUpEdit sleuMembersList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.SearchLookUpEdit sleuKartNo;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colKartNo1;
        private DevExpress.XtraGrid.Columns.GridColumn colKartTipi1;
        private System.Windows.Forms.GroupBox gbMCALimit;
        private DevExpress.XtraEditors.DateEdit deMCAStatringDate;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.NumericUpDown nudMCAAmountSpend;
        private System.Windows.Forms.ComboBox cmbState;
        private System.Windows.Forms.ComboBox cmbAcountType;
        private System.Windows.Forms.MaskedTextBox mtxtCardPassword;
        private System.Windows.Forms.NumericUpDown nudMCABonus;
        private System.Windows.Forms.NumericUpDown nudMCANegativeBalance;
        private System.Windows.Forms.CheckBox cbMCABonus;
        private System.Windows.Forms.CheckBox cbMCANegativeBalance;
        private System.Windows.Forms.CheckBox cbMCALimitSpending;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox txtAcountName;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.BindingSource spMembersListBindingSource;
        private DevExpress.DataAccess.Sql.SqlDataSource sdsMemberList;
        private System.Windows.Forms.BindingSource spCardListBindingSource;
        private DevExpress.DataAccess.Sql.SqlDataSource sdsCardList;
        private DevExpress.XtraGrid.Columns.GridColumn colIsim;
        private DevExpress.XtraGrid.Columns.GridColumn colSoyisim;
        private DevExpress.XtraGrid.Columns.GridColumn colIsim1;
        private DevExpress.XtraGrid.Columns.GridColumn colSoyisim1;
        private System.Windows.Forms.NumericUpDown nudRefreshInterval;
    }
}