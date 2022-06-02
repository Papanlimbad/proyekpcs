using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Bukutachi {
    class WebImage {
        public static Image fromUrl(string url) {
            HttpWebRequest wreq = (HttpWebRequest)HttpWebRequest.Create(url);

            using (HttpWebResponse wres = (HttpWebResponse)wreq.GetResponse()) {
                using (Stream stream = wres.GetResponseStream()) {
                    return Image.FromStream(stream);
                }
            }
        }

        public static Image resizeImage(Image i, int nh) {
            int h = nh;
            int w = (int)Math.Round(i.Width * 1.0 * nh / i.Height);
            Bitmap b = new Bitmap(w, h);

            using (var graphic = Graphics.FromImage(b)) {
                graphic.InterpolationMode = InterpolationMode.Default;
                graphic.SmoothingMode = SmoothingMode.Default;
                graphic.PixelOffsetMode = PixelOffsetMode.Default;
                graphic.CompositingQuality = CompositingQuality.HighSpeed;
                graphic.DrawImage(i, 0, 0, w, h);
            }
            return b;
        }
    }
}
