namespace KapaliDevreOdemeSistemi
{
    partial class BaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            this.pnlDataPanel = new System.Windows.Forms.Panel();
            this.gbData = new System.Windows.Forms.GroupBox();
            this.pnlButton = new System.Windows.Forms.Panel();
            this.gbButton = new System.Windows.Forms.GroupBox();
            this.btnNewRecord = new System.Windows.Forms.Button();
            this.iconlar = new System.Windows.Forms.ImageList(this.components);
            this.btnFormClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gcMemberList = new DevExpress.XtraGrid.GridControl();
            this.gvMemberList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pnlDataPanel.SuspendLayout();
            this.pnlButton.SuspendLayout();
            this.gbButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcMemberList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMemberList)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDataPanel
            // 
            this.pnlDataPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlDataPanel.Controls.Add(this.gbData);
            this.pnlDataPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDataPanel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlDataPanel.Location = new System.Drawing.Point(0, 107);
            this.pnlDataPanel.Name = "pnlDataPanel";
            this.pnlDataPanel.Size = new System.Drawing.Size(1570, 202);
            this.pnlDataPanel.TabIndex = 11;
            // 
            // gbData
            // 
            this.gbData.Location = new System.Drawing.Point(3, 6);
            this.gbData.Name = "gbData";
            this.gbData.Size = new System.Drawing.Size(1648, 193);
            this.gbData.TabIndex = 8;
            this.gbData.TabStop = false;
            // 
            // pnlButton
            // 
            this.pnlButton.BackColor = System.Drawing.Color.White;
            this.pnlButton.Controls.Add(this.gbButton);
            this.pnlButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlButton.Location = new System.Drawing.Point(0, 0);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(1570, 107);
            this.pnlButton.TabIndex = 10;
            // 
            // gbButton
            // 
            this.gbButton.BackColor = System.Drawing.Color.White;
            this.gbButton.Controls.Add(this.btnNewRecord);
            this.gbButton.Controls.Add(this.btnFormClear);
            this.gbButton.Controls.Add(this.btnSave);
            this.gbButton.Controls.Add(this.btnReturn);
            this.gbButton.Controls.Add(this.btnUpdate);
            this.gbButton.Controls.Add(this.btnDelete);
            this.gbButton.Location = new System.Drawing.Point(0, 0);
            this.gbButton.Name = "gbButton";
            this.gbButton.Size = new System.Drawing.Size(933, 107);
            this.gbButton.TabIndex = 8;
            this.gbButton.TabStop = false;
            // 
            // btnNewRecord
            // 
            this.btnNewRecord.BackColor = System.Drawing.Color.White;
            this.btnNewRecord.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNewRecord.FlatAppearance.BorderSize = 0;
            this.btnNewRecord.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnNewRecord.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnNewRecord.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNewRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewRecord.ImageKey = "Ekle.png";
            this.btnNewRecord.ImageList = this.iconlar;
            this.btnNewRecord.Location = new System.Drawing.Point(0, 8);
            this.btnNewRecord.Name = "btnNewRecord";
            this.btnNewRecord.Size = new System.Drawing.Size(144, 81);
            this.btnNewRecord.TabIndex = 7;
            this.btnNewRecord.Text = "Yeni Kayıt";
            this.btnNewRecord.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNewRecord.UseVisualStyleBackColor = false;
            this.btnNewRecord.Click += new System.EventHandler(this.btnNewRecord_Click);
            // 
            // iconlar
            // 
            this.iconlar.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconlar.ImageStream")));
            this.iconlar.TransparentColor = System.Drawing.Color.Transparent;
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
            this.btnFormClear.BackColor = System.Drawing.Color.White;
            this.btnFormClear.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnFormClear.FlatAppearance.BorderSize = 0;
            this.btnFormClear.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnFormClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnFormClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFormClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormClear.ImageKey = "temizle.png";
            this.btnFormClear.ImageList = this.iconlar;
            this.btnFormClear.Location = new System.Drawing.Point(581, 8);
            this.btnFormClear.Name = "btnFormClear";
            this.btnFormClear.Size = new System.Drawing.Size(144, 81);
            this.btnFormClear.TabIndex = 1;
            this.btnFormClear.Text = "Formu Temizle";
            this.btnFormClear.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFormClear.UseVisualStyleBackColor = false;
            this.btnFormClear.Click += new System.EventHandler(this.btnFormClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ImageKey = "Kaydet.png";
            this.btnSave.ImageList = this.iconlar;
            this.btnSave.Location = new System.Drawing.Point(144, 8);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(144, 81);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Kaydet";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.White;
            this.btnReturn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnReturn.FlatAppearance.BorderSize = 0;
            this.btnReturn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnReturn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnReturn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.ImageKey = "Vazgeç.png";
            this.btnReturn.ImageList = this.iconlar;
            this.btnReturn.Location = new System.Drawing.Point(731, 11);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(144, 81);
            this.btnReturn.TabIndex = 2;
            this.btnReturn.Text = "Vazgeç";
            this.btnReturn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ImageKey = "Güncelle.png";
            this.btnUpdate.ImageList = this.iconlar;
            this.btnUpdate.Location = new System.Drawing.Point(288, 8);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(144, 81);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ImageKey = "Sil.png";
            this.btnDelete.ImageList = this.iconlar;
            this.btnDelete.Location = new System.Drawing.Point(432, 8);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(144, 81);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Sİl";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // gcMemberList
            // 
            this.gcMemberList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcMemberList.Location = new System.Drawing.Point(0, 309);
            this.gcMemberList.MainView = this.gvMemberList;
            this.gcMemberList.Name = "gcMemberList";
            this.gcMemberList.Size = new System.Drawing.Size(1570, 393);
            this.gcMemberList.TabIndex = 12;
            this.gcMemberList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMemberList});
            // 
            // gvMemberList
            // 
            this.gvMemberList.GridControl = this.gcMemberList;
            this.gvMemberList.Name = "gvMemberList";
            this.gvMemberList.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvMemberList.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvMemberList.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.False;
            this.gvMemberList.OptionsBehavior.Editable = false;
            this.gvMemberList.OptionsBehavior.ReadOnly = true;
            this.gvMemberList.OptionsCustomization.AllowColumnMoving = false;
            this.gvMemberList.OptionsCustomization.AllowColumnResizing = false;
            this.gvMemberList.OptionsEditForm.ShowOnDoubleClick = DevExpress.Utils.DefaultBoolean.False;
            this.gvMemberList.OptionsEditForm.ShowOnEnterKey = DevExpress.Utils.DefaultBoolean.False;
            this.gvMemberList.OptionsEditForm.ShowOnF2Key = DevExpress.Utils.DefaultBoolean.False;
            this.gvMemberList.OptionsEditForm.ShowUpdateCancelPanel = DevExpress.Utils.DefaultBoolean.False;
            this.gvMemberList.OptionsMenu.ShowAddNewSummaryItem = DevExpress.Utils.DefaultBoolean.False;
            this.gvMemberList.OptionsNavigation.UseTabKey = false;
            this.gvMemberList.OptionsSelection.MultiSelect = true;
            this.gvMemberList.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gvMemberList_RowCellClick);
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1570, 702);
            this.Controls.Add(this.gcMemberList);
            this.Controls.Add(this.pnlDataPanel);
            this.Controls.Add(this.pnlButton);
            this.Name = "BaseForm";
            this.Text = "BaseForm";
            this.pnlDataPanel.ResumeLayout(false);
            this.pnlButton.ResumeLayout(false);
            this.gbButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcMemberList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMemberList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Panel pnlDataPanel;
        public System.Windows.Forms.GroupBox gbData;
        public System.Windows.Forms.Panel pnlButton;
        public System.Windows.Forms.GroupBox gbButton;
        public System.Windows.Forms.ImageList iconlar;
        protected System.Windows.Forms.Button btnFormClear;
        protected System.Windows.Forms.Button btnNewRecord;
        protected System.Windows.Forms.Button btnSave;
        protected System.Windows.Forms.Button btnReturn;
        protected System.Windows.Forms.Button btnUpdate;
        protected System.Windows.Forms.Button btnDelete;
        public DevExpress.XtraGrid.GridControl gcMemberList;
        public DevExpress.XtraGrid.Views.Grid.GridView gvMemberList;
    }
}