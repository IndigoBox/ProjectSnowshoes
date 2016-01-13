using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectSnowshoes
{
    public partial class ThisMayFixTransparency : Form
    {
        int heightToUseInAdj;

        public ThisMayFixTransparency(int canYouBelieveThis)
        {
            InitializeComponent();

            heightToUseInAdj = canYouBelieveThis;

        }

        private void ThisMayFixTransparency_Load(object sender, EventArgs e)
        {
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Height = heightToUseInAdj - Screen.PrimaryScreen.WorkingArea.Height;
            this.Top = Screen.PrimaryScreen.WorkingArea.Height;
            this.Left = 0;
        }
    }
}
