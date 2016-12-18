using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectSnowshoes
{
    class AllTheLittleIcons : PictureBox
    {
        Image image;
        int width;
        int height;

        // To avoid errors with unused variables, a small default constructor

        public AllTheLittleIcons()
        {
            width = 1;
            height = 1;
        }

        public AllTheLittleIcons(Image img)
            {
                image = img;
                width = image.Width;
                height = image.Height;
            }

            protected override void OnPaint(PaintEventArgs e)
            {
                e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                e.Graphics.DrawImage(
                image,
                new Rectangle(290, 250, (int)(0.6 * width), (int)(0.6 * height)),
                                // destination rectangle 
                0,
                0,           // upper-left corner of source rectangle
                width,       // width of source rectangle
                height,      // height of source rectangle
                GraphicsUnit.Pixel);
            }
    }
}
