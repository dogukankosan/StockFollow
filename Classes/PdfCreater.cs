using DevExpress.XtraEditors;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Windows.Forms;

namespace StockFollow_Up.Classes
{
    internal class PdfCreater
    {
        internal static bool PdfCreat(string img, string companyName, string balance, string myCompany, string phone, string email, string fileName)
        {
            #region DOCUMENOPTIONS
            PdfDocument document = new();
            PdfPage page = document.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);
            page.Width = 620;
            page.Height = 580;
            #endregion
            #region FONTS
            XFont fontHeader = new("Verdana", 16, XFontStyle.Bold);
            XFont fontNotes = new("Verdana", 16, XFontStyle.Underline);
            XFont fontBody = new("Verdana", 10, XFontStyle.Regular);
            XFont fontLine = new("Verdana", 30, XFontStyle.Bold);
            XFont fontMut = new("Barlow", 25, XFontStyle.Bold);
            XFont fontMail = new("Barlow", 25, XFontStyle.Underline);
            #endregion
            #region BODY
            gfx.DrawImage(XImage.FromFile(img), 15, 50, 200, 70);
            gfx.DrawString("MUTABAKAT MEKTUBU", fontMut, XBrushes.Red,
                new XRect(-10, -185, page.Width, page.Height), XStringFormats.CenterRight);
            gfx.DrawString("______________________________", fontLine, XBrushes.Red,
                new XRect(0, -165, page.Width, page.Height), XStringFormats.CenterLeft);
            gfx.DrawString("Sayın,", fontHeader, XBrushes.Black,
                new XRect(10, -100, page.Width, page.Height), XStringFormats.CenterLeft);
            gfx.DrawString(companyName, fontBody, XBrushes.Black,
                new XRect(10, -75, page.Width, page.Height), XStringFormats.CenterLeft);
            gfx.DrawString("Şirketimizdeki cari hesabınız " + DateTime.Now.ToLongDateString() + " tarihi itibariyle " + balance + " TL bakiye vermektedir.", fontBody, XBrushes.Black,
                new XRect(10, -45, page.Width, page.Height), XStringFormats.CenterLeft);
            gfx.DrawString("Mutabık olup olmadığınızı bildirmenizi rica ederiz.", fontBody, XBrushes.Black,
                new XRect(10, -30, page.Width, page.Height), XStringFormats.CenterLeft);
            gfx.DrawString("Saygılarımızla.", fontBody, XBrushes.Black,
                new XRect(10, -20, page.Width, page.Height), XStringFormats.CenterLeft);
            gfx.DrawString("NOTLAR:", fontNotes, XBrushes.Red,
                new XRect(10, 20, page.Width, page.Height), XStringFormats.CenterLeft);
            gfx.DrawString("* Mutabakat veya itirazınızı 7 gün içinde bildirmediğiniz takdirde T.T.K’nun 94.maddesi gereğince mutabık sayılacağımızı", fontBody, XBrushes.Black,
                new XRect(10, 40, page.Width, page.Height), XStringFormats.CenterLeft);
            gfx.DrawString(" hatırlatırız.", fontBody, XBrushes.Black,
                new XRect(10, 50, page.Width, page.Height), XStringFormats.CenterLeft);
            gfx.DrawString("* Bakiyede mutabık olmadığımız takdirde hesap ekstrenizi göndermenizi rica ederiz.", fontBody, XBrushes.Black,
                new XRect(10, 70, page.Width, page.Height), XStringFormats.CenterLeft);
            gfx.DrawString("İLETİŞİM BİLGİLERİ:", fontNotes, XBrushes.Red,
                new XRect(10, 110, page.Width, page.Height), XStringFormats.CenterLeft);
            gfx.DrawString(myCompany, fontBody, XBrushes.Black,
                new XRect(10, 130, page.Width, page.Height), XStringFormats.CenterLeft);
            gfx.DrawString("TEL: " + phone + "", fontBody, XBrushes.Black,
                new XRect(10, 150, page.Width, page.Height), XStringFormats.CenterLeft);
            gfx.DrawString("E-MAIL: " + email + "", fontBody, XBrushes.Blue,
                new XRect(10, 170, page.Width, page.Height), XStringFormats.CenterLeft);
            gfx.DrawString("______________________________", fontLine, XBrushes.Red,
                new XRect(0, 180, page.Width, page.Height), XStringFormats.CenterLeft);
            gfx.DrawString("Sayın " + companyName + "", fontBody, XBrushes.Black,
                new XRect(10, 220, page.Width, page.Height), XStringFormats.CenterLeft);
            gfx.DrawString("...................... Tarihi itibariyle ..................... TL BORÇ/ALACAK bakiyesinde", fontBody, XBrushes.Black,
                new XRect(10, 240, page.Width, page.Height), XStringFormats.CenterLeft);
            gfx.DrawString("mutabık OLDUĞUMUZU / OLMADIĞIMIZI bildiririz.", fontBody, XBrushes.Black,
                new XRect(10, 260, page.Width, page.Height), XStringFormats.CenterLeft);
            gfx.DrawString("Kaşe/İmza", fontBody, XBrushes.Red,
                new XRect(-10, 240, page.Width, page.Height), XStringFormats.CenterRight);
            #endregion
            try
            {
                document.Save(Application.StartupPath + "\\Temp\\" + fileName + ".pdf");
            }
            catch (Exception e)
            {
                XtraMessageBox.Show(e.Message, "HATALI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}