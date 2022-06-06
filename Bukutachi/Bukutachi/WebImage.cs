using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Bukutachi
{
    class WebImage
    {
        public static Image fromUrl(string url)
        {
            HttpWebRequest wreq = (HttpWebRequest)HttpWebRequest.Create(url);

            using (HttpWebResponse wres = (HttpWebResponse)wreq.GetResponse())
            {
                using (Stream stream = wres.GetResponseStream())
                {
                    return Image.FromStream(stream);
                }
            }
        }

        public static Image resizeImage(Image i, int nw, int nh)
        {
            Bitmap b = new Bitmap(nw, nh);

            using (var graphic = Graphics.FromImage(b))
            {
                graphic.InterpolationMode = InterpolationMode.Default;
                graphic.SmoothingMode = SmoothingMode.None;
                graphic.PixelOffsetMode = PixelOffsetMode.None;
                graphic.CompositingQuality = CompositingQuality.HighSpeed;
                graphic.DrawImage(i, 0, 0, nw, nh);
            }
            return b;
        }

        public static Image resizeHeightImage(Image i, int nw) {
            int w = nw;
            int h = (int)Math.Round(nw * i.Height * 1.0 / i.Width);
            Console.WriteLine($"{w} - {h}");
            Bitmap b = new Bitmap(w, h);

            using (var graphic = Graphics.FromImage(b)) {
                graphic.InterpolationMode = InterpolationMode.Default;
                graphic.SmoothingMode = SmoothingMode.None;
                graphic.PixelOffsetMode = PixelOffsetMode.None;
                graphic.CompositingQuality = CompositingQuality.HighSpeed;
                graphic.DrawImage(i, 0, 0, w, h);
            }
            return b;
        }

        public static Image resizeWidthImage(Image i, int nh) {
            int h = nh;
            int w = (int)Math.Round(nh * i.Width * 1.0 / i.Height);
            Console.WriteLine($"{w} - {h}");
            Bitmap b = new Bitmap(w, h);

            using (var graphic = Graphics.FromImage(b)) {
                graphic.InterpolationMode = InterpolationMode.Default;
                graphic.SmoothingMode = SmoothingMode.None;
                graphic.PixelOffsetMode = PixelOffsetMode.None;
                graphic.CompositingQuality = CompositingQuality.HighSpeed;
                graphic.DrawImage(i, 0, 0, w, h);
            }
            return b;
        }
    }
}