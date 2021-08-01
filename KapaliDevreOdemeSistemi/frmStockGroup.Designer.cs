namespace KapaliDevreOdemeSistemi
{
    partial class frmStockGroup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStockGroup));
            this.label1 = new System.Windows.Forms.Label();
            this.txtStokGroupName = new System.Windows.Forms.TextBox();
            this.pnlDataPanel.SuspendLayout();
            this.gbData.SuspendLayout();
            this.pnlButton.SuspendLayout();
            this.gbButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDataPanel
            // 
            this.pnlDataPanel.Size = new System.Drawing.Size(1450, 84);
            // 
            // gbData
            // 
            this.gbData.Controls.Add(this.label1);
            this.gbData.Controls.Add(this.txtStokGroupName);
            this.gbData.Size = new System.Drawing.Size(1648, 72);
            // 
            // pnlButton
            // 
            this.pnlButton.Size = new System.Drawing.Size(1450, 107);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Grup Adi : ";
            // 
            // txtStokGroupName
            // 
            this.txtStokGroupName.Location = new System.Drawing.Point(148, 25);
            this.txtStokGroupName.Name = "txtStokGroupName";
            this.txtStokGroupName.Size = new System.Drawing.Size(151, 23);
            this.txtStokGroupName.TabIndex = 3;
            // 
            // frmStockGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1450, 775);
            this.Name = "frmStockGroup";
            this.Text = "frmStockGroup";
            this.pnlDataPanel.ResumeLayout(false);
            this.gbData.ResumeLayout(false);
            this.gbData.PerformLayout();
            this.pnlButton.ResumeLayout(false);
            this.gbButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStokGroupName;
    }
}