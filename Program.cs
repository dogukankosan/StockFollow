using StockFollow_Up.Forms;
using System;
using System.Windows.Forms;
namespace StockFollow_Up
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Home());
        }
    }
}