using DevExpress.XtraEditors;
using StockFollow_Up.Classes;
using System;
using System.Windows.Forms;

namespace StockFollow_Up.Forms
{
    public partial class CustomerBalance : DevExpress.XtraEditors.XtraForm
    {
        public CustomerBalance()
        {
            InitializeComponent();
        }
        private void CustomerBalance_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }
        private void CustomerBalance_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = SQLClientConnect.GenericList("select ID,TC_VKN,CustomerName as 'MUSTERI_UNVAN',Phone as 'TELEFON',E_Mail as 'E_MAIL',Balance as 'BAKIYE' from Customer", SQLClientConnect.Db);
        }
        private void oDEMETUTARIGİRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gridView1.GetFocusedRowCellValue("ID") is not null)
            {
                float? balance = default;
                try
                {
                    balance = float.Parse(XtraInputBox.Show("YAPTIĞI ÖDEME TUTARINI GİRİNİZ= ", "TUTAR TL", null));
                }
                catch (Exception exception)
                {
                    XtraMessageBox.Show(exception.Message, "HATALI ODEME TUTARI GİRME İŞLEMİ", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                if (SQLClientConnect.CRUD(
                    "update Customer set Balance=Balance - " + balance.ToString().Replace(',', '.') + " where ID=" +
                    gridView1.GetFocusedRowCellValue("ID") + "", SQLClientConnect.Db))
                {
                    XtraMessageBox.Show("ÖDEME İŞLEMİ GİRME BAŞARILI MÜŞTERİNİN BAKİYESİ GÜNCELLENDİ !!", "BAŞARILI",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gridControl1.DataSource = SQLClientConnect.GenericList("select ID,TC_VKN,CustomerName as 'MUSTERI_UNVAN',Phone as 'TELEFON',E_Mail as 'E_MAIL',Balance as 'BAKIYE' from Customer", SQLClientConnect.Db);
                }
                else
                    XtraMessageBox.Show("MÜŞTERİ ÖDEME İŞLEMİ GİRME HATALI !!", "HATALI", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
            else
                XtraMessageBox.Show("MÜŞTERİNİN ÖDEME İŞLEMİ İÇİN LİSTEDEN SEÇİNİZ !!", "HATALI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
        }
    }
}