
namespace StockFollow_Up.Forms
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.Btn_Customer = new DevExpress.XtraBars.BarButtonItem();
            this.Btn_Product = new DevExpress.XtraBars.BarButtonItem();
            this.Btn_Category = new DevExpress.XtraBars.BarButtonItem();
            this.Btn_Sales = new DevExpress.XtraBars.BarButtonItem();
            this.Btn_CustomerChart = new DevExpress.XtraBars.BarButtonItem();
            this.Btn_BackUp = new DevExpress.XtraBars.BarButtonItem();
            this.BtnDelete_Sales = new DevExpress.XtraBars.BarButtonItem();
            this.Btn_SalesList = new DevExpress.XtraBars.BarButtonItem();
            this.Btn_ProductChart = new DevExpress.XtraBars.BarButtonItem();
            this.Btn_CustomerSales = new DevExpress.XtraBars.BarButtonItem();
            this.Btn_ProductAmount = new DevExpress.XtraBars.BarButtonItem();
            this.Btn_MailUpdate = new DevExpress.XtraBars.BarButtonItem();
            this.Btn_CategoryList = new DevExpress.XtraBars.BarButtonItem();
            this.Btn_CompanyInfo = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup9 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup10 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup12 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage5 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup11 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup13 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.Btn_Customer,
            this.Btn_Product,
            this.Btn_Category,
            this.Btn_Sales,
            this.Btn_CustomerChart,
            this.Btn_BackUp,
            this.BtnDelete_Sales,
            this.Btn_SalesList,
            this.Btn_ProductChart,
            this.Btn_CustomerSales,
            this.Btn_ProductAmount,
            this.Btn_MailUpdate,
            this.Btn_CategoryList,
            this.Btn_CompanyInfo});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 15;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3,
            this.ribbonPage4,
            this.ribbonPage5});
            this.ribbonControl1.Size = new System.Drawing.Size(1024, 177);
            // 
            // Btn_Customer
            // 
            this.Btn_Customer.Caption = "MÜŞTERİ EKLE-SİL-GÜNCELLE";
            this.Btn_Customer.Id = 1;
            this.Btn_Customer.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Customer.ImageOptions.Image")));
            this.Btn_Customer.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Btn_Customer.ImageOptions.LargeImage")));
            this.Btn_Customer.Name = "Btn_Customer";
            this.Btn_Customer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Btn_Customer_ItemClick);
            // 
            // Btn_Product
            // 
            this.Btn_Product.Caption = "ÜRÜN EKLE-SİL-GÜNCELLE";
            this.Btn_Product.Id = 2;
            this.Btn_Product.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Btn_Product.ImageOptions.SvgImage")));
            this.Btn_Product.Name = "Btn_Product";
            this.Btn_Product.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Btn_Product_ItemClick);
            // 
            // Btn_Category
            // 
            this.Btn_Category.Caption = "KATEGORİ EKLE-SİL-GÜNCELLE";
            this.Btn_Category.Id = 3;
            this.Btn_Category.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Btn_Category.ImageOptions.SvgImage")));
            this.Btn_Category.Name = "Btn_Category";
            this.Btn_Category.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Btn_Category_ItemClick);
            // 
            // Btn_Sales
            // 
            this.Btn_Sales.Caption = "SATIŞ YAP";
            this.Btn_Sales.Id = 4;
            this.Btn_Sales.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Sales.ImageOptions.Image")));
            this.Btn_Sales.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Btn_Sales.ImageOptions.LargeImage")));
            this.Btn_Sales.Name = "Btn_Sales";
            this.Btn_Sales.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Btn_Sales_ItemClick);
            // 
            // Btn_CustomerChart
            // 
            this.Btn_CustomerChart.Caption = "EN BORÇLU 5 MÜŞTERİ";
            this.Btn_CustomerChart.Id = 5;
            this.Btn_CustomerChart.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_CustomerChart.ImageOptions.Image")));
            this.Btn_CustomerChart.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Btn_CustomerChart.ImageOptions.LargeImage")));
            this.Btn_CustomerChart.Name = "Btn_CustomerChart";
            this.Btn_CustomerChart.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Btn_CustomerChart_ItemClick);
            // 
            // Btn_BackUp
            // 
            this.Btn_BackUp.Caption = "YEDEK AL";
            this.Btn_BackUp.Id = 6;
            this.Btn_BackUp.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_BackUp.ImageOptions.Image")));
            this.Btn_BackUp.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Btn_BackUp.ImageOptions.LargeImage")));
            this.Btn_BackUp.Name = "Btn_BackUp";
            this.Btn_BackUp.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Btn_BackUp_ItemClick);
            // 
            // BtnDelete_Sales
            // 
            this.BtnDelete_Sales.Caption = "SATIŞ LİSTESİ-SİL";
            this.BtnDelete_Sales.Id = 7;
            this.BtnDelete_Sales.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnDelete_Sales.ImageOptions.SvgImage")));
            this.BtnDelete_Sales.Name = "BtnDelete_Sales";
            this.BtnDelete_Sales.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnDelete_Sales_ItemClick);
            // 
            // Btn_SalesList
            // 
            this.Btn_SalesList.Caption = "SATIŞ LİSTESİ";
            this.Btn_SalesList.Id = 8;
            this.Btn_SalesList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_SalesList.ImageOptions.Image")));
            this.Btn_SalesList.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Btn_SalesList.ImageOptions.LargeImage")));
            this.Btn_SalesList.Name = "Btn_SalesList";
            // 
            // Btn_ProductChart
            // 
            this.Btn_ProductChart.Caption = "EN ÇOK SATIŞ YAPILAN ÜRÜNLER";
            this.Btn_ProductChart.Id = 9;
            this.Btn_ProductChart.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_ProductChart.ImageOptions.Image")));
            this.Btn_ProductChart.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Btn_ProductChart.ImageOptions.LargeImage")));
            this.Btn_ProductChart.Name = "Btn_ProductChart";
            this.Btn_ProductChart.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Btn_ProductChart_ItemClick);
            // 
            // Btn_CustomerSales
            // 
            this.Btn_CustomerSales.Caption = "MÜŞTERİ ÖDEME İŞLEMİ";
            this.Btn_CustomerSales.Id = 10;
            this.Btn_CustomerSales.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_CustomerSales.ImageOptions.Image")));
            this.Btn_CustomerSales.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Btn_CustomerSales.ImageOptions.LargeImage")));
            this.Btn_CustomerSales.Name = "Btn_CustomerSales";
            this.Btn_CustomerSales.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Btn_CustomerSales_ItemClick);
            // 
            // Btn_ProductAmount
            // 
            this.Btn_ProductAmount.Caption = "KRİTİK SEVİYEDE ÜRÜNLER";
            this.Btn_ProductAmount.Id = 11;
            this.Btn_ProductAmount.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_ProductAmount.ImageOptions.Image")));
            this.Btn_ProductAmount.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Btn_ProductAmount.ImageOptions.LargeImage")));
            this.Btn_ProductAmount.Name = "Btn_ProductAmount";
            this.Btn_ProductAmount.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Btn_ProductAmount_ItemClick);
            // 
            // Btn_MailUpdate
            // 
            this.Btn_MailUpdate.Caption = "MAİL TANIMLAMA";
            this.Btn_MailUpdate.Id = 12;
            this.Btn_MailUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_MailUpdate.ImageOptions.Image")));
            this.Btn_MailUpdate.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Btn_MailUpdate.ImageOptions.LargeImage")));
            this.Btn_MailUpdate.Name = "Btn_MailUpdate";
            this.Btn_MailUpdate.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Btn_MailUpdate_ItemClick);
            // 
            // Btn_CategoryList
            // 
            this.Btn_CategoryList.Caption = "EN ÇOK SATIŞ YAPILAN KATEGORİ";
            this.Btn_CategoryList.Id = 13;
            this.Btn_CategoryList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_CategoryList.ImageOptions.Image")));
            this.Btn_CategoryList.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Btn_CategoryList.ImageOptions.LargeImage")));
            this.Btn_CategoryList.Name = "Btn_CategoryList";
            this.Btn_CategoryList.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Btn_CategoryList_ItemClick);
            // 
            // Btn_CompanyInfo
            // 
            this.Btn_CompanyInfo.Caption = "ŞİRKET BİLGİLERİ";
            this.Btn_CompanyInfo.Id = 14;
            this.Btn_CompanyInfo.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Btn_CompanyInfo.ImageOptions.SvgImage")));
            this.Btn_CompanyInfo.Name = "Btn_CompanyInfo";
            this.Btn_CompanyInfo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Btn_CompanyInfo_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup9});
            this.ribbonPage1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage1.ImageOptions.Image")));
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "MÜŞTERİ İŞLEMLERİ";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.Btn_Customer);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup9
            // 
            this.ribbonPageGroup9.ItemLinks.Add(this.Btn_CustomerSales);
            this.ribbonPageGroup9.Name = "ribbonPageGroup9";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup4});
            this.ribbonPage2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage2.ImageOptions.Image")));
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "STOK İŞLEMLERİ";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.Btn_Product);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.Btn_Category);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3,
            this.ribbonPageGroup7});
            this.ribbonPage3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage3.ImageOptions.Image")));
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "SATIŞ İŞLEMLERİ";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.Btn_Sales);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.BtnDelete_Sales);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            // 
            // ribbonPage4
            // 
            this.ribbonPage4.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5,
            this.ribbonPageGroup8,
            this.ribbonPageGroup10,
            this.ribbonPageGroup12});
            this.ribbonPage4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage4.ImageOptions.Image")));
            this.ribbonPage4.Name = "ribbonPage4";
            this.ribbonPage4.Text = "RAPOR";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.Btn_CustomerChart);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            // 
            // ribbonPageGroup8
            // 
            this.ribbonPageGroup8.ItemLinks.Add(this.Btn_ProductChart);
            this.ribbonPageGroup8.Name = "ribbonPageGroup8";
            // 
            // ribbonPageGroup10
            // 
            this.ribbonPageGroup10.ItemLinks.Add(this.Btn_ProductAmount);
            this.ribbonPageGroup10.Name = "ribbonPageGroup10";
            // 
            // ribbonPageGroup12
            // 
            this.ribbonPageGroup12.ItemLinks.Add(this.Btn_CategoryList);
            this.ribbonPageGroup12.Name = "ribbonPageGroup12";
            // 
            // ribbonPage5
            // 
            this.ribbonPage5.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup6,
            this.ribbonPageGroup11,
            this.ribbonPageGroup13});
            this.ribbonPage5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage5.ImageOptions.Image")));
            this.ribbonPage5.Name = "ribbonPage5";
            this.ribbonPage5.Text = "AYARLAR";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.Btn_BackUp);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            // 
            // ribbonPageGroup11
            // 
            this.ribbonPageGroup11.ItemLinks.Add(this.Btn_MailUpdate);
            this.ribbonPageGroup11.Name = "ribbonPageGroup11";
            // 
            // ribbonPageGroup13
            // 
            this.ribbonPageGroup13.ItemLinks.Add(this.Btn_CompanyInfo);
            this.ribbonPageGroup13.Name = "ribbonPageGroup13";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.xtraTabbedMdiManager1.Appearance.Options.UseBackColor = true;
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1024, 738);
            this.Controls.Add(this.ribbonControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("Home.IconOptions.Image")));
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ANA SAYFA";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem Btn_Customer;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem Btn_Product;
        private DevExpress.XtraBars.BarButtonItem Btn_Category;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem Btn_Sales;
        private DevExpress.XtraBars.BarButtonItem Btn_CustomerChart;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem Btn_BackUp;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.BarButtonItem BtnDelete_Sales;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.BarButtonItem Btn_SalesList;
        private DevExpress.XtraBars.BarButtonItem Btn_ProductChart;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        private DevExpress.XtraBars.BarButtonItem Btn_CustomerSales;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup9;
        private DevExpress.XtraBars.BarButtonItem Btn_ProductAmount;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup10;
        private DevExpress.XtraBars.BarButtonItem Btn_MailUpdate;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup11;
        private DevExpress.XtraBars.BarButtonItem Btn_CategoryList;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup12;
        private DevExpress.XtraBars.BarButtonItem Btn_CompanyInfo;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup13;
    }
}