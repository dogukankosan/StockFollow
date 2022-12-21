using DevExpress.XtraEditors;
using StockFollow_Up.Classes;
using System;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace StockFollow_Up.Forms
{
    public partial class Product : DevExpress.XtraEditors.XtraForm
    {
        public Product()
        {
            InitializeComponent();
        }
        private readonly FolderBrowserDialog fr = new();
        private string ID = null;
        private void Delete()
        {
            if (string.IsNullOrEmpty(ID))
                XtraMessageBox.Show("SİLMEK İSTEDİĞİNİZ ÜRÜNÜ LİSTEDEN SEÇİNİZ !!", "HATALI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            else
            {

                if (DialogResult.Yes == XtraMessageBox.Show("ÜRÜN SİLME İŞLEMİ YAPMAK İSTİYOR MUSUNUZ ? ÜRÜNÜ SİLERSENİZ ÜRÜNÜN TÜM SATIŞLARI SİLİNECEKTİR !!!", "SİLME İŞLEMİ", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    if (SQLClientConnect.CRUD("delete from Product where ID=" + ID + "", SQLClientConnect.Db))
                    {
                        XtraMessageBox.Show("ÜRÜN SİLME İŞLEMİ BAŞARILI !!", "BAŞARILI", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        Clear();
                        gridControl1.DataSource = SQLClientConnect.GenericList("SELECT PRODUCT.ID,BARCODENO AS 'BARKOD_NO',CATEGORYNAME AS 'KATEGORI_ADI',PRODUCTNAME AS 'URUN_ADI',AMOUNT  AS 'MIKTAR',SALESPRICE  AS 'SATIS_FIYATI',Tax as 'KDV',ProductDescription as 'ACIKLAMA',PICTURE,_DATE AS 'KAYIT_TARIHI' FROM PRODUCT INNER JOIN CATEGORY ON CATEGORYID=CATEGORY.ID", SQLClientConnect.Db);
                    }
                }
            }
        }
        private void ProductUpdate()
        {
            if (string.IsNullOrEmpty(ID))
                XtraMessageBox.Show("GÜNCELLEMEK İSTEDİĞİNİZ ÜRÜNÜ LİSTEDEN SEÇİNİZ !!", "HATALI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            else
            {
                if (DatabaseControl.ProductControl(Txt_BarcodeNo, Lk_Category, Txt_ProductName, Cmb_Tax, ID))
                {
                    if (DialogResult.Yes == XtraMessageBox.Show("ÜRÜN GÜNCELLEME İŞLEMİ YAPMAK İSTİYOR MUSUNUZ ?", "GÜNCELLEME İŞLEMİ", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        if (SQLClientConnect.CRUD(
                            "update Product set BarcodeNo='" + Txt_BarcodeNo.Text.Trim() + "',CategoryID=" +
                            Lk_Category.EditValue + ",ProductName='" + Txt_ProductName.Text.Trim() + "',Amount=" +
                            Nmr_Amount.Value.ToString().Replace(',', '.') + ",SalesPrice=" + Nmr_SalesPrice.Value.ToString().Replace(',', '.') + ",Tax=" + Cmb_Tax.Text + ",ProductDescription='" + Rch_Description.Text + "',Picture='" +
                            ImageConvert.ImageToBase64(pictureEdit1.Image, ImageFormat.Jpeg) + "' WHERE ID=" + ID + "",
                            SQLClientConnect.Db))
                        {
                            XtraMessageBox.Show("ÜRÜN GÜNCELLEME İŞLEMİ BAŞARILI !!", "BAŞARILI", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            Clear();
                            gridControl1.DataSource = SQLClientConnect.GenericList("SELECT PRODUCT.ID,BARCODENO AS 'BARKOD_NO',CATEGORYNAME AS 'KATEGORI_ADI',PRODUCTNAME AS 'URUN_ADI',AMOUNT  AS 'MIKTAR',SALESPRICE  AS 'SATIS_FIYATI',Tax as 'KDV',ProductDescription as 'ACIKLAMA',PICTURE,_DATE AS 'KAYIT_TARIHI' FROM PRODUCT INNER JOIN CATEGORY ON CATEGORYID=CATEGORY.ID", SQLClientConnect.Db);
                        }
                    }
                }
            }
        }
        private void Add()
        {
            if (DatabaseControl.ProductControl(Txt_BarcodeNo, Lk_Category, Txt_ProductName, Cmb_Tax, null))
            {
                if (DialogResult.Yes == XtraMessageBox.Show("ÜRÜN EKLEME İŞLEMİ YAPMAK İSTİYOR MUSUNUZ ?", "EKLEME İŞLEMİ", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    if (SQLClientConnect.CRUD("insert into Product (BarcodeNo,CategoryID,ProductName,Amount,SalesPrice,Tax,ProductDescription,Picture,_Date) values ('" + Txt_BarcodeNo.Text.Trim() + "'," + Lk_Category.EditValue + ",'" + Txt_ProductName.Text.Trim() + "'," + Nmr_Amount.Value.ToString().Replace(',', '.') + "," + Nmr_SalesPrice.Value.ToString().Replace(',', '.') + "," + Cmb_Tax.Text + ",'" + Rch_Description.Text + "','" + ImageConvert.ImageToBase64(pictureEdit1.Image, ImageFormat.Jpeg) + "','" + DateTime.Now + "')", SQLClientConnect.Db))
                    {
                        XtraMessageBox.Show("ÜRÜN EKLEME İŞLEMİ BAŞARILI !!", "BAŞARILI", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        Clear();
                        gridControl1.DataSource = SQLClientConnect.GenericList("SELECT PRODUCT.ID,BARCODENO AS 'BARKOD_NO',CATEGORYNAME AS 'KATEGORI_ADI',PRODUCTNAME AS 'URUN_ADI',AMOUNT  AS 'MIKTAR',SALESPRICE  AS 'SATIS_FIYATI',Tax as 'KDV',ProductDescription as 'ACIKLAMA',PICTURE,_DATE AS 'KAYIT_TARIHI' FROM PRODUCT INNER JOIN CATEGORY ON CATEGORYID=CATEGORY.ID", SQLClientConnect.Db);
                    }
                }
            }
        }
        private void Clear()
        {
            Txt_BarcodeNo.Focus();
            foreach (Control item in groupControl1.Controls)
            {
                if (item is TextBox)
                    item.Text = null;
            }
            Lk_Category.EditValue = null;
            pictureEdit1.Image = null;
            Nmr_Amount.Value = 0;
            Nmr_SalesPrice.Value = 1;
            Cmb_Tax.Text = null;
            ID = null;
            Rch_Description.Text = null;
        }
        private void Product_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
            else if (e.KeyCode == Keys.F2)
                Add();
            else if (e.KeyCode == Keys.F3)
                Delete();
            else if (e.KeyCode == Keys.F5)
                ProductUpdate();
        }
        private void Btn_Clear_Click(object sender, System.EventArgs e)
        {
            Clear();
        }
        private void Btn_Add_Click(object sender, System.EventArgs e)
        {
            Add();
        }
        private void Btn_Update_Click(object sender, System.EventArgs e)
        {
            ProductUpdate();
        }
        private void Btn_Delete_Click(object sender, System.EventArgs e)
        {
            Delete();
        }
        private void Product_Load(object sender, System.EventArgs e)
        {
            gridControl1.DataSource = SQLClientConnect.GenericList("SELECT PRODUCT.ID,BARCODENO AS 'BARKOD_NO',CATEGORYNAME AS 'KATEGORI_ADI',PRODUCTNAME AS 'URUN_ADI',AMOUNT  AS 'MIKTAR',SALESPRICE  AS 'SATIS_FIYATI',Tax as 'KDV',ProductDescription as 'ACIKLAMA',PICTURE,_DATE AS 'KAYIT_TARIHI' FROM PRODUCT INNER JOIN CATEGORY ON CATEGORYID=CATEGORY.ID", SQLClientConnect.Db);
            gridView1.Columns["Picture"].Visible = false;
            Lk_Category.Properties.DataSource =
                SQLClientConnect.GenericList("SELECT ID,CategoryName as 'KATEGORI_ADI' FROM Category", SQLClientConnect.Db);
            Lk_Category.Properties.ValueMember = "ID";
            Lk_Category.Properties.DisplayMember = "KATEGORI_ADI";
        }
        private void excelAlToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (fr.ShowDialog() == DialogResult.OK)
                DataExport.GridExport(gridControl1, fr.SelectedPath, "UrunListesi.xlsx");
        }
        private void pdfAlToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (fr.ShowDialog() == DialogResult.OK)
                DataExport.GridExport(gridControl1, fr.SelectedPath, "UrunListesi.pdf");
        }
        private void resimAlToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (fr.ShowDialog() == DialogResult.OK)
                DataExport.GridExport(gridControl1, fr.SelectedPath, "UrunListesi.html");
        }
        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            ID = gridView1.GetFocusedRowCellValue("ID").ToString();
            Txt_BarcodeNo.Text = gridView1.GetFocusedRowCellValue("BARKOD_NO").ToString();
            Lk_Category.Text = gridView1.GetFocusedRowCellValue("KATEGORI_ADI").ToString();
            Txt_ProductName.Text = gridView1.GetFocusedRowCellValue("URUN_ADI").ToString();
            Nmr_Amount.Value = (decimal)gridView1.GetFocusedRowCellValue("MIKTAR");
            Nmr_SalesPrice.Value = (decimal)gridView1.GetFocusedRowCellValue("SATIS_FIYATI");
            Cmb_Tax.Text = gridView1.GetFocusedRowCellValue("KDV").ToString();
            Rch_Description.Text = gridView1.GetFocusedRowCellValue("ACIKLAMA").ToString();
            pictureEdit1.Image = ImageConvert.Base64ToImage(gridView1.GetFocusedRowCellValue("Picture").ToString());
        }
    }
}