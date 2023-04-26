using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8_PredictPrice.Operatons
{
    class ScreenShot
    {
        readonly string _filePath;
        public ScreenShot(string filePath)
        {
            _filePath = filePath;
        }

        public void Capture(string filename)
        {
            string filePath = _filePath + filename;
            // Create a bitmap to hold the screenshot
            using (Bitmap bitmap = new(1920, 1080))
            {
                // Create a graphics object from the bitmap
                using (Graphics graphics = Graphics.FromImage(bitmap))
                {
                    // Copy the screen to the bitmap
                    graphics.CopyFromScreen(Point.Empty, Point.Empty, new Size(1920, 1080));
                }
                Rectangle bounds = new Rectangle(0, 0, 1920, 1080);
                using (Bitmap croppedBitmap = bitmap.Clone(bounds, bitmap.PixelFormat))
                {
                    // Save the cropped bitmap to a file
                    croppedBitmap.Save(filePath, ImageFormat.Png);
                }
            }
        }
    }
}
