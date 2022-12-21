using System;

namespace StockFollow_Up.Classes
{
    internal class Encription
    {
        internal static string Enc(string text)
        {
            char[] array = text.ToCharArray();
            string password = string.Empty;
            foreach (char item in array)
            {
                password += Convert.ToChar(item + 35);
            }
            return password;
        }
        internal static string Desc(string text)
        {
            char[] array = text.ToCharArray();
            string password = string.Empty;
            foreach (char item in array)
            {
                password += Convert.ToChar(item - 35);
            }
            return password;
        }
    }
}