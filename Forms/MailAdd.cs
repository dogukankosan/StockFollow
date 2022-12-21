using DevExpress.XtraEditors;
using StockFollow_Up.Classes;
using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace StockFollow_Up.Forms
{
    public partial class MailAdd : DevExpress.XtraEditors.XtraForm
    {
        public MailAdd()
        {
            InitializeComponent();
        }
        private char? nullChar = null;
        private void List(string sql)
        {
            SQLClientConnect.Db.Open();
            SQLiteCommand cmd = new(sql, SQLClientConnect.Db);
            try
            {
                SQLiteDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    Txt_Mail.Text = rd[1].ToString();
                    Txt_Password.Text = Encription.Desc(rd[2].ToString());
                    Txt_Host.Text = rd[3].ToString();
                    numericUpDown1.Value = decimal.Parse(rd[4].ToString());
                }
            }
            catch (Exception e)
            {
                XtraMessageBox.Show(e.Message, "HATALI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SQLClientConnect.Db.Close();
                return;
            }
            SQLClientConnect.Db.Close();
        }
        private void UpdateMail()
        {
            if (DatabaseControl.MailControl(Txt_Mail, Txt_Password, Txt_Host, numericUpDown1))
            {
                if (SQLClientConnect.CRUD("update Mail set E_MAIL='" + Txt_Mail.Text.Trim() + "', PASSWORD='" + Encription.Enc(Txt_Password.Text.Trim()) + "',HOST='" + Txt_Host.Text.Trim() + "',PORT='" + numericUpDown1.Value + "' where ID=1", SQLClientConnect.Db))
                    XtraMessageBox.Show("MAİL GÜNCELLEME İŞLEMİ BAŞARILI !!", "BAŞARILI", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                else
                    XtraMessageBox.Show("MAİL GÜNCELLEME İŞLEMİ HATALI !!", "HATALI", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
        }
        private void MailAdd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }
        private void Btn_Update_Click(object sender, System.EventArgs e)
        {
            UpdateMail();
        }
        private void MailAdd_Load(object sender, System.EventArgs e)
        {
            List("select * from Mail WHERE ID=1");
            Btn_UnEye.Visible = false;
        }
        private void Btn_UnEye_Click(object sender, EventArgs e)
        {
            Btn_Eye.Visible = true;
            Btn_UnEye.Visible = false;
            Txt_Password.PasswordChar = '*';
        }
        private void Btn_Eye_Click(object sender, EventArgs e)
        {
            Btn_UnEye.Visible = true;
            Btn_Eye.Visible = false;
            Txt_Password.PasswordChar = Convert.ToChar(nullChar);
        }
    }
}