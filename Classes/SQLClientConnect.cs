using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace StockFollow_Up.Classes
{
    internal class SQLClientConnect
    {
        internal static readonly SQLiteConnection Db = new($"Data source={Application.StartupPath}\\Database\\StockFollow.db;Versiyon=3");
        internal static DataTable GenericList(string sql, SQLiteConnection db)
        {
            try
            {
                SQLiteDataAdapter da = new(sql, db);
                DataSet ds = new();
                da.Fill(ds);
                return ds.Tables[0];
            }
            catch (Exception e)
            {
                XtraMessageBox.Show("HATALI LİSTELEME İŞLEMİ !!", e.Message, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return null;
            }
        }
        internal static bool CRUD(string sql, SQLiteConnection db)
        {
            db.Open();
            SQLiteCommand cmd = new(sql, db);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                XtraMessageBox.Show(e.Message, "HATALI DATABASE İŞLEMİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                db.Close();
                return false;
            }
            db.Close();
            return true;
        }
        internal static void ChartList(string sql, ChartControl ct)
        {
            Db.Open();
            SQLiteCommand cmd = new(sql, Db);
            SQLiteDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                ct.Series[0].Points.AddPoint(rd[0].ToString(), double.Parse(rd[1].ToString()));
            }
            Db.Close();
        }
        internal static void Backup(string strDestination)
        {
            using (SQLiteConnection location = new($"Data source={Application.StartupPath}\\Database\\StockFollow.db;Versiyon=3"))
            using (SQLiteConnection destination = new(string.Format(@"Data Source={0}\\StockFollow.db; Version=3;", strDestination)))
            {
                location.Open();
                destination.Open();
                location.BackupDatabase(destination, "main", "main", -1, null, 0);
            }
        }
    }
}