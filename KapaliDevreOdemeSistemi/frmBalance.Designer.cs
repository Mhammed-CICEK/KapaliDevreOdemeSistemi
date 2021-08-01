namespace KapaliDevreOdemeSistemi
{
    partial class frmBalance
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
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery2 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBalance));
            this.sleuKartNo = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.spCardListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colKartNo1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbBalanceType = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.cmbProcessType = new System.Windows.Forms.ComboBox();
            this.txtExplanation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInformation = new System.Windows.Forms.TextBox();
            this.nudTopUp = new System.Windows.Forms.NumericUpDown();
            this.btnTopUp = new System.Windows.Forms.Button();
            this.btnFormClear = new System.Windows.Forms.Button();
            this.txtAccountName = new System.Windows.Forms.TextBox();
            this.nudBalance = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.sleuKartNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCardListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTopUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBalance)).BeginInit();
            this.SuspendLayout();
            // 
            // sleuKartNo
            // 
            this.sleuKartNo.EditValue = "";
            this.sleuKartNo.Location = new System.Drawing.Point(413, 142);
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
            this.sleuKartNo.TabIndex = 53;
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
            storedProcQuery2.Name = "spCardList";
            storedProcQuery2.StoredProcName = "spCardList";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery2});
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
            // cmbBalanceType
            // 
            this.cmbBalanceType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBalanceType.FormattingEnabled = true;
            this.cmbBalanceType.Items.AddRange(new object[] {
            "Kontor",
            "Bonus",
            "Kart Bedeli"});
            this.cmbBalanceType.Location = new System.Drawing.Point(413, 280);
            this.cmbBalanceType.Name = "cmbBalanceType";
            this.cmbBalanceType.Size = new System.Drawing.Size(226, 33);
            this.cmbBalanceType.TabIndex = 51;
            this.cmbBalanceType.Text = "Seçiniz";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(107, 195);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(107, 20);
            this.label23.TabIndex = 42;
            this.label23.Text = "Hesap Adi : ";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(109, 149);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(84, 20);
            this.label27.TabIndex = 41;
            this.label27.Text = "Kart No : ";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(109, 388);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(91, 20);
            this.label31.TabIndex = 40;
            this.label31.Tag = "";
            this.label31.Text = "Açıklama :";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(109, 241);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(72, 20);
            this.label32.TabIndex = 39;
            this.label32.Text = "Bakiye :";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(109, 340);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(95, 20);
            this.label33.TabIndex = 38;
            this.label33.Text = "İşlem Tipi :";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(109, 287);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(101, 20);
            this.label36.TabIndex = 37;
            this.label36.Text = "Miktar Tipi :";
            // 
            // cmbProcessType
            // 
            this.cmbProcessType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProcessType.FormattingEnabled = true;
            this.cmbProcessType.Items.AddRange(new object[] {
            "KART BEDELLİ ALMA",
            "TUTAR GİREREK YÜKLEME"});
            this.cmbProcessType.Location = new System.Drawing.Point(413, 333);
            this.cmbProcessType.Name = "cmbProcessType";
            this.cmbProcessType.Size = new System.Drawing.Size(226, 33);
            this.cmbProcessType.TabIndex = 51;
            this.cmbProcessType.Text = "Seçiniz";
            // 
            // txtExplanation
            // 
            this.txtExplanation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExplanation.Location = new System.Drawing.Point(413, 381);
            this.txtExplanation.Name = "txtExplanation";
            this.txtExplanation.Size = new System.Drawing.Size(226, 31);
            this.txtExplanation.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(110, 434);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 20);
            this.label1.TabIndex = 40;
            this.label1.Tag = "";
            this.label1.Text = "Yüklenecek Miktar :";
            // 
            // txtInformation
            // 
            this.txtInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInformation.Location = new System.Drawing.Point(114, 485);
            this.txtInformation.Multiline = true;
            this.txtInformation.Name = "txtInformation";
            this.txtInformation.Size = new System.Drawing.Size(347, 92);
            this.txtInformation.TabIndex = 43;
            // 
            // nudTopUp
            // 
            this.nudTopUp.DecimalPlaces = 2;
            this.nudTopUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudTopUp.Location = new System.Drawing.Point(413, 433);
            this.nudTopUp.Name = "nudTopUp";
            this.nudTopUp.Size = new System.Drawing.Size(396, 31);
            this.nudTopUp.TabIndex = 55;
            // 
            // btnTopUp
            // 
            this.btnTopUp.FlatAppearance.BorderSize = 0;
            this.btnTopUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTopUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTopUp.Location = new System.Drawing.Point(654, 497);
            this.btnTopUp.Name = "btnTopUp";
            this.btnTopUp.Size = new System.Drawing.Size(135, 65);
            this.btnTopUp.TabIndex = 56;
            this.btnTopUp.Text = "Yükle";
            this.btnTopUp.UseVisualStyleBackColor = true;
            this.btnTopUp.Click += new System.EventHandler(this.btnTopUp_Click);
            // 
            // btnFormClear
            // 
            this.btnFormClear.FlatAppearance.BorderSize = 0;
            this.btnFormClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFormClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormClear.Location = new System.Drawing.Point(504, 497);
            this.btnFormClear.Name = "btnFormClear";
            this.btnFormClear.Size = new System.Drawing.Size(135, 65);
            this.btnFormClear.TabIndex = 56;
            this.btnFormClear.Text = "Temizle";
            this.btnFormClear.UseVisualStyleBackColor = true;
            this.btnFormClear.Click += new System.EventHandler(this.btnFormClear_Click);
            // 
            // txtAccountName
            // 
            this.txtAccountName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountName.Location = new System.Drawing.Point(413, 188);
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.ReadOnly = true;
            this.txtAccountName.Size = new System.Drawing.Size(226, 31);
            this.txtAccountName.TabIndex = 43;
            // 
            // nudBalance
            // 
            this.nudBalance.DecimalPlaces = 2;
            this.nudBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudBalance.Location = new System.Drawing.Point(413, 235);
            this.nudBalance.Name = "nudBalance";
            this.nudBalance.ReadOnly = true;
            this.nudBalance.Size = new System.Drawing.Size(226, 31);
            this.nudBalance.TabIndex = 55;
            // 
            // frmBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1465, 729);
            this.Controls.Add(this.btnFormClear);
            this.Controls.Add(this.btnTopUp);
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
            this.Name = "frmBalance";
            this.Text = "frmTopUp";
            ((System.ComponentModel.ISupportInitialize)(this.sleuKartNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCardListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTopUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBalance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SearchLookUpEdit sleuKartNo;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colKartNo1;
        private System.Windows.Forms.ComboBox cmbBalanceType;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.ComboBox cmbProcessType;
        private System.Windows.Forms.TextBox txtExplanation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInformation;
        private System.Windows.Forms.NumericUpDown nudTopUp;
        private System.Windows.Forms.Button btnTopUp;
        private System.Windows.Forms.Button btnFormClear;
        private System.Windows.Forms.TextBox txtAccountName;
        private System.Windows.Forms.BindingSource spCardListBindingSource;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private System.Windows.Forms.NumericUpDown nudBalance;
    }
}