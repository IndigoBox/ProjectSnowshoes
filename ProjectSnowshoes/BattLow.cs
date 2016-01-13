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
    public partial class BattLow : Form
    {
        public BattLow()
        {
            InitializeComponent();
        }

        private void BattLow_Load(object sender, EventArgs e)
        {
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Left = 0;
            this.Top = Screen.PrimaryScreen.Bounds.Height - this.Height;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
