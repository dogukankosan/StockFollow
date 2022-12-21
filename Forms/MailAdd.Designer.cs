
namespace StockFollow_Up.Forms
{
    partial class MailAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MailAdd));
            this.Txt_Host = new System.Windows.Forms.TextBox();
            this.Txt_Password = new System.Windows.Forms.TextBox();
            this.Btn_Update = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.Txt_Mail = new System.Windows.Forms.TextBox();
            this.Btn_Eye = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_UnEye = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_Host
            // 
            this.Txt_Host.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.Txt_Host.Location = new System.Drawing.Point(118, 94);
            this.Txt_Host.MaxLength = 30;
            this.Txt_Host.Name = "Txt_Host";
            this.Txt_Host.Size = new System.Drawing.Size(191, 24);
            this.Txt_Host.TabIndex = 2;
            // 
            // Txt_Password
            // 
            this.Txt_Password.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.Txt_Password.Location = new System.Drawing.Point(118, 51);
            this.Txt_Password.MaxLength = 60;
            this.Txt_Password.Name = "Txt_Password";
            this.Txt_Password.PasswordChar = '*';
            this.Txt_Password.Size = new System.Drawing.Size(191, 24);
            this.Txt_Password.TabIndex = 1;
            // 
            // Btn_Update
            // 
            this.Btn_Update.BackColor = System.Drawing.Color.Blue;
            this.Btn_Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Update.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Btn_Update.Font = new System.Drawing.Font("Tahoma", 15.25F);
            this.Btn_Update.ForeColor = System.Drawing.Color.White;
            this.Btn_Update.Location = new System.Drawing.Point(0, 167);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(328, 43);
            this.Btn_Update.TabIndex = 4;
            this.Btn_Update.Text = "GÜNCELLE";
            this.Btn_Update.UseVisualStyleBackColor = false;
            this.Btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(12, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "ŞİFRESİ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(12, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "PORT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(12, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "HOST";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "MAİL ADRESİ";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.numericUpDown1.Location = new System.Drawing.Point(118, 134);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(191, 24);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Txt_Mail
            // 
            this.Txt_Mail.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.Txt_Mail.Location = new System.Drawing.Point(118, 10);
            this.Txt_Mail.MaxLength = 60;
            this.Txt_Mail.Name = "Txt_Mail";
            this.Txt_Mail.Size = new System.Drawing.Size(191, 24);
            this.Txt_Mail.TabIndex = 0;
            // 
            // Btn_Eye
            // 
            this.Btn_Eye.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Eye.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Eye.ImageOptions.Image")));
            this.Btn_Eye.Location = new System.Drawing.Point(73, 51);
            this.Btn_Eye.Name = "Btn_Eye";
            this.Btn_Eye.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.Btn_Eye.Size = new System.Drawing.Size(37, 26);
            this.Btn_Eye.TabIndex = 15;
            this.Btn_Eye.Click += new System.EventHandler(this.Btn_Eye_Click);
            // 
            // Btn_UnEye
            // 
            this.Btn_UnEye.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_UnEye.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_UnEye.ImageOptions.Image")));
            this.Btn_UnEye.Location = new System.Drawing.Point(75, 51);
            this.Btn_UnEye.Name = "Btn_UnEye";
            this.Btn_UnEye.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.Btn_UnEye.Size = new System.Drawing.Size(37, 26);
            this.Btn_UnEye.TabIndex = 16;
            this.Btn_UnEye.Click += new System.EventHandler(this.Btn_UnEye_Click);
            // 
            // MailAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 210);
            this.Controls.Add(this.Btn_UnEye);
            this.Controls.Add(this.Btn_Eye);
            this.Controls.Add(this.Txt_Host);
            this.Controls.Add(this.Txt_Password);
            this.Controls.Add(this.Btn_Update);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.Txt_Mail);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("MailAdd.IconOptions.LargeImage")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "MailAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MAİL GÜNCELLE";
            this.Load += new System.EventHandler(this.MailAdd_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MailAdd_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_Host;
        private System.Windows.Forms.TextBox Txt_Password;
        private System.Windows.Forms.Button Btn_Update;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox Txt_Mail;
        private DevExpress.XtraEditors.SimpleButton Btn_Eye;
        private DevExpress.XtraEditors.SimpleButton Btn_UnEye;
    }
}