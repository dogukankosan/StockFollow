using DevExpress.XtraEditors;
using StockFollow_Up.Classes;
using System.Windows.Forms;

namespace StockFollow_Up.Forms
{
    public partial class Home : DevExpress.XtraEditors.XtraForm
    {
        public Home()
        {
            InitializeComponent();
        }
        private Customer cs;
        private Product pr;
        private Category ct;
        private Sales sl;
        private GeneralChart Gct;
        private DeleteSales uds;
        private CustomerBalance customerBalance;
        private GeneralGrid gr;
        private void Btn_Customer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cs is null || cs.IsDisposed)
            {
                cs = new() { MdiParent = this };
                cs.Show();
            }
        }
        private void Home_Load(object sender, System.EventArgs e)
        {

        }
        private void Btn_Product_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (pr is null || pr.IsDisposed)
            {
                pr = new() { MdiParent = this };
                pr.Show();
            }
        }
        private void Btn_Category_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ct is null || ct.IsDisposed)
            {
                ct = new() { MdiParent = this };
                ct.Show();
            }
        }
        private void Btn_Sales_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (sl is null || sl.IsDisposed)
            {
                sl = new() { MdiParent = this };
                sl.Show();
            }
        }
        private void Btn_CustomerChart_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Gct is null || Gct.IsDisposed)
            {
                Gct = new() { MdiParent = this };
                Gct.sql = "select CustomerName AS 'MUSTERI_ADI',CAST(Balance as double) as 'BAKIYE' from Customer where Balance>0 order by Balance desc limit 5";
                Gct.Show();
            }
        }
        private void Btn_BackUp_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FolderBrowserDialog fr = new();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                if (!string.IsNullOrEmpty(fr.SelectedPath))
                {
                    SQLClientConnect.Backup(fr.SelectedPath);
                    XtraMessageBox.Show("YEDEK ALMA İŞLEMİ BAŞARILI !!", "BAŞARILI", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                    XtraMessageBox.Show("YEDEK ALMA İŞLEMİ BAŞARISIZ YOL SEÇİLMEDİ !!", "BAŞARISIZ", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
        }
        private void BtnDelete_Sales_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (uds is null || uds.IsDisposed)
            {
                uds = new() { MdiParent = this };
                uds.Show();
            }
        }
        private void Btn_ProductChart_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Gct is null || Gct.IsDisposed)
            {
                Gct = new () {MdiParent = this};
                Gct.sql =
                    "select ProductName,sum(OrderLine.Amount) from OrderLine\r\ninner join Product on Product.ID=OrderLine.ProductID\r\ngroup by ProductName\r\norder by sum(OrderLine.Amount) desc";
                Gct.Show();
            }
        }
        private void Btn_CustomerSales_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (customerBalance is null || customerBalance.IsDisposed)
            {
                customerBalance = new () {MdiParent = this};
                customerBalance.Show();
            }
        }
        private void Btn_MailUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MailAdd mr = new ();
            mr.ShowDialog();
        }
        private void Btn_CategoryList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gr is null || gr.IsDisposed)
            {
                gr = new() { MdiParent = this };
                gr.sql = "select CategoryName as 'KATEGORI_ADI',count(OrderLine.ProductID) as 'MIKTAR' from OrderLine\r\n inner join Product on Product.ID=OrderLine.ProductID \r\n inner join Category on Category.ID=Product.CategoryID\r\n group by CategoryName \r\n order by count(OrderLine.ProductID) desc\r\n \r\n \r\n";
                gr.Show();
            }
        }
        private void Btn_ProductAmount_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gr is null || gr.IsDisposed)
            {
                gr = new () {MdiParent = this};
                gr.sql = "select  Product.ID,BarcodeNo as 'BARKOD_NO',CategoryName as 'KATEGORI_ADI',ProductName AS 'URUN_ADI',Amount as 'MIKTAR',SalesPrice AS 'SATIS_FIYATI',Tax as 'VERGI',ProductDescription AS 'ACIKLAMA',_Date as 'KAYIT_TARIHI' from Product\r\ninner join Category on Category.ID=Product.CategoryID\r\nwhere Amount<10\r\norder by Amount";
                gr.Show();
            }
        }
        private void Btn_CompanyInfo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CompanyInfo cmd = new ();
            cmd.ShowDialog();
        }
    }
}