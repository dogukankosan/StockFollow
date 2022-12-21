using StockFollow_Up.Classes;
using System;
using System.Windows.Forms;

namespace StockFollow_Up.Forms
{
    public partial class GeneralGrid : DevExpress.XtraEditors.XtraForm
    {
        public GeneralGrid()
        {
            InitializeComponent();
        }
        private readonly FolderBrowserDialog fr = new();
        internal string sql = default;
        private void GeneralGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }
        private void excelAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fr.ShowDialog() == DialogResult.OK)
                DataExport.GridExport(gridControl1, fr.SelectedPath, "Liste.xlsx");
        }
        private void pdfAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fr.ShowDialog() == DialogResult.OK)
                DataExport.GridExport(gridControl1, fr.SelectedPath, "Liste.pdf");
        }
        private void resimAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fr.ShowDialog() == DialogResult.OK)
                DataExport.GridExport(gridControl1, fr.SelectedPath, "Liste.html");
        }
        private void GeneralGrid_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = SQLClientConnect.GenericList(sql, SQLClientConnect.Db);
        }
    }
}