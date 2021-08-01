namespace KapaliDevreOdemeSistemi
{
    partial class ucButtons
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucButtons));
            this.iconlar = new System.Windows.Forms.ImageList(this.components);
            this.gbMButton = new System.Windows.Forms.GroupBox();
            this.btnMNewRecord = new System.Windows.Forms.Button();
            this.btnMFormClear = new System.Windows.Forms.Button();
            this.btnMSave = new System.Windows.Forms.Button();
            this.btnMReturn = new System.Windows.Forms.Button();
            this.btnMUpdate = new System.Windows.Forms.Button();
            this.btnMDelete = new System.Windows.Forms.Button();
            this.gbMButton.SuspendLayout();
            this.SuspendLayout();
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
            // gbMButton
            // 
            this.gbMButton.BackColor = System.Drawing.Color.White;
            this.gbMButton.Controls.Add(this.btnMNewRecord);
            this.gbMButton.Controls.Add(this.btnMFormClear);
            this.gbMButton.Controls.Add(this.btnMSave);
            this.gbMButton.Controls.Add(this.btnMReturn);
            this.gbMButton.Controls.Add(this.btnMUpdate);
            this.gbMButton.Controls.Add(this.btnMDelete);
            this.gbMButton.Location = new System.Drawing.Point(3, 3);
            this.gbMButton.Name = "gbMButton";
            this.gbMButton.Size = new System.Drawing.Size(860, 89);
            this.gbMButton.TabIndex = 9;
            this.gbMButton.TabStop = false;
            // 
            // btnMNewRecord
            // 
            this.btnMNewRecord.BackColor = System.Drawing.Color.White;
            this.btnMNewRecord.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMNewRecord.FlatAppearance.BorderSize = 0;
            this.btnMNewRecord.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMNewRecord.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnMNewRecord.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMNewRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMNewRecord.ImageKey = "Ekle.png";
            this.btnMNewRecord.ImageList = this.iconlar;
            this.btnMNewRecord.Location = new System.Drawing.Point(0, 8);
            this.btnMNewRecord.Name = "btnMNewRecord";
            this.btnMNewRecord.Size = new System.Drawing.Size(144, 81);
            this.btnMNewRecord.TabIndex = 7;
            this.btnMNewRecord.Text = "Yeni Kayıt";
            this.btnMNewRecord.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMNewRecord.UseVisualStyleBackColor = false;
            // 
            // btnMFormClear
            // 
            this.btnMFormClear.BackColor = System.Drawing.Color.White;
            this.btnMFormClear.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMFormClear.FlatAppearance.BorderSize = 0;
            this.btnMFormClear.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMFormClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnMFormClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMFormClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMFormClear.ImageKey = "temizle.png";
            this.btnMFormClear.ImageList = this.iconlar;
            this.btnMFormClear.Location = new System.Drawing.Point(581, 8);
            this.btnMFormClear.Name = "btnMFormClear";
            this.btnMFormClear.Size = new System.Drawing.Size(144, 81);
            this.btnMFormClear.TabIndex = 1;
            this.btnMFormClear.Text = "Formu Temizle";
            this.btnMFormClear.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMFormClear.UseVisualStyleBackColor = false;
            // 
            // btnMSave
            // 
            this.btnMSave.BackColor = System.Drawing.Color.White;
            this.btnMSave.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMSave.FlatAppearance.BorderSize = 0;
            this.btnMSave.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnMSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMSave.ImageKey = "Kaydet.png";
            this.btnMSave.ImageList = this.iconlar;
            this.btnMSave.Location = new System.Drawing.Point(144, 8);
            this.btnMSave.Name = "btnMSave";
            this.btnMSave.Size = new System.Drawing.Size(144, 81);
            this.btnMSave.TabIndex = 6;
            this.btnMSave.Text = "Kaydet";
            this.btnMSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMSave.UseVisualStyleBackColor = false;
            // 
            // btnMReturn
            // 
            this.btnMReturn.BackColor = System.Drawing.Color.White;
            this.btnMReturn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMReturn.FlatAppearance.BorderSize = 0;
            this.btnMReturn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMReturn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnMReturn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMReturn.ImageKey = "Vazgeç.png";
            this.btnMReturn.ImageList = this.iconlar;
            this.btnMReturn.Location = new System.Drawing.Point(731, 11);
            this.btnMReturn.Name = "btnMReturn";
            this.btnMReturn.Size = new System.Drawing.Size(144, 81);
            this.btnMReturn.TabIndex = 2;
            this.btnMReturn.Text = "Vazgeç";
            this.btnMReturn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMReturn.UseVisualStyleBackColor = false;
            // 
            // btnMUpdate
            // 
            this.btnMUpdate.BackColor = System.Drawing.Color.White;
            this.btnMUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMUpdate.FlatAppearance.BorderSize = 0;
            this.btnMUpdate.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnMUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMUpdate.ImageKey = "Güncelle.png";
            this.btnMUpdate.ImageList = this.iconlar;
            this.btnMUpdate.Location = new System.Drawing.Point(288, 8);
            this.btnMUpdate.Name = "btnMUpdate";
            this.btnMUpdate.Size = new System.Drawing.Size(144, 81);
            this.btnMUpdate.TabIndex = 5;
            this.btnMUpdate.Text = "Güncelle";
            this.btnMUpdate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMUpdate.UseVisualStyleBackColor = false;
            // 
            // btnMDelete
            // 
            this.btnMDelete.BackColor = System.Drawing.Color.White;
            this.btnMDelete.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMDelete.FlatAppearance.BorderSize = 0;
            this.btnMDelete.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnMDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMDelete.ImageKey = "Sil.png";
            this.btnMDelete.ImageList = this.iconlar;
            this.btnMDelete.Location = new System.Drawing.Point(432, 8);
            this.btnMDelete.Name = "btnMDelete";
            this.btnMDelete.Size = new System.Drawing.Size(144, 81);
            this.btnMDelete.TabIndex = 4;
            this.btnMDelete.Text = "Sİl";
            this.btnMDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMDelete.UseVisualStyleBackColor = false;
            // 
            // ucButtons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.gbMButton);
            this.Name = "ucButtons";
            this.Size = new System.Drawing.Size(955, 100);
            this.gbMButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList iconlar;
        private System.Windows.Forms.GroupBox gbMButton;
        private System.Windows.Forms.Button btnMNewRecord;
        private System.Windows.Forms.Button btnMFormClear;
        private System.Windows.Forms.Button btnMSave;
        private System.Windows.Forms.Button btnMReturn;
        private System.Windows.Forms.Button btnMUpdate;
        private System.Windows.Forms.Button btnMDelete;
    }
}
