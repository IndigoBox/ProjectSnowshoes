using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectSnowshoes
{
    public partial class CanWeMakeAHoverFormLikeThisIsThisLegal : Form
    {
        int heightApply;
        int widthApply;
        int newRadicals;
        String mainText;

        public CanWeMakeAHoverFormLikeThisIsThisLegal(int leftPos, int heightNonAmbig, int widthNonAmbig, string textProc)
        {
            InitializeComponent();
            newRadicals = leftPos;
            heightApply = heightNonAmbig;
            widthApply = widthNonAmbig;
            mainText = textProc;
            
        }

        private void CanWeMakeAHoverFormLikeThisIsThisLegal_Load(object sender, EventArgs e)
        {
            this.Height = heightApply;
            this.Width = widthApply;
            this.Left = newRadicals;

            this.BackColor = Color.FromName(Properties.Settings.Default.custColor[Properties.Settings.Default.whoIsThisCrazyDoge]);
            this.Top = Screen.PrimaryScreen.WorkingArea.Height - this.Height;
            
            label1.Font = new System.Drawing.Font(Properties.Settings.Default.fontsOfScience[Properties.Settings.Default.whoIsThisCrazyDoge], 14, FontStyle.Regular);
            label1.Text = mainText;

        }
    }
}
