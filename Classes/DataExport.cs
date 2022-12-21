using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using System;
using System.Windows.Forms;
using DevExpress.XtraCharts;

namespace StockFollow_Up.Classes
{
    internal class DataExport
    {
        internal static void ChartExport(ChartControl ct, string path, string formatName)
        {
            if (!string.IsNullOrEmpty(path))
            {
                try
                {
                    if (formatName.Contains("pdf"))
                    {
                        ct.ExportToPdf(path + "\\" + formatName);
                        XtraMessageBox.Show("PDF ALMA İŞLEMİ BAŞARILI !!", "BAŞARILI", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    else if (formatName.Contains("xlsx"))
                    {
                        ct.ExportToXlsx(path + "\\" + formatName);
                        XtraMessageBox.Show("EXCEL ALMA İŞLEMİ BAŞARILI !!", "BAŞARILI", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    else if (formatName.Contains("html"))
                    {
                        ct.ExportToHtml(path + "\\" + formatName);
                        XtraMessageBox.Show("RESİM ALMA İŞLEMİ BAŞARILI !!", "BAŞARILI", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    else
                        XtraMessageBox.Show("DIŞARI AKTARMA İŞLEMİ HATALI !!", "HATALI", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                }
                catch (Exception e)
                {
                    XtraMessageBox.Show(e.Message, "HATALI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        internal static void GridExport(GridControl gc, string path, string formatName)
        {
            if (!string.IsNullOrEmpty(path))
            {
                try
                {
                    if (formatName.Contains("pdf"))
                    {
                        gc.ExportToPdf(path + "\\" + formatName);
                        XtraMessageBox.Show("PDF ALMA İŞLEMİ BAŞARILI !!", "BAŞARILI", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    else if (formatName.Contains("xlsx"))
                    {
                        gc.ExportToXlsx(path + "\\" + formatName);
                        XtraMessageBox.Show("EXCEL ALMA İŞLEMİ BAŞARILI !!", "BAŞARILI", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    else if (formatName.Contains("html"))
                    {
                        gc.ExportToHtml(path + "\\" + formatName);
                        XtraMessageBox.Show("RESİM ALMA İŞLEMİ BAŞARILI !!", "BAŞARILI", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    else
                        XtraMessageBox.Show("DIŞARI AKTARMA İŞLEMİ HATALI !!", "HATALI", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                }
                catch (Exception e)
                {
                    XtraMessageBox.Show(e.Message, "HATALI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}