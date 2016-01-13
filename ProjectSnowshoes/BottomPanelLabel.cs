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
    public class BottomPanelLabel : Label
    {
            public BottomPanelLabel()
            {
            }

            protected override void OnPaint(PaintEventArgs e)
            {
                e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;

                e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;

                //e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                e.Graphics.DrawString(Text, Font, new SolidBrush(ForeColor), 5, 5);
            }
        
    }
}
