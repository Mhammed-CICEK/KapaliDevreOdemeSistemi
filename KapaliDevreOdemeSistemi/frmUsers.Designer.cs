
namespace KapaliDevreOdemeSistemi
{
    partial class frmUsers
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
            DevExpress.DataAccess.Sql.SelectQuery selectQuery1 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column1 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression1 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table1 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column2 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression2 = new DevExpress.DataAccess.Sql.ColumnExpression();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsers));
            this.btnMUploadImage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pbUImage = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUsernickName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mtxtUserPhone = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUsersExplataion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtUsersPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbUsersSatae = new System.Windows.Forms.ComboBox();
            this.txtUTitle = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtUsersrePassword = new System.Windows.Forms.TextBox();
            this.txtUserEmail = new System.Windows.Forms.TextBox();
            this.txtUserSurname = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.sleuYetkiGoup = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.permisionGroupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sdsUsersList = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ofdMImageLoad = new System.Windows.Forms.OpenFileDialog();
            this.pnlDataPanel.SuspendLayout();
            this.gbData.SuspendLayout();
            this.pnlButton.SuspendLayout();
            this.gbButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sleuYetkiGoup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.permisionGroupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDataPanel
            // 
            this.pnlDataPanel.Size = new System.Drawing.Size(1716, 202);
            // 
            // gbData
            // 
            this.gbData.Controls.Add(this.sleuYetkiGoup);
            this.gbData.Controls.Add(this.btnMUploadImage);
            this.gbData.Controls.Add(this.label1);
            this.gbData.Controls.Add(this.pbUImage);
            this.gbData.Controls.Add(this.label7);
            this.gbData.Controls.Add(this.cmbUsersSatae);
            this.gbData.Controls.Add(this.txtUserSurname);
            this.gbData.Controls.Add(this.txtUserName);
            this.gbData.Controls.Add(this.txtUserEmail);
            this.gbData.Controls.Add(this.txtUTitle);
            this.gbData.Controls.Add(this.txtUsernickName);
            this.gbData.Controls.Add(this.label4);
            this.gbData.Controls.Add(this.label9);
            this.gbData.Controls.Add(this.label5);
            this.gbData.Controls.Add(this.label2);
            this.gbData.Controls.Add(this.label10);
            this.gbData.Controls.Add(this.label3);
            this.gbData.Controls.Add(this.mtxtUserPhone);
            this.gbData.Controls.Add(this.label8);
            this.gbData.Controls.Add(this.txtUsersExplataion);
            this.gbData.Controls.Add(this.label6);
            this.gbData.Controls.Add(this.label14);
            this.gbData.Controls.Add(this.txtUsersrePassword);
            this.gbData.Controls.Add(this.txtUsersPassword);
            // 
            // pnlButton
            // 
            this.pnlButton.Size = new System.Drawing.Size(1716, 107);
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
            this.btnMUploadImage.Location = new System.Drawing.Point(117, 153);
            this.btnMUploadImage.Name = "btnMUploadImage";
            this.btnMUploadImage.Size = new System.Drawing.Size(75, 23);
            this.btnMUploadImage.TabIndex = 43;
            this.btnMUploadImage.Text = "Resim Yükle";
            this.btnMUploadImage.UseVisualStyleBackColor = true;
            this.btnMUploadImage.Click += new System.EventHandler(this.btnMUploadImage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(587, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 27;
            this.label1.Text = "Kullanici Adi : ";
            // 
            // pbUImage
            // 
            this.pbUImage.Image = global::KapaliDevreOdemeSistemi.Properties.Resources.Student;
            this.pbUImage.Location = new System.Drawing.Point(92, 19);
            this.pbUImage.Name = "pbUImage";
            this.pbUImage.Size = new System.Drawing.Size(128, 128);
            this.pbUImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUImage.TabIndex = 21;
            this.pbUImage.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(288, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 16);
            this.label7.TabIndex = 30;
            this.label7.Text = "Unvan : ";
            // 
            // txtUsernickName
            // 
            this.txtUsernickName.Location = new System.Drawing.Point(721, 63);
            this.txtUsernickName.Name = "txtUsernickName";
            this.txtUsernickName.Size = new System.Drawing.Size(151, 23);
            this.txtUsernickName.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(289, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 16);
            this.label9.TabIndex = 36;
            this.label9.Text = "E-Mail : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(289, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 35;
            this.label5.Text = "İsim : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(587, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 34;
            this.label2.Text = "Şifre : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(587, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 16);
            this.label3.TabIndex = 31;
            this.label3.Text = "Şifreyi Tekrar Et : ";
            // 
            // mtxtUserPhone
            // 
            this.mtxtUserPhone.Location = new System.Drawing.Point(382, 125);
            this.mtxtUserPhone.Mask = "(999) 000-00-00";
            this.mtxtUserPhone.Name = "mtxtUserPhone";
            this.mtxtUserPhone.Size = new System.Drawing.Size(151, 23);
            this.mtxtUserPhone.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(288, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 16);
            this.label8.TabIndex = 25;
            this.label8.Text = "Telefon : ";
            // 
            // txtUsersExplataion
            // 
            this.txtUsersExplataion.Location = new System.Drawing.Point(1044, 27);
            this.txtUsersExplataion.Multiline = true;
            this.txtUsersExplataion.Name = "txtUsersExplataion";
            this.txtUsersExplataion.Size = new System.Drawing.Size(243, 85);
            this.txtUsersExplataion.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(288, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "Soyisim : ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(960, 30);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 16);
            this.label14.TabIndex = 23;
            this.label14.Text = "Açıklama : ";
            // 
            // txtUsersPassword
            // 
            this.txtUsersPassword.Location = new System.Drawing.Point(721, 93);
            this.txtUsersPassword.Name = "txtUsersPassword";
            this.txtUsersPassword.PasswordChar = '*';
            this.txtUsersPassword.Size = new System.Drawing.Size(151, 23);
            this.txtUsersPassword.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(587, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 36;
            this.label4.Text = "Durumu : ";
            // 
            // cmbUsersSatae
            // 
            this.cmbUsersSatae.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsersSatae.FormattingEnabled = true;
            this.cmbUsersSatae.Items.AddRange(new object[] {
            "AKTİF",
            "PASİF"});
            this.cmbUsersSatae.Location = new System.Drawing.Point(721, 27);
            this.cmbUsersSatae.Name = "cmbUsersSatae";
            this.cmbUsersSatae.Size = new System.Drawing.Size(151, 24);
            this.cmbUsersSatae.TabIndex = 6;
            // 
            // txtUTitle
            // 
            this.txtUTitle.Location = new System.Drawing.Point(382, 93);
            this.txtUTitle.Name = "txtUTitle";
            this.txtUTitle.Size = new System.Drawing.Size(151, 23);
            this.txtUTitle.TabIndex = 3;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(382, 27);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(151, 23);
            this.txtUserName.TabIndex = 1;
            // 
            // txtUsersrePassword
            // 
            this.txtUsersrePassword.Location = new System.Drawing.Point(721, 127);
            this.txtUsersrePassword.Name = "txtUsersrePassword";
            this.txtUsersrePassword.PasswordChar = '*';
            this.txtUsersrePassword.Size = new System.Drawing.Size(151, 23);
            this.txtUsersrePassword.TabIndex = 9;
            // 
            // txtUserEmail
            // 
            this.txtUserEmail.Location = new System.Drawing.Point(382, 157);
            this.txtUserEmail.Name = "txtUserEmail";
            this.txtUserEmail.Size = new System.Drawing.Size(151, 23);
            this.txtUserEmail.TabIndex = 5;
            // 
            // txtUserSurname
            // 
            this.txtUserSurname.Location = new System.Drawing.Point(382, 63);
            this.txtUserSurname.Name = "txtUserSurname";
            this.txtUserSurname.Size = new System.Drawing.Size(151, 23);
            this.txtUserSurname.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(587, 164);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 16);
            this.label10.TabIndex = 31;
            this.label10.Text = "Yetki Grubu : ";
            // 
            // sleuYetkiGoup
            // 
            this.sleuYetkiGoup.Location = new System.Drawing.Point(721, 164);
            this.sleuYetkiGoup.Name = "sleuYetkiGoup";
            this.sleuYetkiGoup.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sleuYetkiGoup.Properties.DataSource = this.permisionGroupBindingSource;
            this.sleuYetkiGoup.Properties.DisplayMember = "GrupAdi";
            this.sleuYetkiGoup.Properties.PopupView = this.searchLookUpEdit1View;
            this.sleuYetkiGoup.Properties.ValueMember = "PermissionGruopId";
            this.sleuYetkiGoup.Size = new System.Drawing.Size(151, 20);
            this.sleuYetkiGoup.TabIndex = 44;
            // 
            // permisionGroupBindingSource
            // 
            this.permisionGroupBindingSource.DataMember = "PermisionGroup";
            this.permisionGroupBindingSource.DataSource = this.sdsUsersList;
            // 
            // sdsUsersList
            // 
            this.sdsUsersList.ConnectionName = "sqlBaglanti";
            this.sdsUsersList.Name = "sdsUsersList";
            columnExpression1.ColumnName = "GrupAdi";
            table1.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"203\" />";
            table1.Name = "PermisionGroup";
            columnExpression1.Table = table1;
            column1.Expression = columnExpression1;
            columnExpression2.ColumnName = "PermissionGruopId";
            columnExpression2.Table = table1;
            column2.Expression = columnExpression2;
            selectQuery1.Columns.Add(column1);
            selectQuery1.Columns.Add(column2);
            selectQuery1.Name = "PermisionGroup";
            selectQuery1.Tables.Add(table1);
            this.sdsUsersList.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1});
            this.sdsUsersList.ResultSchemaSerializable = resources.GetString("sdsUsersList.ResultSchemaSerializable");
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // ofdMImageLoad
            // 
            this.ofdMImageLoad.FileName = "openFileDialog1";
            // 
            // frmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1716, 844);
            this.Name = "frmUsers";
            this.Text = "frmUsers";
            this.Load += new System.EventHandler(this.frmUsers_Load);
            this.pnlDataPanel.ResumeLayout(false);
            this.gbData.ResumeLayout(false);
            this.gbData.PerformLayout();
            this.pnlButton.ResumeLayout(false);
            this.gbButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbUImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sleuYetkiGoup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.permisionGroupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMUploadImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbUImage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbUsersSatae;
        private System.Windows.Forms.TextBox txtUserSurname;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtUserEmail;
        private System.Windows.Forms.TextBox txtUTitle;
        private System.Windows.Forms.TextBox txtUsernickName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtxtUserPhone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUsersExplataion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtUsersrePassword;
        private System.Windows.Forms.TextBox txtUsersPassword;
        private DevExpress.XtraEditors.SearchLookUpEdit sleuYetkiGoup;
        private System.Windows.Forms.BindingSource permisionGroupBindingSource;
        private DevExpress.DataAccess.Sql.SqlDataSource sdsUsersList;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.OpenFileDialog ofdMImageLoad;
    }
}