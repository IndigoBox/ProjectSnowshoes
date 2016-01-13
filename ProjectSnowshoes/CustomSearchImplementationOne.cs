using ImageProcessor;
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
    public partial class CustomSearchImplementationOne : Form
    {
        int slidingBarWidthTakenIn;
        
        public CustomSearchImplementationOne(int recogWidth)
        {
            InitializeComponent();
            slidingBarWidthTakenIn = recogWidth;
        }

        private void CustomSearchImplementationOne_Load(object sender, EventArgs e)
        {
            this.Left = slidingBarWidthTakenIn;
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            this.Top = 0;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width - slidingBarWidthTakenIn;
            
            ImageFactory imgfBack = new ImageFactory();
            imgfBack.Load(@"C:\ProjectSnowshoes\System\Media\blackBackSearch.png");
            imgfBack.Tint(Color.FromName(Properties.Settings.Default.custColor[Properties.Settings.Default.whoIsThisCrazyDoge]));
            this.BackgroundImage = imgfBack.Image;




        }

        private void CustomSearchImplementationOne_Deactivate(object sender, EventArgs e)
        {
            Properties.Settings.Default.stayHere = false;
            Properties.Settings.Default.Save();
        }

        private void query_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
    }
}
