using System;
using System.Drawing;
using System.IO;

namespace StockFollow_Up.Classes
{
    internal class ImageConvert
    {
        internal static string ImageToBase64(Image image, System.Drawing.Imaging.ImageFormat format)
        {
            MemoryStream ms = new();
            try
            {
                if (image is not null)
                {
                    image.Save(ms, format);
                    byte[] imageBytes = ms.ToArray();
                    ms.Dispose();
                    ms.Close();
                    return Convert.ToBase64String(imageBytes);
                }
            }
            catch (Exception)
            {
                ms.Dispose();
                ms.Close();
                return null;
            }
            ms.Dispose();
            ms.Close();
            return null;
        }
        internal static Image Base64ToImage(string base64String)
        {
            if (!string.IsNullOrEmpty(base64String))
            {
                byte[] imageBytes = Convert.FromBase64String(base64String);
                var ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
                Image image = Image.FromStream(ms, true);
                return image;
            }
            return null;
        }
    }
}