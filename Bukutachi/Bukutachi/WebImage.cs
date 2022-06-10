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
            if(url.Length > 0) {
                HttpWebRequest wreq = (HttpWebRequest)HttpWebRequest.Create(url);

                using (HttpWebResponse wres = (HttpWebResponse)wreq.GetResponse())
                {
                    using (Stream stream = wres.GetResponseStream())
                    {
                        return Image.FromStream(stream);
                    }
                }
            }
            return null;
        }

        public static Image resizeImage(Image i, int nw, int nh)
        {
            if(i != null) {
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
            return null;
        }

        public static Image resizeHeightImage(Image i, int nw) {
            if(i != null) {
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
            return null;
        }

        public static Image resizeWidthImage(Image i, int nh) {
            if(i != null) {
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
            return null;
        }
    }
}