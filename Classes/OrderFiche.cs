using DevExpress.XtraEditors;
using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace StockFollow_Up.Classes
{
    internal class OrderFiche
    {
        internal static string ID = default;
        internal static double Total = default;
        internal static string OrderIDReturn(string sql, SQLiteConnection db)
        {
            string id = default;
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
                return null;
            }
            db.Close();
            db.Open();
            SQLiteCommand cmd2 = new("select ID from  OrderFiche order by ID desc limit 1", db);
            SQLiteDataReader rd = cmd2.ExecuteReader();
            while (rd.Read())
            {
                id = rd[0].ToString();
            }
            db.Close();
            return id;
        }
    }
}
