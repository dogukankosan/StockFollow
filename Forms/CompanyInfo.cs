using DevExpress.XtraEditors;
using StockFollow_Up.Classes;
using System;
using System.Data.SQLite;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace StockFollow_Up.Forms
{
    public partial class CompanyInfo : DevExpress.XtraEditors.XtraForm
    {
        public CompanyInfo()
        {
            InitializeComponent();
        }
        private void List(string sql)
        {
            SQLClientConnect.Db.Open();
            SQLiteCommand cmd = new(sql, SQLClientConnect.Db);
            try
            {
                SQLiteDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    Txt_Company.Text = rd[1].ToString();
                    Msk_Phone.Text = rd[2].ToString();
                    Rch_Adress.Text = rd[3].ToString();
                    Txt_Email.Text = rd[4].ToString();
                }
                pictureEdit1.Image = Image.FromFile(Application.StartupPath + "\\Image\\company.jpeg");
            }
            catch (Exception e)
            {
                XtraMessageBox.Show(e.Message, "HATALI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SQLClientConnect.Db.Close();
                return;
            }
            SQLClientConnect.Db.Close();
        }
        private void CompanyUpdate()
        {
            if (DatabaseControl.CompanyControl(Txt_Company, Msk_Phone, Rch_Adress, Txt_Email, pictureEdit1))
            {
                try
                {
                    pictureEdit1.Image.Save("Image\\company.jpeg", ImageFormat.Jpeg);
                }
                catch (Exception e)
                {
                    XtraMessageBox.Show(
                        "RESİM JPG FORMATI DIŞINDA BİR RESİM FORMATI SEÇİLDİĞİ İÇİN DEĞİŞTİRİLEMİYOR JPG FORMATINDA BİR RESİM SEÇİNİZ !!", e.Message,
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (SQLClientConnect.CRUD("update CompanyInfo set CompanyName='" + Txt_Company.Text.Trim() + "',Phone='" + Msk_Phone.Text + "',Adress='" + Rch_Adress.Text.Trim() + "',E_Mail='" + Txt_Email.Text.Trim() + "' where ID=1", SQLClientConnect.Db))
                    XtraMessageBox.Show("ŞİRKET BİLGİLERİ GÜNCELLEME İŞLEMİ BAŞARILI !!", "BAŞARILI",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    XtraMessageBox.Show("ŞİRKET BİLGİLERİ GÜNCELLEME İŞLEMİ HATALI !!", "HATALI", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
        }
        private void CompanyInfo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }
        private void CompanyInfo_Load(object sender, System.EventArgs e)
        {
            List("select * from CompanyInfo where ID=1");
        }
        private void Btn_Update_Click(object sender, System.EventArgs e)
        {
            CompanyUpdate();
        }
    }
}