
namespace StockFollow_Up.Forms
{
    partial class CompanyInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompanyInfo));
            this.Txt_Company = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_Email = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.Rch_Adress = new System.Windows.Forms.RichTextBox();
            this.Msk_Phone = new System.Windows.Forms.MaskedTextBox();
            this.Btn_Update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_Company
            // 
            this.Txt_Company.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Txt_Company.Location = new System.Drawing.Point(130, 21);
            this.Txt_Company.MaxLength = 50;
            this.Txt_Company.Name = "Txt_Company";
            this.Txt_Company.Size = new System.Drawing.Size(223, 23);
            this.Txt_Company.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "ŞİRKET ADI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "TELEFON";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(12, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "ADRES";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(12, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "E-MAİL";
            // 
            // Txt_Email
            // 
            this.Txt_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Txt_Email.Location = new System.Drawing.Point(130, 168);
            this.Txt_Email.MaxLength = 50;
            this.Txt_Email.Name = "Txt_Email";
            this.Txt_Email.Size = new System.Drawing.Size(223, 23);
            this.Txt_Email.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(12, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "ŞİRKET RESMİ";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Location = new System.Drawing.Point(130, 216);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(223, 81);
            this.pictureEdit1.TabIndex = 4;
            // 
            // Rch_Adress
            // 
            this.Rch_Adress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Rch_Adress.Location = new System.Drawing.Point(130, 104);
            this.Rch_Adress.MaxLength = 75;
            this.Rch_Adress.Name = "Rch_Adress";
            this.Rch_Adress.Size = new System.Drawing.Size(223, 49);
            this.Rch_Adress.TabIndex = 2;
            this.Rch_Adress.Text = "";
            // 
            // Msk_Phone
            // 
            this.Msk_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Msk_Phone.Location = new System.Drawing.Point(130, 60);
            this.Msk_Phone.Mask = "(999)000-0000";
            this.Msk_Phone.Name = "Msk_Phone";
            this.Msk_Phone.Size = new System.Drawing.Size(223, 23);
            this.Msk_Phone.TabIndex = 1;
            // 
            // Btn_Update
            // 
            this.Btn_Update.BackColor = System.Drawing.Color.Blue;
            this.Btn_Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Update.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Btn_Update.Font = new System.Drawing.Font("Tahoma", 15.25F);
            this.Btn_Update.ForeColor = System.Drawing.Color.White;
            this.Btn_Update.Location = new System.Drawing.Point(0, 310);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(358, 45);
            this.Btn_Update.TabIndex = 5;
            this.Btn_Update.Text = "GÜNCELLE";
            this.Btn_Update.UseVisualStyleBackColor = false;
            this.Btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // CompanyInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 355);
            this.Controls.Add(this.Btn_Update);
            this.Controls.Add(this.Rch_Adress);
            this.Controls.Add(this.Msk_Phone);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Txt_Email);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_Company);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("CompanyInfo.IconOptions.SvgImage")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "CompanyInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ŞİRKET BİLGİLERİ";
            this.Load += new System.EventHandler(this.CompanyInfo_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CompanyInfo_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_Company;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_Email;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private System.Windows.Forms.RichTextBox Rch_Adress;
        private System.Windows.Forms.MaskedTextBox Msk_Phone;
        private System.Windows.Forms.Button Btn_Update;
    }
}