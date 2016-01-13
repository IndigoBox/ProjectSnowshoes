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
    public partial class VirtualKeyboardsForScience : Form
    {
        public VirtualKeyboardsForScience()
        {
            InitializeComponent();
        }

        private void VirtualKeyboardsForScience_Load(object sender, EventArgs e)
        {
            this.Top = Screen.PrimaryScreen.WorkingArea.Height - this.Height;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Left = 0;
        }
    }
}
