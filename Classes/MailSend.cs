using System;
using System.Data.SQLite;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockFollow_Up.Classes
{
    internal class MailSend
    {
        internal static async Task<bool> MailSendPassword(string fromMail, string vkn)
        {
            string[] myInfo = new string[4];
            SQLClientConnect.Db.Open();
            SQLiteCommand cmd = new("select * from Mail where ID=1", SQLClientConnect.Db);
            SQLiteDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                myInfo[0] = rd[1].ToString();
                myInfo[1] = rd[2].ToString();
                myInfo[2] = rd[3].ToString();
                myInfo[3] = rd[4].ToString();
            }
            SQLClientConnect.Db.Close();
            MailMessage mail = new();
            Attachment at;
            mail.To.Add(new MailAddress(fromMail));
            mail.From = new MailAddress(myInfo[0]);
            mail.Subject = "MUTABAKAT MEKTUBU";
            try
            {
                at = new(Application.StartupPath + "\\Temp\\" + vkn + ".pdf");
                mail.Attachments.Add(at);
            }
            catch (Exception)
            {
                return false;
            }
            using (SmtpClient smtp = new(myInfo[2], int.Parse(myInfo[3])))
            {
                smtp.Credentials = new NetworkCredential(myInfo[0], Encription.Desc(myInfo[1]));
                smtp.EnableSsl = true;
                try
                {
                    await smtp.SendMailAsync(mail);
                }
                catch (Exception)
                {
                    mail.To.Clear();
                    mail.Attachments.Clear();
                    at.Dispose();
                    return false;
                }
            }
            mail.To.Clear();
            mail.Attachments.Clear();
            at.Dispose();
            return true;
        }
    }
}