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
    public partial class SearchFromSlidingBar : Form
    {
        int slidingBarWidthTakenIn;
        
        public SearchFromSlidingBar(int slidingBarWidth)
        {
            InitializeComponent();
            slidingBarWidthTakenIn = slidingBarWidth;
        }

        private void query_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //or if you press your enter key on your keyboard
                searchBrowser.Visible = true;
                searchBrowser.Navigate("http://google.com/search?q=" + query.Text);
            }
        }

        private void SearchFromSlidingBar_Load(object sender, EventArgs e)
        {
            this.Left = slidingBarWidthTakenIn;
            this.Height = 615;
            this.Top = Screen.PrimaryScreen.WorkingArea.Height - 615;
            this.Width = 615;

            query.ForeColor = Color.FromName(Properties.Settings.Default.custColor[Properties.Settings.Default.whoIsThisCrazyDoge]);
        }

        private void inTheaters_Tick(object sender, EventArgs e)
        {
            if (!this.ContainsFocus)
            {
                this.Close();
            }
        }
    }
}
