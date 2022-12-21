using DevExpress.XtraEditors;
using StockFollow_Up.Classes;
using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace StockFollow_Up.Forms
{
    public partial class Sales : DevExpress.XtraEditors.XtraForm
    {
        public Sales()
        {
            InitializeComponent();
        }
        private void Clear()
        {
            Nmr_Amount.Value = 1;
            Nmr_SalesPrice.Value = 1;
            Lk_Product.EditValue = null;
            Cmb_Tax.Text = null;
            Rch_Description.Text = null;
            Lk_Product.Focus();
        }
        private void Sales_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }
        private void ComboList()
        {
            Lk_Customer.Properties.DataSource = SQLClientConnect.GenericList("select ID,TC_VKN,CustomerName as 'MUSTERI',Phone as 'TELEFON',E_Mail as 'E_MAIL',Balance as 'BAKIYE' from Customer", SQLClientConnect.Db);
            Lk_Product.Properties.DataSource = SQLClientConnect.GenericList("select Product.ID,BarcodeNo as 'BARKOD_NO',CategoryName as 'KATEGORI_ADI',ProductName as 'URUN_ADI',Amount AS 'MIKTAR',SalesPrice as 'SATIS_FIYATI',Tax as 'VERGI' from Product\r\ninner join Category on Category.ID=CategoryID\r\nwhere Amount>=1", SQLClientConnect.Db);
        }
        private void Sales_Load(object sender, EventArgs e)
        {
            ComboList();
            Lk_Customer.Properties.DisplayMember = "MUSTERI";
            Lk_Customer.Properties.ValueMember = "ID";
            Lk_Product.Properties.DisplayMember = "URUN_ADI";
            Lk_Product.Properties.ValueMember = "ID";
        }
        private void Btn_RowAdd_Click(object sender, EventArgs e)
        {
            if (DatabaseControl.OrderControl(Lk_Customer, Lk_Product, Cmb_Tax, Nmr_Amount, dataGridView1))
            {
                Lk_Customer.Enabled = false;
                dataGridView1.Rows.Add(Lk_Product.EditValue, Lk_Product.Text, Nmr_Amount.Value.ToString().Replace(',', '.'), Nmr_SalesPrice.Value.ToString().Replace(',', '.'), Cmb_Tax.Text, (Nmr_Amount.Value * (Nmr_SalesPrice.Value) * DatabaseControl.TaxControl(Cmb_Tax.Text)).ToString().Replace(',', '.'), Rch_Description.Text);
                Clear();
            }
        }
        private void Lk_Product_EditValueChanged(object sender, EventArgs e)
        {
            if (Lk_Product.EditValue is not null)
            {
                SQLClientConnect.Db.Open();
                SQLiteCommand cmd = new("select SalesPrice,Tax from Product where ID=" + Lk_Product.EditValue + "", SQLClientConnect.Db);
                SQLiteDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    Nmr_SalesPrice.Value = (decimal)rd[0];
                    Cmb_Tax.Text = rd[1].ToString();
                }
                SQLClientConnect.Db.Close();
            }
        }
        private void Btn_Add_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
            {
                if (DialogResult.Yes == XtraMessageBox.Show("SATIŞ İŞLEMİ YAPMAK İSTEDİĞİNİZDEN EMİN MİSİNİZ ?", "SATIŞ İŞLEMİ", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    for (byte i = 0; i < dataGridView1.RowCount; i++)
                        OrderFiche.Total += double.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString().Replace('.', ','));
                    OrderFiche.ID = OrderFiche.OrderIDReturn(
                        "insert into OrderFiche (CustomerID,_Date,Total) values (" + Lk_Customer.EditValue + ",'" + DateTime.Now +
                        "'," + OrderFiche.Total.ToString().Replace(',', '.') + ")", SQLClientConnect.Db);
                    if (OrderFiche.ID is not null)
                    {
                        for (byte i = 0; i < dataGridView1.RowCount; i++)
                        {
                            SQLClientConnect.CRUD(
                                "insert into OrderLine (FicheID,ProductID,Amount,Sales,Tax,Total,ProductDescription) values (" +
                                OrderFiche.ID + ", " + dataGridView1.Rows[i].Cells[0].Value + "," +
                                dataGridView1.Rows[i].Cells[2].Value + "," + dataGridView1.Rows[i].Cells[3].Value +
                                "," + dataGridView1.Rows[i].Cells[4].Value + "," +
                                dataGridView1.Rows[i].Cells[5].Value + ",'" + dataGridView1.Rows[i].Cells[6].Value +
                                "')", SQLClientConnect.Db);
                        }
                        XtraMessageBox.Show("SATIŞ İŞLEMİ BAŞARILI !!", "BAŞARILI", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        Clear();
                        Lk_Customer.Enabled = true;
                        Lk_Customer.EditValue = null;
                        dataGridView1.Rows.Clear();
                        OrderFiche.Total = 0;
                        OrderFiche.ID = null;
                        ComboList();
                    }
                }
            }
            else
                XtraMessageBox.Show("SATIŞ İŞLEMİ YAPABİLMENİZ İÇİN ÖNCE SATIR EKLEMENİZ GEREKMEKTEDİR", "HATALI", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}