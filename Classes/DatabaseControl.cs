using DevExpress.XtraEditors;
using System.Data.SQLite;
using System.Windows.Forms;
using ComboBox = System.Windows.Forms.ComboBox;

namespace StockFollow_Up.Classes
{
    internal class DatabaseControl
    {

        private static readonly char[] turkishControl = new char[] { 'ç', 'Ç', 'ö', 'Ö', 'İ', 'ş', 'Ş', 'ü', 'Ü', 'ğ', 'Ğ', 'ı' };
        internal static bool CustomerControl(TextBox tc, TextBox customerName, MaskedTextBox phone, TextBox mail, LookUpEdit city, LookUpEdit town, string ID)
        {
            #region TCCONTROL
            if (string.IsNullOrEmpty(tc.Text))
            {
                XtraMessageBox.Show("TC-VKN METİN KUTUSU BOŞ GEÇİLEMEZ !!", "HATALI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tc.Focus();
                return false;
            }
            else if (tc.Text.Length < 10)
            {
                XtraMessageBox.Show("TC-VKN METİN KUTUSU 10 HANEDEN KÜÇÜK OLAMAZ !!", "HATALI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tc.Focus();
                return false;
            }
            #endregion
            #region CUSTOMERNAMECONTROL
            else if (string.IsNullOrEmpty(customerName.Text))
            {
                XtraMessageBox.Show("MÜŞTERİ UNVAN METİN KUTUSU BOŞ GEÇİLEMEZ !!", "HATALI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                customerName.Focus();
                return false;
            }
            else if (customerName.Text.Length < 4)
            {
                XtraMessageBox.Show("MÜŞTERİ UNVAN METİN KUTUSU 4 HANEDEN KÜÇÜK OLAMAZ !!", "HATALI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                customerName.Focus();
                return false;
            }
            #endregion
            #region PHONECONTROL
            else if (phone.Text.Length < 13 || phone.Text.Contains(" "))
            {
                XtraMessageBox.Show("TELEFON METİN KUTUSUNU TAMAMEN DOLDURUNUZ !!", "HATALI", MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
                phone.Focus();
                return false;
            }
            #endregion PHONE
            #region MAILCONTROL
            else if (string.IsNullOrEmpty(mail.Text))
            {
                XtraMessageBox.Show("MAİL METİN KUTUSU BOŞ GEÇİLEMEZ !!", "HATALI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                mail.Focus();
                return false;
            }
            else if (!mail.Text.Contains("@"))
            {
                XtraMessageBox.Show("MAİL METİN KUTUSU MAİL FORMATI GEÇERSİZ !!", "HATALI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                mail.Text = null;
                mail.Focus();
                return false;
            }
            if (mail.Text.Length < 6)
            {
                XtraMessageBox.Show("MAİL METİN KUTUSU 6 KARAKTERDEN KÜÇÜK OLAMAZ !!", "HATALI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                mail.Focus();
                return false;
            }
            for (byte i = 0; i < turkishControl.Length; i++)
            {
                if (mail.Text.Contains(turkishControl[i].ToString()))
                {
                    XtraMessageBox.Show("MAİL METİN KUTUSUNDA TÜRKÇE KARAKTER OLAMAZ !!", "HATALI",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mail.Text = string.Empty;
                    mail.Focus();
                    return false;
                }
            }
            #endregion
            #region CITYCONTROL
            if (string.IsNullOrEmpty(city.Text))
            {
                XtraMessageBox.Show("MÜŞTERİ İL BOŞ GEÇİLEMEZ !!", "HATALI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                city.Focus();
                return false;
            }
            #endregion
            #region TOWNCONTROL
            if (string.IsNullOrEmpty(town.Text))
            {
                XtraMessageBox.Show("MÜŞTERİ İLÇE BOŞ GEÇİLEMEZ !!", "HATALI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                town.Focus();
                return false;
            }

            #endregion
            #region SQLCONTROL
            //ADD CONTROL TC,CUSTOMERNAME,PHONE,E-MAIL
            SQLiteCommand cmd;
            if (string.IsNullOrEmpty(ID))
                cmd = new("SELECT TC_VKN,CustomerName,Phone,E_Mail FROM Customer", SQLClientConnect.Db);
            else
                cmd = new("SELECT TC_VKN,CustomerName,Phone,E_Mail FROM Customer where ID!=" + ID + " ", SQLClientConnect.Db);
            SQLClientConnect.Db.Open();
            SQLiteDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                if (rd[0].ToString() == tc.Text)
                {
                    rd.Close();
                    SQLClientConnect.Db.Close();
                    XtraMessageBox.Show("TANIMLANMAK İSTENEN MÜŞTERİ TC-VKN DAHA ÖNCEDEN TANIMLANMIŞTIR !!", "HATALI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tc.Focus();
                    return false;
                }
                else if (rd[1].ToString() == customerName.Text || rd[1].ToString() == customerName.Text.ToUpper() || rd[1].ToString() == customerName.Text.ToLower())
                {
                    rd.Close();
                    SQLClientConnect.Db.Close();
                    XtraMessageBox.Show("TANIMLANMAK İSTENEN MÜŞTERİ UNVANI DAHA ÖNCEDEN TANIMLANMIŞTIR !!", "HATALI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    customerName.Focus();
                    return false;
                }
                else if (rd[2].ToString() == phone.Text)
                {
                    rd.Close();
                    SQLClientConnect.Db.Close();
                    XtraMessageBox.Show("TANIMLANMAK İSTENEN MÜŞTERİ TELEFONU DAHA ÖNCEDEN TANIMLANMIŞTIR !!", "HATALI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    phone.Focus();
                    return false;
                }
                else if (rd[3].ToString() == mail.Text || rd[3].ToString() == mail.Text.ToUpper() || rd[3].ToString() == mail.Text.ToLower())
                {
                    rd.Close();
                    SQLClientConnect.Db.Close();
                    XtraMessageBox.Show("TANIMLANMAK İSTENEN MÜŞTERİ MAİL ADRESİ DAHA ÖNCEDEN TANIMLANMIŞTIR !!", "HATALI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mail.Focus();
                    return false;
                }
            }
            SQLClientConnect.Db.Close();
            #endregion
            return true;
        }
        internal static bool ProductControl(TextBox barcode, LookUpEdit category, TextBox productName, ComboBox tax, string ID)
        {
            #region BARCODE
            if (string.IsNullOrEmpty(barcode.Text))
            {
                XtraMessageBox.Show("BARKOD KODU METİN KUTUSU BOŞ BIRAKILAMAZ !!", "HATALI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                barcode.Focus();
                return false;
            }
            else if (barcode.Text.Length < 13)
            {
                XtraMessageBox.Show("BARKOD METİN KUTUSU 13 HANEDEN KÜÇÜK OLAMAZ !!", "HATALI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                barcode.Focus();
                return false;
            }
            for (byte i = 0; i < barcode.Text.Length; i++)
            {
                if (!char.IsNumber(barcode.Text[i]))
                {
                    XtraMessageBox.Show("BARKOD METİN KUTUSUNDA RAKAM DIŞINDA BİR VERİ GİRİŞİ OLAMAZ !!", "HATALI",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    barcode.Text = null;
                    barcode.Focus();
                    return false;
                }
            }
            #endregion
            #region CATEGORY
            if (string.IsNullOrEmpty(category.Text))
            {
                XtraMessageBox.Show("KATEGORİ BOŞ GEÇİLEMEZ !!", "HATALI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                category.Focus();
                return false;
            }
            #endregion
            #region PRODUCTNAME
            if (string.IsNullOrEmpty(productName.Text))
            {
                XtraMessageBox.Show("ÜRÜN ADI METİN KUTUSU BOŞ BIRAKILAMAZ !!", "HATALI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                productName.Focus();
                return false;
            }
            else if (productName.Text.Length < 2)
            {
                XtraMessageBox.Show("ÜRÜN ADI METİN KUTUSU 2 HANEDEN KÜÇÜK OLAMAZ !!", "HATALI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                productName.Focus();
                return false;
            }



            #endregion
            #region TAX
            else if (string.IsNullOrEmpty(tax.Text))
            {
                XtraMessageBox.Show("KDV ORANI BOŞ GEÇİLEMEZ !!", "HATALI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tax.Focus();
                return false;
            }
            #endregion
            #region DATABASECONTROL
            SQLiteCommand cmd;
            SQLClientConnect.Db.Open();
            if (string.IsNullOrEmpty(ID))
                cmd = new SQLiteCommand("select BarcodeNo,ProductName  from Product", SQLClientConnect.Db);
            else
                cmd = new SQLiteCommand("select BarcodeNo,ProductName from Product where ID <>" + ID + "", SQLClientConnect.Db);
            SQLiteDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                if (barcode.Text == (string)rd[0])
                {
                    XtraMessageBox.Show("BARKOD KODU DAHA ÖNCEDEN TANIMLANMIŞTIR !!", "HATALI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    barcode.Focus();
                    rd.Close();
                    SQLClientConnect.Db.Close();
                    return false;
                }
                else if (productName.Text.ToUpper() == (string)rd[1] || productName.Text.ToLower() == (string)rd[1] || productName.Text == (string)rd[1])
                {
                    XtraMessageBox.Show("ÜRÜN ADI DAHA ÖNCEDEN TANIMLANMIŞTIR !!", "HATALI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    productName.Focus();
                    rd.Close();
                    SQLClientConnect.Db.Close();
                    return false;
                }
            }
            SQLClientConnect.Db.Close();
            #endregion
            return true;
        }
        internal static bool CategoryControl(TextBox categoryName, string ID)
        {
            #region CATEGORY
            if (string.IsNullOrEmpty(categoryName.Text))
            {
                XtraMessageBox.Show("KATEGORİ METİN KUTUSU BOŞ GEÇİLEMEZ !!", "HATALI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                categoryName.Focus();
                return false;
            }
            else if (categoryName.Text.Length < 2)
            {
                XtraMessageBox.Show("KATEGORİ METİN KUTUSU 2 HANEDEN KÜÇÜK OLAMAZ !!", "HATALI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                categoryName.Focus();
                return false;
            }
            for (byte i = 0; i < categoryName.Text.Length; i++)
            {
                if (char.IsNumber(categoryName.Text[i]))
                {
                    XtraMessageBox.Show("KATEGORİ ADINDA RAKAM BULUNAMAZ !!", "HATALI", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    categoryName.Text = null;
                    categoryName.Focus();
                    return false;
                }
            }
            #endregion
            #region DATABASECONTROL
            SQLiteCommand cmd;
            SQLClientConnect.Db.Open();
            if (string.IsNullOrEmpty(ID))
                cmd = new SQLiteCommand("select CategoryName from Category", SQLClientConnect.Db);
            else
                cmd = new SQLiteCommand("select CategoryName from Category where ID <>" + ID + "", SQLClientConnect.Db);
            SQLiteDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                if (categoryName.Text == (string)rd[0] || categoryName.Text.ToUpper() == (string)rd[0] || categoryName.Text.ToLower() == (string)rd[0])
                {
                    XtraMessageBox.Show("KATEGORİ ADI DAHA ÖNCEDEN TANIMLANMIŞTIR !!", "HATALI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    categoryName.Focus();
                    rd.Close();
                    SQLClientConnect.Db.Close();
                    return false;
                }
            }
            SQLClientConnect.Db.Close();
            #endregion
            return true;
        }
        internal static decimal TaxControl(string tax)
        {
            decimal Tax = default;
            switch (tax)
            {
                case "18":
                    Tax = 1.18m;
                    break;
                case "8":
                    Tax = 1.08m;
                    break;
                case "1":
                    Tax = 1.01m;
                    break;
                case "0":
                    Tax = 1;
                    break;
            }
            return Tax;
        }
        internal static bool OrderControl(LookUpEdit customer, LookUpEdit product, ComboBox tax, NumericUpDown amount, DataGridView dt)
        {
            #region CUSTOMER
            if (string.IsNullOrEmpty(customer.Text))
            {
                XtraMessageBox.Show("MÜŞTERİ BİLGİSİ BOŞ GEÇİLEMEZ !!", "HATALI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                customer.Focus();
                return false;
            }
            #endregion
            #region PRODUCT
            else if (string.IsNullOrEmpty(product.Text))
            {
                XtraMessageBox.Show("ÜRÜN BİLGİSİ BOŞ GEÇİLEMEZ !!", "HATALI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                product.Focus();
                return false;
            }
            #endregion
            #region TAX
            else if (string.IsNullOrEmpty(tax.Text))
            {
                XtraMessageBox.Show("KDV BİLGİSİ BOŞ GEÇİLEMEZ !!", "HATALI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                tax.Focus();
                return false;
            }
            #endregion
            #region DATAGRID
            for (byte i = 0; i < dt.RowCount; i++)
            {
                if ((dt.Rows[i].Cells[1].Value.ToString() == product.Text))
                {
                    XtraMessageBox.Show("EKLENMEK İSTENEN ÜRÜN ALTTAKİ TABLODA DAHA ÖNCEDEN TANIMLANMIŞTIR !!",
                        "HATALI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            #endregion
            #region DATABASECONTROL
            SQLClientConnect.Db.Open();
            SQLiteCommand cmd = new("select Amount from Product where ID=" + product.EditValue + "", SQLClientConnect.Db);
            SQLiteDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                if ((decimal)rd[0] < amount.Value)
                {
                    XtraMessageBox.Show("SATILACAK MİKTAR ÜRÜN MİKTARINDAN FAZLADIR !!", "HATALI", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    rd.Close();
                    SQLClientConnect.Db.Close();
                    return false;
                }
            }
            SQLClientConnect.Db.Close();
            #endregion
            return true;
        }
        internal static bool MailControl(TextBox Email, TextBox password, TextBox host, NumericUpDown port)
        {
            #region MAİLCONTROL
            if (string.IsNullOrEmpty(Email.Text))
            {
                XtraMessageBox.Show("E-MAİL KUTUSU BOŞ GEÇİLEMEZ !!", "HATALI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                Email.Focus();
                return false;
            }
            else if (!Email.Text.Contains("@"))
            {
                XtraMessageBox.Show("MAİL FORMATI GEÇERSİZ TEKRAR GİRİŞİ YAPINIZ !!", "HATALI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                Email.Focus();
                Email.Text = string.Empty;
                return false;
            }
            else if (Email.Text.Length < 8)
            {
                XtraMessageBox.Show("E-MAİL KUTUSU GİRİLEN MAİL 8 KARAKTERDEN KISA OLAMAZ !!", "HATALI",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Email.Focus();
                return false;
            }
            for (byte i = 0; i < turkishControl.Length; i++)
            {
                if (Email.Text.Contains(turkishControl[i].ToString()))
                {
                    XtraMessageBox.Show("MAİL METİN KUTUSUNDA TÜRKÇE KARAKTER OLAMAZ !!", "HATALI",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Email.Text = string.Empty;
                    Email.Focus();
                    return false;
                }
            }
            #endregion MAİLCONTROL
            #region PASSWORD CONTROL
            if (string.IsNullOrEmpty(password.Text))
            {
                XtraMessageBox.Show("ŞİFRE METİN KUTUSU BOŞ GEÇİLEMEZ !!", "HATALI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                password.Focus();
                return false;
            }
            else if (password.Text.Length < 3)
            {
                XtraMessageBox.Show("ŞİFRE METİN 3 HANEDEN KÜÇÜK OLAMAZ !!", "HATALI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                password.Focus();
                return false;
            }
            #endregion PASSWORD CONTROL
            #region HOSTCONTROL
            else if (string.IsNullOrEmpty(host.Text))
            {
                XtraMessageBox.Show("HOST METİN KUTUSU BOŞ GEÇİLEMEZ !!", "HATALI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                host.Focus();
                return false;
            }
            else if (host.Text.Length < 5)
            {
                XtraMessageBox.Show("HOST METİN KUTUSU 5 HANEDEN KÜÇÜK OLAMAZ !!", "HATALI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                host.Focus();
                return false;
            }
            #endregion HOSTCONTROL
            return true;
        }
        internal static bool CompanyControl(TextBox companyName, MaskedTextBox phone, RichTextBox adress, TextBox mail, PictureEdit image)
        {
            #region COMPANY
            if (string.IsNullOrEmpty(companyName.Text))
            {
                XtraMessageBox.Show("ŞİRKET UNVANI METİN KUTUSU BOŞ GEÇİLEMEZ !!", "HATALI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                companyName.Focus();
                return false;
            }
            else if (companyName.Text.Length < 4)
            {
                XtraMessageBox.Show("ŞİRKET UNVANI METİN KUTUSU 4 HANEDEN KÜÇÜK OLAMAZ !!", "HATALI",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                companyName.Focus();
                return false;
            }
            #endregion
            #region PHONE
            else if (phone.Text.Length < 13 || phone.Text.Contains(" "))
            {
                XtraMessageBox.Show("TELEFON METİN KUTUSUNU TAMAMEN DOLDURUNUZ !!", "HATALI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                phone.Focus();
                return false;
            }
            #endregion
            #region ADRESS
            else if (string.IsNullOrEmpty(adress.Text))
            {
                XtraMessageBox.Show("ADRES METİN KUTUSU BOŞ GEÇİLEMEZ !!", "HATALI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                adress.Focus();
                return false;
            }
            else if (adress.Text.Length < 4)
            {
                XtraMessageBox.Show("ADRES METİN KUTUSU 4 HANEDEN KÜÇÜK OLAMAZ !!", "HATALI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                adress.Focus();
                return false;
            }
            #endregion
            #region EMAIL
            else if (string.IsNullOrEmpty(mail.Text))
            {
                XtraMessageBox.Show("MAİL METİN KUTUSU BOŞ GEÇİLEMEZ !!", "HATALI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                mail.Focus();
                return false;
            }
            else if (!mail.Text.Contains("@"))
            {
                XtraMessageBox.Show("MAİL METİN KUTUSU MAİL FORMATI GEÇERSİZ !!", "HATALI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                mail.Text = null;
                mail.Focus();
                return false;
            }
            else if (mail.Text.Length < 6)
            {
                XtraMessageBox.Show("MAİL METİN KUTUSU 6 KARAKTERDEN KÜÇÜK OLAMAZ !!", "HATALI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                mail.Focus();
                return false;
            }
            for (byte i = 0; i < turkishControl.Length; i++)
            {
                if (mail.Text.Contains(turkishControl[i].ToString()))
                {
                    XtraMessageBox.Show("MAİL METİN KUTUSUNDA TÜRKÇE KARAKTER OLAMAZ !!", "HATALI",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mail.Text = string.Empty;
                    mail.Focus();
                    return false;
                }
            }
            #endregion
            #region PICTURE
            if (image.Image is null)
            {
                XtraMessageBox.Show("RESİM KUTUSU BOŞ GEÇİLEMEZ RESİM SEÇİNİZ !!", "HATALI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                image.Focus();
                return false;
            }
            #endregion
            return true;
        }
    }
}