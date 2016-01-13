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
    public partial class ThanksScn9A : Form
    {
        public ThanksScn9A()
        {
            InitializeComponent();
        }

        private void thanksAgain_Tick(object sender, EventArgs e)
        {
            String toConv = "#" + DateTime.Now.ToString("HH") + DateTime.Now.ToString("MM") + DateTime.Now.ToString("ss");
            time.Text = DateTime.Now.ToLongTimeString();
            date.Text = DateTime.Now.ToLongDateString();
            this.BackColor = ColorTranslator.FromHtml(toConv);
        }
    }
}
