
namespace KapaliDevreOdemeSistemi
{
    partial class frmUserPermision
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
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery3 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery4 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserPermision));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.sdsPermissionsList = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtPermissionsGoupName = new System.Windows.Forms.TextBox();
            this.btnAddPermissionsGroup = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sleuPermissinGupList = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.queryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sdsPermissionsGroupList = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colGrupAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnPermissionSave = new System.Windows.Forms.Button();
            this.gvPermissinList = new System.Windows.Forms.DataGridView();
            this.permissionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kapaliDevreOdemeSistemiDataSet = new KapaliDevreOdemeSistemi.KapaliDevreOdemeSistemiDataSet();
            this.permissionsTableAdapter = new KapaliDevreOdemeSistemi.KapaliDevreOdemeSistemiDataSetTableAdapters.PermissionsTableAdapter();
            this.yetkiAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colYetkiGrubu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGoruntuluyebilir = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colGuncellebilir = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colGuncelleyenKullanici = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGuncellemeTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlDataPanel.SuspendLayout();
            this.gbData.SuspendLayout();
            this.pnlButton.SuspendLayout();
            this.gbButton.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sleuPermissinGupList.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPermissinList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kapaliDevreOdemeSistemiDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDataPanel
            // 
            this.pnlDataPanel.Controls.Add(this.groupBox1);
            this.pnlDataPanel.Controls.SetChildIndex(this.gbData, 0);
            this.pnlDataPanel.Controls.SetChildIndex(this.groupBox1, 0);
            // 
            // gbData
            // 
            this.gbData.Controls.Add(this.btnAddPermissionsGroup);
            this.gbData.Controls.Add(this.txtPermissionsGoupName);
            this.gbData.Controls.Add(this.label1);
            this.gbData.Location = new System.Drawing.Point(13, 23);
            this.gbData.Size = new System.Drawing.Size(437, 164);
            this.gbData.Text = "Yetki Grup İşlemleri";
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
            // sdsPermissionsList
            // 
            this.sdsPermissionsList.ConnectionName = "sqlBaglanti";
            this.sdsPermissionsList.Name = "sdsPermissionsList";
            customSqlQuery3.Name = "Query";
            customSqlQuery3.Sql = "Select * from vwPermissionsList\r\n";
            this.sdsPermissionsList.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery3});
            this.sdsPermissionsList.ResultSchemaSerializable = "PERhdGFTZXQgTmFtZT0ic2RzUGVybWlzc2lvbnNMaXN0Ij48VmlldyBOYW1lPSJRdWVyeSI+PEZpZWxkI" +
    "E5hbWU9IllldGtpQWRpIiBUeXBlPSJTdHJpbmciIC8+PC9WaWV3PjwvRGF0YVNldD4=";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Yetki Grubu Adi : ";
            // 
            // txtPermissionsGoupName
            // 
            this.txtPermissionsGoupName.Location = new System.Drawing.Point(162, 44);
            this.txtPermissionsGoupName.Name = "txtPermissionsGoupName";
            this.txtPermissionsGoupName.Size = new System.Drawing.Size(147, 23);
            this.txtPermissionsGoupName.TabIndex = 2;
            // 
            // btnAddPermissionsGroup
            // 
            this.btnAddPermissionsGroup.Location = new System.Drawing.Point(90, 89);
            this.btnAddPermissionsGroup.Name = "btnAddPermissionsGroup";
            this.btnAddPermissionsGroup.Size = new System.Drawing.Size(161, 31);
            this.btnAddPermissionsGroup.TabIndex = 3;
            this.btnAddPermissionsGroup.Text = "Yetki Grubu Ekle";
            this.btnAddPermissionsGroup.UseVisualStyleBackColor = true;
            this.btnAddPermissionsGroup.Click += new System.EventHandler(this.btnAddPermissionsGroup_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sleuPermissinGupList);
            this.groupBox1.Controls.Add(this.btnPermissionSave);
            this.groupBox1.Location = new System.Drawing.Point(456, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(521, 164);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yetki Ayarlama";
            // 
            // sleuPermissinGupList
            // 
            this.sleuPermissinGupList.Location = new System.Drawing.Point(51, 42);
            this.sleuPermissinGupList.Name = "sleuPermissinGupList";
            this.sleuPermissinGupList.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sleuPermissinGupList.Properties.DataSource = this.queryBindingSource;
            this.sleuPermissinGupList.Properties.DisplayMember = "GrupAdi";
            this.sleuPermissinGupList.Properties.PopupView = this.searchLookUpEdit1View;
            this.sleuPermissinGupList.Properties.ValueMember = "PermissionGruopId";
            this.sleuPermissinGupList.Size = new System.Drawing.Size(161, 20);
            this.sleuPermissinGupList.TabIndex = 11;
            this.sleuPermissinGupList.EditValueChanged += new System.EventHandler(this.slePermissinGupList_EditValueChanged);
            // 
            // queryBindingSource
            // 
            this.queryBindingSource.DataMember = "Query";
            this.queryBindingSource.DataSource = this.sdsPermissionsGroupList;
            // 
            // sdsPermissionsGroupList
            // 
            this.sdsPermissionsGroupList.ConnectionName = "sqlBaglanti";
            this.sdsPermissionsGroupList.Name = "sdsPermissionsGroupList";
            customSqlQuery4.Name = "Query";
            customSqlQuery4.Sql = "Select * from PermisionGroup";
            this.sdsPermissionsGroupList.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery4});
            this.sdsPermissionsGroupList.ResultSchemaSerializable = resources.GetString("sdsPermissionsGroupList.ResultSchemaSerializable");
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colGrupAdi});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colGrupAdi
            // 
            this.colGrupAdi.FieldName = "GrupAdi";
            this.colGrupAdi.Name = "colGrupAdi";
            this.colGrupAdi.Visible = true;
            this.colGrupAdi.VisibleIndex = 0;
            // 
            // btnPermissionSave
            // 
            this.btnPermissionSave.Location = new System.Drawing.Point(51, 89);
            this.btnPermissionSave.Name = "btnPermissionSave";
            this.btnPermissionSave.Size = new System.Drawing.Size(161, 31);
            this.btnPermissionSave.TabIndex = 10;
            this.btnPermissionSave.Text = "Yetkileri Kaydet";
            this.btnPermissionSave.UseVisualStyleBackColor = true;
            this.btnPermissionSave.Click += new System.EventHandler(this.btnPermissionSave_Click);
            // 
            // gvPermissinList
            // 
            this.gvPermissinList.AllowUserToOrderColumns = true;
            this.gvPermissinList.AutoGenerateColumns = false;
            this.gvPermissinList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvPermissinList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gvPermissinList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvPermissinList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.yetkiAdiDataGridViewTextBoxColumn,
            this.colYetkiGrubu,
            this.colGoruntuluyebilir,
            this.colGuncellebilir,
            this.colGuncelleyenKullanici,
            this.colGuncellemeTarihi});
            this.gvPermissinList.DataSource = this.permissionsBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvPermissinList.DefaultCellStyle = dataGridViewCellStyle4;
            this.gvPermissinList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvPermissinList.Location = new System.Drawing.Point(0, 309);
            this.gvPermissinList.Name = "gvPermissinList";
            this.gvPermissinList.Size = new System.Drawing.Size(1570, 393);
            this.gvPermissinList.TabIndex = 13;
            // 
            // permissionsBindingSource
            // 
            this.permissionsBindingSource.DataMember = "Permissions";
            this.permissionsBindingSource.DataSource = this.kapaliDevreOdemeSistemiDataSet;
            // 
            // kapaliDevreOdemeSistemiDataSet
            // 
            this.kapaliDevreOdemeSistemiDataSet.DataSetName = "KapaliDevreOdemeSistemiDataSet";
            this.kapaliDevreOdemeSistemiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // permissionsTableAdapter
            // 
            this.permissionsTableAdapter.ClearBeforeFill = true;
            // 
            // yetkiAdiDataGridViewTextBoxColumn
            // 
            this.yetkiAdiDataGridViewTextBoxColumn.DataPropertyName = "YetkiAdi";
            this.yetkiAdiDataGridViewTextBoxColumn.HeaderText = "YetkiAdi";
            this.yetkiAdiDataGridViewTextBoxColumn.Name = "yetkiAdiDataGridViewTextBoxColumn";
            this.yetkiAdiDataGridViewTextBoxColumn.ReadOnly = true;
            this.yetkiAdiDataGridViewTextBoxColumn.Width = 500;
            // 
            // colYetkiGrubu
            // 
            this.colYetkiGrubu.HeaderText = "Yetki Gurbu";
            this.colYetkiGrubu.Name = "colYetkiGrubu";
            this.colYetkiGrubu.Visible = false;
            this.colYetkiGrubu.Width = 200;
            // 
            // colGoruntuluyebilir
            // 
            this.colGoruntuluyebilir.HeaderText = "Görüntüleyebilir";
            this.colGoruntuluyebilir.Name = "colGoruntuluyebilir";
            this.colGoruntuluyebilir.ThreeState = true;
            this.colGoruntuluyebilir.Width = 200;
            // 
            // colGuncellebilir
            // 
            this.colGuncellebilir.DataPropertyName = "PermissionGruopId";
            this.colGuncellebilir.HeaderText = "Güncelleyebilir";
            this.colGuncellebilir.Name = "colGuncellebilir";
            this.colGuncellebilir.ThreeState = true;
            this.colGuncellebilir.Width = 200;
            // 
            // colGuncelleyenKullanici
            // 
            this.colGuncelleyenKullanici.DataPropertyName = "PermissionGruopId";
            this.colGuncelleyenKullanici.HeaderText = "Güncelleyen Kullanici";
            this.colGuncelleyenKullanici.Name = "colGuncelleyenKullanici";
            this.colGuncelleyenKullanici.ReadOnly = true;
            this.colGuncelleyenKullanici.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colGuncelleyenKullanici.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colGuncelleyenKullanici.Width = 300;
            // 
            // colGuncellemeTarihi
            // 
            this.colGuncellemeTarihi.HeaderText = "Güncelleme Tarihi";
            this.colGuncellemeTarihi.Name = "colGuncellemeTarihi";
            this.colGuncellemeTarihi.ReadOnly = true;
            this.colGuncellemeTarihi.Width = 300;
            // 
            // frmUserPermision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1570, 702);
            this.Controls.Add(this.gvPermissinList);
            this.Name = "frmUserPermision";
            this.Load += new System.EventHandler(this.frmUserPermision_Load);
            this.Controls.SetChildIndex(this.pnlButton, 0);
            this.Controls.SetChildIndex(this.pnlDataPanel, 0);
            this.Controls.SetChildIndex(this.gvPermissinList, 0);
            this.pnlDataPanel.ResumeLayout(false);
            this.gbData.ResumeLayout(false);
            this.gbData.PerformLayout();
            this.pnlButton.ResumeLayout(false);
            this.gbButton.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sleuPermissinGupList.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPermissinList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kapaliDevreOdemeSistemiDataSet)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion
        private DevExpress.DataAccess.Sql.SqlDataSource sdsPermissionsList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPermissionSave;
        private System.Windows.Forms.Button btnAddPermissionsGroup;
        private System.Windows.Forms.TextBox txtPermissionsGoupName;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SearchLookUpEdit sleuPermissinGupList;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private System.Windows.Forms.BindingSource queryBindingSource;
        private DevExpress.DataAccess.Sql.SqlDataSource sdsPermissionsGroupList;
        private DevExpress.XtraGrid.Columns.GridColumn colGrupAdi;
        private System.Windows.Forms.DataGridView gvPermissinList;
        private KapaliDevreOdemeSistemiDataSet kapaliDevreOdemeSistemiDataSet;
        private System.Windows.Forms.BindingSource permissionsBindingSource;
        private KapaliDevreOdemeSistemiDataSetTableAdapters.PermissionsTableAdapter permissionsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn yetkiAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colYetkiGrubu;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colGoruntuluyebilir;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colGuncellebilir;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGuncelleyenKullanici;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGuncellemeTarihi;
    }
}