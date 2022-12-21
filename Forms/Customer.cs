using DevExpress.XtraEditors;
using StockFollow_Up.Classes;
using System;
using System.Data.SQLite;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using static StockFollow_Up.Classes.MailSend;

namespace StockFollow_Up.Forms
{
    public partial class Customer : DevExpress.XtraEditors.XtraForm
    {
        public Customer()
        {
            InitializeComponent();
        }
        private readonly FolderBrowserDialog fr = new();
        private string ID = null;
        private void Clear()
        {
            foreach (System.Windows.Forms.Control item in groupControl1.Controls)
            {
                if (item is TextBox)
                    item.Text = null;
            }
            Rch_Adress.Text = null;
            pictureEdit1.Image = null;
            Lk_City.EditValue = null;
            Lk_Town.EditValue = null;
            Msk_Phone.Text = null;
            Lbl_Balance.Text = "0";
            ID = null;
            Txt_TC_VKN.Focus();
        }
        private void DeleteCustomer()
        {
            if (!string.IsNullOrEmpty(ID))
            {
                if (DialogResult.Yes == XtraMessageBox.Show("SEÇİLEN MÜŞTERİYİ SİLME İŞLEMİ YAPMAK İSTEDİĞİNİZDEN EMİN MİSİNİZ ? MÜŞTERİ SİLİNİRSE TÜM SATIŞLARIDA SİLİNECEKTİR !!", "SİLME İŞLEMİ", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    if (SQLClientConnect.CRUD("delete from Customer where ID='" + ID + "'", SQLClientConnect.Db))
                    {
                        XtraMessageBox.Show("MÜŞTERİ SİLME İŞLEMİ BAŞARILI !!", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        gridControl1.DataSource = SQLClientConnect.GenericList("select Customer.ID,TC_VKN,CustomerName as 'MUSTERI_ADI',Phone as 'TELEFON',E_Mail as 'E_MAIL',Cities.CityName as 'IL',Town.TownName AS 'ILCE',Adress as 'ADRES',CustomerPicture as 'RESIM',Balance as 'BAKIYE',_Date as 'KAYIT_TARIHI' from Customer\r\ninner join Cities on Cities.ID=Customer.CityID\r\ninner join Town on Town.ID=TownID", SQLClientConnect.Db);
                        Clear();
                    }
                }
            }
            else
                XtraMessageBox.Show("SİLME İŞLEMİ YAPILMAK İSTENEN KAYDI LİSTEDEN SEÇİNİZ !!", "SİLME İŞLEMİ",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void UpdateCustomer()
        {
            if (!string.IsNullOrEmpty(ID))
            {
                if (DatabaseControl.CustomerControl(Txt_TC_VKN, Txt_CustomerName, Msk_Phone, Txt_EMail, Lk_City, Lk_Town, ID))
                {
                    if (DialogResult.Yes == XtraMessageBox.Show("SEÇİLEN MÜŞTERİ GÜNCELLEME İŞLEMİ YAPMAK İSTEDİĞİNİZDEN EMİN MİSİNİZ ?", "GÜNCELLEME İŞLEMİ", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        if (SQLClientConnect.CRUD(
                            "update Customer set TC_VKN='" + Txt_TC_VKN.Text.Trim() + "',CustomerName='" +
                            Txt_CustomerName.Text.Trim() + "',Phone='" + Msk_Phone.Text.Trim() + "',E_Mail='" +
                            Txt_EMail.Text.Trim() + "',CityID='" + Lk_City.EditValue + "',TownID='" +
                            Lk_Town.EditValue + "',Adress='" + Rch_Adress.Text.Trim() + "',CustomerPicture='" +
                            ImageConvert.ImageToBase64(pictureEdit1.Image, ImageFormat.Jpeg) + "' where ID='" + ID +
                            "' ", SQLClientConnect.Db))
                        {
                            XtraMessageBox.Show("MÜŞTERİ GÜNCELLEME İŞLEMİ BAŞARILI !!", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            gridControl1.DataSource = SQLClientConnect.GenericList("select Customer.ID,TC_VKN,CustomerName as 'MUSTERI_ADI',Phone as 'TELEFON',E_Mail as 'E_MAIL',Cities.CityName as 'IL',Town.TownName AS 'ILCE',Adress as 'ADRES',CustomerPicture as 'RESIM',Balance as 'BAKIYE',_Date as 'KAYIT_TARIHI' from Customer\r\ninner join Cities on Cities.ID=Customer.CityID\r\ninner join Town on Town.ID=TownID", SQLClientConnect.Db);
                            Clear();
                        }
                    }
                }
            }
            else
                XtraMessageBox.Show("GÜNCELLEME İŞLEMİ YAPILMAK İSTENEN KAYDI LİSTEDEN SEÇİNİZ !!", "GÜNCELLEME İŞLEMİ",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void AddCustomer()
        {
            if (DatabaseControl.CustomerControl(Txt_TC_VKN, Txt_CustomerName, Msk_Phone, Txt_EMail, Lk_City, Lk_Town, null))
            {
                if (DialogResult.Yes == XtraMessageBox.Show("MÜŞTERİ EKLEME İŞLEMİ YAPMAK İSTEDİĞİNİZDEN EMİN MİSİNİZ ?", "EKLEME İŞLEMİ", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    if (SQLClientConnect.CRUD(
                        "insert into Customer (TC_VKN,CustomerName,Phone,E_Mail,CityID,TownID,Adress,CustomerPicture,_Date) values ('" +
                        Txt_TC_VKN.Text.Trim() + "','" + Txt_CustomerName.Text.Trim() + "','" + Msk_Phone.Text.Trim() + "','" +
                        Txt_EMail.Text.Trim() + "','" + Lk_City.EditValue + "','" + Lk_Town.EditValue + "','" +
                        Rch_Adress.Text.Trim() + "','" +
                        ImageConvert.ImageToBase64(pictureEdit1.Image, ImageFormat.Jpeg) + "','" + DateTime.Now + "') ",
                        SQLClientConnect.Db))
                    {
                        XtraMessageBox.Show("MÜŞTERİ EKLEME İŞLEMİ BAŞARILI !!", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        gridControl1.DataSource = SQLClientConnect.GenericList("select Customer.ID,TC_VKN,CustomerName as 'MUSTERI_ADI',Phone as 'TELEFON',E_Mail as 'E_MAIL',Cities.CityName as 'IL',Town.TownName AS 'ILCE',Adress as 'ADRES',CustomerPicture as 'RESIM',Balance as 'BAKIYE',_Date as 'KAYIT_TARIHI' from Customer\r\ninner join Cities on Cities.ID=Customer.CityID\r\ninner join Town on Town.ID=TownID", SQLClientConnect.Db);
                        Clear();
                    }
                }
            }
        }
        private void Customer_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = SQLClientConnect.GenericList("select Customer.ID,TC_VKN,CustomerName as 'MUSTERI_ADI',Phone as 'TELEFON',E_Mail as 'E_MAIL',Cities.CityName as 'IL',Town.TownName AS 'ILCE',Adress as 'ADRES',CustomerPicture as 'RESIM',Balance as 'BAKIYE',_Date as 'KAYIT_TARIHI' from Customer\r\ninner join Cities on Cities.ID=Customer.CityID\r\ninner join Town on Town.ID=TownID", SQLClientConnect.Db);
            gridView1.Columns["ID"].Visible = false;
            gridView1.Columns["RESIM"].Visible = false;
            Lk_City.Properties.DataSource = SQLClientConnect.GenericList("select ID,CityName as 'IL' from Cities", SQLClientConnect.Db);
            Lk_City.Properties.DisplayMember = "IL";
            Lk_City.Properties.ValueMember = "ID";
            Lk_Town.Properties.DisplayMember = "ILCE";
            Lk_Town.Properties.ValueMember = "ID";
        }
        private void Customer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
            else if (e.KeyCode == Keys.F2)
                AddCustomer();
            else if (e.KeyCode == Keys.F3)
                DeleteCustomer();
            else if (e.KeyCode == Keys.F5)
                UpdateCustomer();
        }
        private void Btn_Add_Click(object sender, EventArgs e)
        {
            AddCustomer();
        }
        private void Btn_Update_Click(object sender, EventArgs e)
        {
            UpdateCustomer();
        }
        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            DeleteCustomer();
        }
        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void excelAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fr.ShowDialog() == DialogResult.OK)
                DataExport.GridExport(gridControl1, fr.SelectedPath, "MusteriListesi.xlsx");
        }
        private void pdfAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fr.ShowDialog() == DialogResult.OK)
                DataExport.GridExport(gridControl1, fr.SelectedPath, "MusteriListesi.pdf");
        }
        private void resimAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fr.ShowDialog() == DialogResult.OK)
                DataExport.GridExport(gridControl1, fr.SelectedPath, "MusteriListesi.html");
        }
        private void Txt_TC_VKN_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void Lk_City_EditValueChanged(object sender, EventArgs e)
        {
            Lk_Town.Properties.DataSource = SQLClientConnect.GenericList("select ID,TownName as 'ILCE' from Town where CityID='" + Lk_City.EditValue + "' ", SQLClientConnect.Db);
        }
        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            ID = gridView1.GetFocusedRowCellValue("ID").ToString();
            Txt_TC_VKN.Text = gridView1.GetFocusedRowCellValue("TC_VKN").ToString();
            Txt_CustomerName.Text = gridView1.GetFocusedRowCellValue("MUSTERI_ADI").ToString();
            Msk_Phone.Text = gridView1.GetFocusedRowCellValue("TELEFON").ToString();
            Txt_EMail.Text = gridView1.GetFocusedRowCellValue("E_MAIL").ToString();
            Lk_City.Text = gridView1.GetFocusedRowCellValue("IL").ToString();
            Lk_Town.Text = gridView1.GetFocusedRowCellValue("ILCE").ToString();
            Rch_Adress.Text = gridView1.GetFocusedRowCellValue("ADRES").ToString();
            pictureEdit1.Image = ImageConvert.Base64ToImage(gridView1.GetFocusedRowCellValue("RESIM").ToString());
            Lbl_Balance.Text = gridView1.GetFocusedRowCellValue("BAKIYE").ToString();
        }
        private async void topluHerkeseMutabakatGönderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] dizi = new string[3];
            SQLClientConnect.Db.Open();
            SQLiteCommand cmd = new("select * from CompanyInfo where ID=1", SQLClientConnect.Db);
            SQLiteDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                dizi[0] = rd[1].ToString();
                dizi[1] = rd[2].ToString();
                dizi[2] = rd[4].ToString();
            }
            SQLClientConnect.Db.Close();
            ProgressBar frBar = new();
            if (XtraMessageBox.Show($"TOPLU OLARAK {gridView1.RowCount} ADET MÜŞTERİYE MAİL GÖNDERİLECEKTİR EMİN MİSİNİZ ?", "MAİL GÖNDERME", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                frBar.Show();
                frBar.totalMailCount = (byte)gridView1.RowCount;
                frBar.ProgressBarPlus();
                for (byte i = 0; i < gridView1.RowCount; i++)
                {
                    if (PdfCreater.PdfCreat(Application.StartupPath + "\\Image\\company.jpeg", gridView1.GetRowCellValue(i, "MUSTERI_ADI").ToString(), gridView1.GetRowCellValue(i, "BAKIYE").ToString(), dizi[0], dizi[1], dizi
                        [2], gridView1.GetRowCellValue(i, "TC_VKN").ToString()))
                    {
                        if (await MailSendPassword(gridView1.GetRowCellValue(i, "E_MAIL").ToString(),
                            gridView1.GetRowCellValue(i, "TC_VKN").ToString()))
                        {

                        }
                        else
                        {
                            frBar.notMail += 1;
                            frBar.notCustomer.Add(gridView1.GetRowCellValue(i, "MUSTERI_ADI").ToString());
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("PDF OLUŞTURMA HATALI !!", "HATALI", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        frBar.notMail += 1;
                        frBar.notCustomer.Add(gridView1.GetRowCellValue(i, "MUSTERI_ADI").ToString());
                    }
                    frBar.sendMailCount = i + 1;
                    frBar.ProgressBarPlus();
                }
                frBar.EndProgressBar();
                XtraMessageBox.Show("MAİL GÖNDERME İŞLEMİ TAMAMLANDI !!", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            string[] folder = Directory.GetFiles($"{Application.StartupPath}\\Temp");
            try
            {
                foreach (string _file in folder)
                    File.Delete(_file);
            }
            catch (Exception)
            {
               
            }
        }
    }
}