using System.Windows.Forms;
using DevExpress.XtraEditors;
using StockFollow_Up.Classes;

namespace StockFollow_Up.Forms
{
    public partial class DeleteSales : DevExpress.XtraEditors.XtraForm
    {
        public DeleteSales()
        {
            InitializeComponent();
        }
        private readonly FolderBrowserDialog fr = new();
        private void Delete()
        {
            if (gridView1.GetRowCellValue(0,"ID") is not null)
            {
                if (XtraMessageBox.Show("SEÇİLİ KAYIT SİPARİŞİ SİLİNECEKTİR EMİN MİSİNİZ ?", "SİLME İŞLEMİ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (SQLClientConnect.CRUD("delete from OrderFiche where ID=" + gridView1.GetFocusedRowCellValue("ID") + "", SQLClientConnect.Db))
                    {
                        XtraMessageBox.Show("SİPARİŞ SİLME İŞLEMİ BAŞARILI !!", "SİLME İŞLEMİ", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        gridControl1.DataSource = SQLClientConnect.GenericList("select OrderFiche.ID,Customer.CustomerName as 'MUSTERI_ADI',OrderFiche._Date as 'SATIS_TARIHI',Total as 'TOPLAM_TUTAR' from OrderFiche\r\ninner join Customer on Customer.ID=OrderFiche.CustomerID", SQLClientConnect.Db);
                    }
                    else
                        XtraMessageBox.Show("SİLME İŞLEMİ HATALI KAYIT SİLİNEMEDİ !!", "HATALI", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                }
            }
            else
                XtraMessageBox.Show("LÜTFEN SİLİNECEK KAYDI LİSTEDEN SEÇİNİZ !!", "HATALI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
        }
        private void UpdateDeleteSales_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }
        private void UpdateDeleteSales_Load(object sender, System.EventArgs e)
        {
            gridControl1.DataSource = SQLClientConnect.GenericList("select OrderFiche.ID,Customer.CustomerName as 'MUSTERI_ADI',OrderFiche._Date as 'SATIS_TARIHI',Total as 'TOPLAM_TUTAR' from OrderFiche\r\ninner join Customer on Customer.ID=OrderFiche.CustomerID", SQLClientConnect.Db);
        }
        private void excelAlToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (fr.ShowDialog() == DialogResult.OK)
                DataExport.GridExport(gridControl1, fr.SelectedPath, "Satislar.xlsx");
        }
        private void pdfAlToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (fr.ShowDialog() == DialogResult.OK)
                DataExport.GridExport(gridControl1, fr.SelectedPath, "Satislar.pdf");
        }
        private void resimAlToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (fr.ShowDialog() == DialogResult.OK)
                DataExport.GridExport(gridControl1, fr.SelectedPath, "Satislar.html");
        }
        private void seçiliKaydıSatışıSilToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Delete();
        }
        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            GeneralGrid gr = new ();
            gr.sql = "select  ProductName as 'URUN_ADI',OrderLine.Amount as 'MIKTAR',Sales as 'SATIS_FIYATI',OrderLine.Tax as 'VERGI',Total as 'TOPLAM_TUTAR',OrderLine.ProductDescription as 'ACIKLAMA' from OrderLine inner join Product on Product.ID=OrderLine.ProductID where OrderLine.FicheID = "+gridView1.GetFocusedRowCellValue("ID")+"";
            gr.ShowDialog();
        }
    }
}