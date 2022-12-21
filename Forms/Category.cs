using DevExpress.XtraEditors;
using StockFollow_Up.Classes;
using System;
using System.Windows.Forms;

namespace StockFollow_Up.Forms
{
    public partial class Category : DevExpress.XtraEditors.XtraForm
    {
        public Category()
        {
            InitializeComponent();
        }
        private readonly FolderBrowserDialog fr = new();
        private string ID = null;
        void Clear()
        {
            Txt_CategoryName.Text = null;
            Txt_CategoryName.Focus();
            ID = null;
        }
        void UpdateCategory()
        {
            if (string.IsNullOrEmpty(ID))
                XtraMessageBox.Show("GÜNCELLEMEK İSTEDİĞİNİZ KATEGORİYİ LİSTEDEN SEÇİNİZ !!", "HATALI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            else
            {
                if (DatabaseControl.CategoryControl(Txt_CategoryName, ID))
                {
                    if (DialogResult.Yes == XtraMessageBox.Show("KATEGORİ GÜNCELLEMEK İSTEDİĞİNİZDEN EMİN MİSİNİZ ?", "GÜNCELLEME İŞLEMİ", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        if (SQLClientConnect.CRUD("update Category set CategoryName='" + Txt_CategoryName.Text.Trim() + "' where ID=" + ID + "", SQLClientConnect.Db))
                        {
                            gridControl1.DataSource = SQLClientConnect.GenericList("SELECT ID,CategoryName as 'KATEGORI_ADI' FROM Category", SQLClientConnect.Db);
                            Clear();
                            XtraMessageBox.Show("KATEGORİ GÜNCELLEME İŞLEMİ BAŞARILI !!", "GÜNCELLEME İŞLEMİ", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }
        void Delete()
        {
            if (string.IsNullOrEmpty(ID))
                XtraMessageBox.Show("SİLMEK İSTEDİĞİNİZ KATEGORİYİ LİSTEDEN SEÇİNİZ !!", "HATALI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            else
            {
                if (DialogResult.Yes == XtraMessageBox.Show("KATEGORİ SİLMEK İSTEDİĞİNİZDEN EMİN MİSİNİZ ? KATEGORİYİ SİLERSENİZ KATEGORİYE BAĞLI SATIŞLAR VE ÜRÜNLER SİLİNECEKTİR !!!", "SİLME İŞLEMİ", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    if (SQLClientConnect.CRUD("delete from Category where ID=" + ID + "", SQLClientConnect.Db))
                    {
                        gridControl1.DataSource = SQLClientConnect.GenericList("SELECT ID,CategoryName as 'KATEGORI_ADI' FROM Category", SQLClientConnect.Db);
                        Clear();
                        XtraMessageBox.Show("KATEGORİ SİLME İŞLEMİ BAŞARILI !!", "SİLME İŞLEMİ", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }
            }
        }
        void Add()
        {
            if (DatabaseControl.CategoryControl(Txt_CategoryName, null))
            {
                if (DialogResult.Yes == XtraMessageBox.Show("KATEGORİ EKLEMEK İSTEDİĞİNİZDEN EMİN MİSİNİZ ?", "EKLEME İŞLEMİ", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    if (SQLClientConnect.CRUD("insert into Category (CategoryName) values ('" +
                                              Txt_CategoryName.Text.Trim() + "')", SQLClientConnect.Db))
                    {
                        gridControl1.DataSource = SQLClientConnect.GenericList("SELECT ID,CategoryName as 'KATEGORI_ADI' FROM Category", SQLClientConnect.Db);
                        Clear();
                        XtraMessageBox.Show("KATEGORİ EKLEME İŞLEMİ BAŞARILI !!", "EKLEME İŞLEMİ", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }
            }
        }
        private void Category_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
            else if (e.KeyCode == Keys.F2)
                Add();
            else if (e.KeyCode == Keys.F3)
                Delete();
            else if (e.KeyCode == Keys.F5)
                UpdateCategory();
        }
        private void excelAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fr.ShowDialog() == DialogResult.OK)
                DataExport.GridExport(gridControl1, fr.SelectedPath, "KategoriListesi.xlsx");
        }
        private void pdfAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fr.ShowDialog() == DialogResult.OK)
                DataExport.GridExport(gridControl1, fr.SelectedPath, "KategoriListesi.pdf");
        }
        private void resimAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fr.ShowDialog() == DialogResult.OK)
                DataExport.GridExport(gridControl1, fr.SelectedPath, "KategoriListesi.html");
        }
        private void Category_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = SQLClientConnect.GenericList("SELECT ID,CategoryName as 'KATEGORI_ADI' FROM Category", SQLClientConnect.Db);
        }
        private void Btn_Add_Click(object sender, EventArgs e)
        {
            Add();
        }
        private void Btn_Update_Click(object sender, EventArgs e)
        {
            UpdateCategory();

        }
        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            Delete();
        }
        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            ID = gridView1.GetFocusedRowCellValue("ID").ToString();
            Txt_CategoryName.Text = gridView1.GetFocusedRowCellValue("KATEGORI_ADI").ToString();
        }
        private void Txt_CategoryName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                                                  && !char.IsSeparator(e.KeyChar);
        }
    }
}