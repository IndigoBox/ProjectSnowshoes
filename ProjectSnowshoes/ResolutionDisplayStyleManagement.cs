using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSnowshoes
{
    class ResolutionDisplayStyleManagement
    {
        private String resolutionReturn()
        {
            int screenX = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width;
            int screenY = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Height;

            if (screenX == 1366 && screenY == 768)
            {
                return "1366x768";
            }
            else if (screenX == 1280 && screenY == 720)
            {
                return "1280x720";
            }
            else if (screenX == 3200 && screenY == 1800)
            {
                return "3200x1800";
            }
            else
            {
                return "unknown";
            }

            // This part of code was written for The Bridge build, yet does not need to be used as of yet (10/15/2014).

        }
    }
}
