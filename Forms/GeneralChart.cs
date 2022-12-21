using StockFollow_Up.Classes;
using System;
using System.Windows.Forms;

namespace StockFollow_Up.Forms
{
    public partial class GeneralChart : DevExpress.XtraEditors.XtraForm
    {
        public GeneralChart()
        {
            InitializeComponent();
        }
        internal string sql = default;
        private readonly FolderBrowserDialog fr = new();
        private void GeneralChart_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }
        private void excelAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fr.ShowDialog()==DialogResult.OK)
                DataExport.ChartExport(chartControl1, fr.SelectedPath, "ChartGrafik.xlsx");

        }
        private void pdfAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fr.ShowDialog() == DialogResult.OK)
                DataExport.ChartExport(chartControl1, fr.SelectedPath, "ChartGrafik.pdf");
        }
        private void resimAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fr.ShowDialog() == DialogResult.OK)
                DataExport.ChartExport(chartControl1, fr.SelectedPath, "ChartGrafik.html");
        }
        private void GeneralChart_Load(object sender, EventArgs e)
        {
            SQLClientConnect.ChartList(sql, chartControl1);
        }
    }
}