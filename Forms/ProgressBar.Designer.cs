
namespace StockFollow_Up.Forms
{
    partial class ProgressBar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgressBar));
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.Lbl_SendMailCount = new DevExpress.XtraEditors.LabelControl();
            this.Lbl_NotMail = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.Lst_Customer = new DevExpress.XtraEditors.ListBoxControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Lst_Customer)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 210);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(831, 51);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 11);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(188, 24);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Mail Gönderme Sayısı:";
            // 
            // Lbl_SendMailCount
            // 
            this.Lbl_SendMailCount.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Lbl_SendMailCount.Appearance.ForeColor = System.Drawing.Color.Red;
            this.Lbl_SendMailCount.Appearance.Options.UseFont = true;
            this.Lbl_SendMailCount.Appearance.Options.UseForeColor = true;
            this.Lbl_SendMailCount.Location = new System.Drawing.Point(206, 12);
            this.Lbl_SendMailCount.Name = "Lbl_SendMailCount";
            this.Lbl_SendMailCount.Size = new System.Drawing.Size(25, 24);
            this.Lbl_SendMailCount.TabIndex = 2;
            this.Lbl_SendMailCount.Text = "0/0";
            // 
            // Lbl_NotMail
            // 
            this.Lbl_NotMail.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Lbl_NotMail.Appearance.ForeColor = System.Drawing.Color.Red;
            this.Lbl_NotMail.Appearance.Options.UseFont = true;
            this.Lbl_NotMail.Appearance.Options.UseForeColor = true;
            this.Lbl_NotMail.Location = new System.Drawing.Point(260, 53);
            this.Lbl_NotMail.Name = "Lbl_NotMail";
            this.Lbl_NotMail.Size = new System.Drawing.Size(10, 24);
            this.Lbl_NotMail.TabIndex = 4;
            this.Lbl_NotMail.Text = "0";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(12, 53);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(238, 24);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Gönderilemeyen Mail Sayısı:";
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("groupControl1.CaptionImageOptions.SvgImage")));
            this.groupControl1.Controls.Add(this.Lst_Customer);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupControl1.Location = new System.Drawing.Point(485, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(346, 210);
            this.groupControl1.TabIndex = 6;
            this.groupControl1.Text = "Gönderilemeyen Müşteriler";
            // 
            // Lst_Customer
            // 
            this.Lst_Customer.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Lst_Customer.Appearance.Options.UseFont = true;
            this.Lst_Customer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lst_Customer.Location = new System.Drawing.Point(2, 33);
            this.Lst_Customer.Name = "Lst_Customer";
            this.Lst_Customer.Size = new System.Drawing.Size(342, 175);
            this.Lst_Customer.TabIndex = 6;
            // 
            // ProgressBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(831, 261);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.Lbl_NotMail);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.Lbl_SendMailCount);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.progressBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.ShowIcon = false;
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ProgressBar.IconOptions.SvgImage")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProgressBar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mail Gönderme İşlemi Yapılıyor...";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProgressBar_FormClosing);
            this.Load += new System.EventHandler(this.ProgressBar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Lst_Customer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl Lbl_SendMailCount;
        private DevExpress.XtraEditors.LabelControl Lbl_NotMail;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.ListBoxControl Lst_Customer;
    }
}