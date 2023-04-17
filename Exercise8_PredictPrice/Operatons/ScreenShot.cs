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
        public static void Capture(string fileName)
        {
            string filePath = @"E:\Csharp Projects\College\ProjectsExportedData\Exercise8\" + fileName;
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
                // Save the bitmap to a file
            }
        }
    }
}
