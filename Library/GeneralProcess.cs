using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public static class GeneralProcess
    {
        public static byte[] imageResize(Image img)
        {
            Size s = new Size(128, 128);
            MemoryStream Sonuc = new MemoryStream();
            Image sonimg;
            sonimg = (Image)(new Bitmap(img, s));
            sonimg.Save(Sonuc, img.RawFormat);
            return Sonuc.ToArray();
        }
        public static string maskedtextOzelKarakterSil(string str)
        {
            str = str.Replace("(", string.Empty);
            str = str.Replace(")", string.Empty);
            str = str.Replace("-", string.Empty);
            str = str.Replace("_", string.Empty);
            str = str.Replace(" ", string.Empty);

            return str;
        }
    }
}
