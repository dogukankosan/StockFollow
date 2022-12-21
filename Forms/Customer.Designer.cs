
namespace StockFollow_Up.Forms
{
    partial class Customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.excelAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pdfAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resimAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topluHerkeseMutabakatGönderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.Btn_Clear = new DevExpress.XtraEditors.SimpleButton();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Lk_Town = new DevExpress.XtraEditors.LookUpEdit();
            this.Lk_City = new DevExpress.XtraEditors.LookUpEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.Lbl_Balance = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Btn_Add = new System.Windows.Forms.Button();
            this.Btn_Update = new System.Windows.Forms.Button();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_EMail = new System.Windows.Forms.TextBox();
            this.Rch_Adress = new System.Windows.Forms.RichTextBox();
            this.Msk_Phone = new System.Windows.Forms.MaskedTextBox();
            this.Txt_CustomerName = new System.Windows.Forms.TextBox();
            this.Txt_TC_VKN = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Lk_Town.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lk_City.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.ContextMenuStrip = this.contextMenuStrip1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.gridControl1.Location = new System.Drawing.Point(311, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(689, 570);
            this.gridControl1.TabIndex = 10;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.excelAlToolStripMenuItem,
            this.pdfAlToolStripMenuItem,
            this.resimAlToolStripMenuItem,
            this.topluHerkeseMutabakatGönderToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(268, 92);
            // 
            // excelAlToolStripMenuItem
            // 
            this.excelAlToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("excelAlToolStripMenuItem.Image")));
            this.excelAlToolStripMenuItem.Name = "excelAlToolStripMenuItem";
            this.excelAlToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.excelAlToolStripMenuItem.Text = "Excel Al";
            this.excelAlToolStripMenuItem.Click += new System.EventHandler(this.excelAlToolStripMenuItem_Click);
            // 
            // pdfAlToolStripMenuItem
            // 
            this.pdfAlToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pdfAlToolStripMenuItem.Image")));
            this.pdfAlToolStripMenuItem.Name = "pdfAlToolStripMenuItem";
            this.pdfAlToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.pdfAlToolStripMenuItem.Text = "Pdf Al";
            this.pdfAlToolStripMenuItem.Click += new System.EventHandler(this.pdfAlToolStripMenuItem_Click);
            // 
            // resimAlToolStripMenuItem
            // 
            this.resimAlToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("resimAlToolStripMenuItem.Image")));
            this.resimAlToolStripMenuItem.Name = "resimAlToolStripMenuItem";
            this.resimAlToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.resimAlToolStripMenuItem.Text = "Resim Al";
            this.resimAlToolStripMenuItem.Click += new System.EventHandler(this.resimAlToolStripMenuItem_Click);
            // 
            // topluHerkeseMutabakatGönderToolStripMenuItem
            // 
            this.topluHerkeseMutabakatGönderToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("topluHerkeseMutabakatGönderToolStripMenuItem.Image")));
            this.topluHerkeseMutabakatGönderToolStripMenuItem.Name = "topluHerkeseMutabakatGönderToolStripMenuItem";
            this.topluHerkeseMutabakatGönderToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.topluHerkeseMutabakatGönderToolStripMenuItem.Text = "Listedeki Herkese Mutabakat Gönder";
            this.topluHerkeseMutabakatGönderToolStripMenuItem.Click += new System.EventHandler(this.topluHerkeseMutabakatGönderToolStripMenuItem_Click);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Appearance.SelectedRow.BackColor = System.Drawing.Color.IndianRed;
            this.gridView1.Appearance.SelectedRow.BackColor2 = System.Drawing.Color.IndianRed;
            this.gridView1.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImageOptions.Image")));
            this.groupControl1.Controls.Add(this.Btn_Clear);
            this.groupControl1.Controls.Add(this.label10);
            this.groupControl1.Controls.Add(this.label9);
            this.groupControl1.Controls.Add(this.Lk_Town);
            this.groupControl1.Controls.Add(this.Lk_City);
            this.groupControl1.Controls.Add(this.label8);
            this.groupControl1.Controls.Add(this.pictureEdit1);
            this.groupControl1.Controls.Add(this.Lbl_Balance);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.Btn_Add);
            this.groupControl1.Controls.Add(this.Btn_Update);
            this.groupControl1.Controls.Add(this.Btn_Delete);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.Txt_EMail);
            this.groupControl1.Controls.Add(this.Rch_Adress);
            this.groupControl1.Controls.Add(this.Msk_Phone);
            this.groupControl1.Controls.Add(this.Txt_CustomerName);
            this.groupControl1.Controls.Add(this.Txt_TC_VKN);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(311, 570);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "MÜŞTERİ BİLGİLERİ";
            // 
            // Btn_Clear
            // 
            this.Btn_Clear.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Clear.Appearance.Options.UseBackColor = true;
            this.Btn_Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Clear.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Clear.ImageOptions.Image")));
            this.Btn_Clear.Location = new System.Drawing.Point(284, 2);
            this.Btn_Clear.Name = "Btn_Clear";
            this.Btn_Clear.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.Btn_Clear.Size = new System.Drawing.Size(20, 23);
            this.Btn_Clear.TabIndex = 11;
            this.Btn_Clear.Click += new System.EventHandler(this.Btn_Clear_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(5, 199);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 17);
            this.label10.TabIndex = 14;
            this.label10.Text = "İLÇE";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(5, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 17);
            this.label9.TabIndex = 13;
            this.label9.Text = "İL";
            // 
            // Lk_Town
            // 
            this.Lk_Town.Location = new System.Drawing.Point(139, 196);
            this.Lk_Town.Name = "Lk_Town";
            this.Lk_Town.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Lk_Town.Properties.Appearance.Options.UseFont = true;
            this.Lk_Town.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Lk_Town.Properties.NullText = "";
            this.Lk_Town.Size = new System.Drawing.Size(165, 24);
            this.Lk_Town.TabIndex = 5;
            // 
            // Lk_City
            // 
            this.Lk_City.Location = new System.Drawing.Point(139, 163);
            this.Lk_City.Name = "Lk_City";
            this.Lk_City.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Lk_City.Properties.Appearance.Options.UseFont = true;
            this.Lk_City.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Lk_City.Properties.NullText = "";
            this.Lk_City.Size = new System.Drawing.Size(165, 24);
            this.Lk_City.TabIndex = 4;
            this.Lk_City.EditValueChanged += new System.EventHandler(this.Lk_City_EditValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.label8.Location = new System.Drawing.Point(5, 285);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "MÜŞTERİ RESİM";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Location = new System.Drawing.Point(139, 285);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(165, 76);
            this.pictureEdit1.TabIndex = 10;
            // 
            // Lbl_Balance
            // 
            this.Lbl_Balance.AutoSize = true;
            this.Lbl_Balance.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.Lbl_Balance.Location = new System.Drawing.Point(100, 368);
            this.Lbl_Balance.Name = "Lbl_Balance";
            this.Lbl_Balance.Size = new System.Drawing.Size(16, 17);
            this.Lbl_Balance.TabIndex = 9;
            this.Lbl_Balance.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(5, 368);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "BAKİYE (₺):";
            // 
            // Btn_Add
            // 
            this.Btn_Add.BackColor = System.Drawing.Color.Green;
            this.Btn_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Add.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Btn_Add.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.Btn_Add.ForeColor = System.Drawing.Color.White;
            this.Btn_Add.Location = new System.Drawing.Point(2, 487);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(307, 27);
            this.Btn_Add.TabIndex = 7;
            this.Btn_Add.Text = "EKLE (F2)";
            this.Btn_Add.UseVisualStyleBackColor = false;
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // Btn_Update
            // 
            this.Btn_Update.BackColor = System.Drawing.Color.Orange;
            this.Btn_Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Update.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Btn_Update.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.Btn_Update.ForeColor = System.Drawing.Color.White;
            this.Btn_Update.Location = new System.Drawing.Point(2, 514);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(307, 27);
            this.Btn_Update.TabIndex = 8;
            this.Btn_Update.Text = "GÜNCELLE (F5)";
            this.Btn_Update.UseVisualStyleBackColor = false;
            this.Btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.BackColor = System.Drawing.Color.Red;
            this.Btn_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Delete.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Btn_Delete.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.Btn_Delete.ForeColor = System.Drawing.Color.White;
            this.Btn_Delete.Location = new System.Drawing.Point(2, 541);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(307, 27);
            this.Btn_Delete.TabIndex = 9;
            this.Btn_Delete.Text = "SİL (F3)";
            this.Btn_Delete.UseVisualStyleBackColor = false;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.label5.Location = new System.Drawing.Point(5, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "ADRES";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(5, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "E-MAİL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(5, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "TELEFON";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(5, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "MÜŞTERİ ÜNVAN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(5, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "TC-VKN";
            // 
            // Txt_EMail
            // 
            this.Txt_EMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Txt_EMail.Location = new System.Drawing.Point(139, 129);
            this.Txt_EMail.MaxLength = 50;
            this.Txt_EMail.Name = "Txt_EMail";
            this.Txt_EMail.Size = new System.Drawing.Size(165, 23);
            this.Txt_EMail.TabIndex = 3;
            // 
            // Rch_Adress
            // 
            this.Rch_Adress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Rch_Adress.Location = new System.Drawing.Point(139, 230);
            this.Rch_Adress.MaxLength = 75;
            this.Rch_Adress.Name = "Rch_Adress";
            this.Rch_Adress.Size = new System.Drawing.Size(165, 49);
            this.Rch_Adress.TabIndex = 6;
            this.Rch_Adress.Text = "";
            // 
            // Msk_Phone
            // 
            this.Msk_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Msk_Phone.Location = new System.Drawing.Point(139, 95);
            this.Msk_Phone.Mask = "(999)000-0000";
            this.Msk_Phone.Name = "Msk_Phone";
            this.Msk_Phone.Size = new System.Drawing.Size(165, 23);
            this.Msk_Phone.TabIndex = 2;
            // 
            // Txt_CustomerName
            // 
            this.Txt_CustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Txt_CustomerName.Location = new System.Drawing.Point(139, 63);
            this.Txt_CustomerName.MaxLength = 50;
            this.Txt_CustomerName.Name = "Txt_CustomerName";
            this.Txt_CustomerName.Size = new System.Drawing.Size(165, 23);
            this.Txt_CustomerName.TabIndex = 1;
            // 
            // Txt_TC_VKN
            // 
            this.Txt_TC_VKN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Txt_TC_VKN.Location = new System.Drawing.Point(139, 31);
            this.Txt_TC_VKN.MaxLength = 11;
            this.Txt_TC_VKN.Name = "Txt_TC_VKN";
            this.Txt_TC_VKN.Size = new System.Drawing.Size(165, 23);
            this.Txt_TC_VKN.TabIndex = 0;
            this.Txt_TC_VKN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_TC_VKN_KeyPress);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1000, 570);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("Customer.IconOptions.Image")));
            this.KeyPreview = true;
            this.Name = "Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MÜŞTERİ-EKLE-SİL-GÜNCELLE";
            this.Load += new System.EventHandler(this.Customer_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Customer_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Lk_Town.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lk_City.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_EMail;
        private System.Windows.Forms.RichTextBox Rch_Adress;
        private System.Windows.Forms.MaskedTextBox Msk_Phone;
        private System.Windows.Forms.TextBox Txt_CustomerName;
        private System.Windows.Forms.TextBox Txt_TC_VKN;
        private System.Windows.Forms.Label Lbl_Balance;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.LookUpEdit Lk_Town;
        private DevExpress.XtraEditors.LookUpEdit Lk_City;
        private DevExpress.XtraEditors.SimpleButton Btn_Clear;
        private System.Windows.Forms.Button Btn_Add;
        private System.Windows.Forms.Button Btn_Update;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem excelAlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pdfAlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resimAlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topluHerkeseMutabakatGönderToolStripMenuItem;
    }
}