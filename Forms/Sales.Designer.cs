
namespace StockFollow_Up.Forms
{
    partial class Sales
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sales));
            this.Lk_Customer = new DevExpress.XtraEditors.LookUpEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.Lk_Product = new DevExpress.XtraEditors.LookUpEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.Nmr_SalesPrice = new System.Windows.Forms.NumericUpDown();
            this.Nmr_Amount = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Cmb_Tax = new System.Windows.Forms.ComboBox();
            this.Rch_Description = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Btn_RowAdd = new System.Windows.Forms.Button();
            this.Btn_Add = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalesPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TAX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Lk_Customer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lk_Product.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nmr_SalesPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nmr_Amount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Lk_Customer
            // 
            this.Lk_Customer.Location = new System.Drawing.Point(146, 6);
            this.Lk_Customer.Name = "Lk_Customer";
            this.Lk_Customer.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Lk_Customer.Properties.Appearance.Options.UseFont = true;
            this.Lk_Customer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Lk_Customer.Properties.NullText = "";
            this.Lk_Customer.Size = new System.Drawing.Size(165, 24);
            this.Lk_Customer.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "MÜŞTERİ";
            // 
            // Lk_Product
            // 
            this.Lk_Product.Location = new System.Drawing.Point(146, 47);
            this.Lk_Product.Name = "Lk_Product";
            this.Lk_Product.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Lk_Product.Properties.Appearance.Options.UseFont = true;
            this.Lk_Product.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Lk_Product.Properties.NullText = "";
            this.Lk_Product.Size = new System.Drawing.Size(165, 24);
            this.Lk_Product.TabIndex = 1;
            this.Lk_Product.EditValueChanged += new System.EventHandler(this.Lk_Product_EditValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "ÜRÜN";
            // 
            // Nmr_SalesPrice
            // 
            this.Nmr_SalesPrice.DecimalPlaces = 3;
            this.Nmr_SalesPrice.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Nmr_SalesPrice.Location = new System.Drawing.Point(146, 127);
            this.Nmr_SalesPrice.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            196608});
            this.Nmr_SalesPrice.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Nmr_SalesPrice.Name = "Nmr_SalesPrice";
            this.Nmr_SalesPrice.Size = new System.Drawing.Size(165, 20);
            this.Nmr_SalesPrice.TabIndex = 3;
            this.Nmr_SalesPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Nmr_SalesPrice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Nmr_Amount
            // 
            this.Nmr_Amount.DecimalPlaces = 3;
            this.Nmr_Amount.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Nmr_Amount.Location = new System.Drawing.Point(146, 86);
            this.Nmr_Amount.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            196608});
            this.Nmr_Amount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Nmr_Amount.Name = "Nmr_Amount";
            this.Nmr_Amount.Size = new System.Drawing.Size(165, 20);
            this.Nmr_Amount.TabIndex = 2;
            this.Nmr_Amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Nmr_Amount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(12, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "SATIŞ FİYATI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(12, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "MİKTAR";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(12, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "KDV TÜRÜ";
            // 
            // Cmb_Tax
            // 
            this.Cmb_Tax.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Tax.FormattingEnabled = true;
            this.Cmb_Tax.ItemHeight = 13;
            this.Cmb_Tax.Items.AddRange(new object[] {
            "0",
            "1",
            "8",
            "18"});
            this.Cmb_Tax.Location = new System.Drawing.Point(146, 166);
            this.Cmb_Tax.Name = "Cmb_Tax";
            this.Cmb_Tax.Size = new System.Drawing.Size(164, 21);
            this.Cmb_Tax.TabIndex = 4;
            // 
            // Rch_Description
            // 
            this.Rch_Description.Location = new System.Drawing.Point(146, 207);
            this.Rch_Description.Name = "Rch_Description";
            this.Rch_Description.Size = new System.Drawing.Size(165, 50);
            this.Rch_Description.TabIndex = 5;
            this.Rch_Description.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.label6.Location = new System.Drawing.Point(12, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "AÇIKLAMA";
            // 
            // Btn_RowAdd
            // 
            this.Btn_RowAdd.BackColor = System.Drawing.Color.Orange;
            this.Btn_RowAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_RowAdd.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.Btn_RowAdd.ForeColor = System.Drawing.Color.White;
            this.Btn_RowAdd.Location = new System.Drawing.Point(146, 263);
            this.Btn_RowAdd.Name = "Btn_RowAdd";
            this.Btn_RowAdd.Size = new System.Drawing.Size(131, 33);
            this.Btn_RowAdd.TabIndex = 6;
            this.Btn_RowAdd.Text = "SATIR EKLE";
            this.Btn_RowAdd.UseVisualStyleBackColor = false;
            this.Btn_RowAdd.Click += new System.EventHandler(this.Btn_RowAdd_Click);
            // 
            // Btn_Add
            // 
            this.Btn_Add.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Add.BackColor = System.Drawing.Color.Green;
            this.Btn_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Add.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.Btn_Add.ForeColor = System.Drawing.Color.White;
            this.Btn_Add.Location = new System.Drawing.Point(0, 396);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(1242, 37);
            this.Btn_Add.TabIndex = 7;
            this.Btn_Add.Text = "SATIŞ İŞLEMİ YAP";
            this.Btn_Add.UseVisualStyleBackColor = false;
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.ProductName,
            this.Amount,
            this.SalesPrice,
            this.TAX,
            this.TotalPrice,
            this.Description});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 430);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1242, 158);
            this.dataGridView1.TabIndex = 24;
            // 
            // ProductID
            // 
            this.ProductID.HeaderText = "ProductID";
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
            this.ProductID.Visible = false;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "URUN_ADI";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "MIKTAR";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // SalesPrice
            // 
            this.SalesPrice.HeaderText = "SATIS_FIYATI";
            this.SalesPrice.Name = "SalesPrice";
            this.SalesPrice.ReadOnly = true;
            // 
            // TAX
            // 
            this.TAX.HeaderText = "KDV";
            this.TAX.Name = "TAX";
            this.TAX.ReadOnly = true;
            // 
            // TotalPrice
            // 
            this.TotalPrice.HeaderText = "SATIS_FIYATI";
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.HeaderText = "ACIKLAMA";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 588);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Btn_Add);
            this.Controls.Add(this.Btn_RowAdd);
            this.Controls.Add(this.Rch_Description);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Cmb_Tax);
            this.Controls.Add(this.Nmr_SalesPrice);
            this.Controls.Add(this.Nmr_Amount);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Lk_Product);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lk_Customer);
            this.Controls.Add(this.label2);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Sales.IconOptions.SvgImage")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Sales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SATIŞ İŞLEMİ";
            this.Load += new System.EventHandler(this.Sales_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Sales_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Lk_Customer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lk_Product.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nmr_SalesPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nmr_Amount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LookUpEdit Lk_Customer;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.LookUpEdit Lk_Product;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown Nmr_SalesPrice;
        private System.Windows.Forms.NumericUpDown Nmr_Amount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Cmb_Tax;
        private System.Windows.Forms.RichTextBox Rch_Description;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Btn_RowAdd;
        private System.Windows.Forms.Button Btn_Add;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn TAX;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
    }
}