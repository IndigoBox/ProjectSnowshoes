using ImageProcessor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectSnowshoes
{
    public partial class SlidingMenuBarPostEG : Form
    {

        Image j, k, l, m;

        public SlidingMenuBarPostEG()
        {
            InitializeComponent();
        }

        [DllImport("user32")]
        static extern bool AnimateWindow(IntPtr hwnd, int time, int flags);

        private void SlidingMenuBarPostEG_Load(object sender, EventArgs e)
        {
            this.Left = 0;
            this.Width = 145;
            this.Height = 615;
            this.Top = Screen.PrimaryScreen.WorkingArea.Height - 615;

            youYouSillyGooseDoge.BackgroundImage = Image.FromFile(Properties.Settings.Default.userimgacc_path[Properties.Settings.Default.whoIsThisCrazyDoge]);
            youYouSillyGooseDoge.Height = 145;
            youYouSillyGooseDoge.Width = 145;
            youYouSillyGooseDoge.Left = 0;

            settingsImage.Top = 155;
            turnOffImage.Top = 155;
            lockImage.Top = 155;

            /*appsPanel.Top = this.Height - 125;
            docPanel.Top = this.Height - 250;
            picPanel.Top = this.Height - 375;
            searchPanel.Top = this.Height - 500;*/

            appsPanel.Height = docPanel.Height = picPanel.Height = searchPanel.Height = 100;
            
            appsPanel.Top = 200;
            docPanel.Top = 305;
            picPanel.Top = 410;
            searchPanel.Top = 515;

            appsPanel.Width = docPanel.Width = picPanel.Width = searchPanel.Width = this.Width;
            
            appsText.ForeColor = Color.FromName(Properties.Settings.Default.custColor[Properties.Settings.Default.whoIsThisCrazyDoge]);
            docText.ForeColor = Color.FromName(Properties.Settings.Default.custColor[Properties.Settings.Default.whoIsThisCrazyDoge]);
            picText.ForeColor = Color.FromName(Properties.Settings.Default.custColor[Properties.Settings.Default.whoIsThisCrazyDoge]);
            searchText.ForeColor = Color.FromName(Properties.Settings.Default.custColor[Properties.Settings.Default.whoIsThisCrazyDoge]);

            ImageFactory tintItGood = new ImageFactory();
            tintItGood.Load(@"C:\ProjectSnowshoes\System\Media\SlidingMenuBar\XIco.png");
            tintItGood.Tint(Color.FromName(Properties.Settings.Default.custColor[Properties.Settings.Default.whoIsThisCrazyDoge]));
            turnOffImage.Image = tintItGood.Image;
            

            tintItGood.Load(@"C:\ProjectSnowshoes\System\Media\SlidingMenuBar\AppsIco.png");
            tintItGood.Tint(Color.FromName(Properties.Settings.Default.custColor[Properties.Settings.Default.whoIsThisCrazyDoge]));
            appsImg.Image = j = tintItGood.Image;

            tintItGood.Load(@"C:\ProjectSnowshoes\System\Media\SlidingMenuBar\DocsAgain.png");
            tintItGood.Tint(Color.FromName(Properties.Settings.Default.custColor[Properties.Settings.Default.whoIsThisCrazyDoge]));
            docImg.Image = k = tintItGood.Image;

            tintItGood.Load(@"C:\ProjectSnowshoes\System\Media\SlidingMenuBar\Images.png");
            tintItGood.Tint(Color.FromName(Properties.Settings.Default.custColor[Properties.Settings.Default.whoIsThisCrazyDoge]));
            picImg.Image = l = tintItGood.Image;

            tintItGood.Load(@"C:\ProjectSnowshoes\System\Media\SlidingMenuBar\Search.png");
            tintItGood.Tint(Color.FromName(Properties.Settings.Default.custColor[Properties.Settings.Default.whoIsThisCrazyDoge]));
            searchImg.Image = m = tintItGood.Image;

            tintItGood.Load(@"C:\ProjectSnowshoes\System\Media\SlidingMenuBar\GearSmallAww.png");
            tintItGood.Tint(Color.FromName(Properties.Settings.Default.custColor[Properties.Settings.Default.whoIsThisCrazyDoge]));
            settingsImage.Image = tintItGood.Image;

            tintItGood.Load(@"C:\ProjectSnowshoes\System\Media\SlidingMenuBar\Lock.png");
            tintItGood.Tint(Color.FromName(Properties.Settings.Default.custColor[Properties.Settings.Default.whoIsThisCrazyDoge]));
            lockImage.Image = tintItGood.Image;

            this.Left = 0;
            const int AW_SLIDE = 0X40000;
            const int AW_VER_POSITIVE = 0x8;

            // User32 and StackOverflow persons, you da real MVPs.
            AnimateWindow(this.Handle, 200, AW_SLIDE | AW_VER_POSITIVE);

        }

        private void searchPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void picPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void docPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void appsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void turnOffImage_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer");
            Application.Exit();
        }

        private void searchPanel_MouseHover(object sender, EventArgs e)
        {
            if (sender.Equals(searchPanel) || sender.Equals(searchImg) || sender.Equals(searchText))
            {
                searchPanel.BackColor = Color.FromName(Properties.Settings.Default.custColor[Properties.Settings.Default.whoIsThisCrazyDoge]);
                searchText.ForeColor = Color.White;
                searchImg.Image = Image.FromFile(@"C:\ProjectSnowshoes\System\Media\SlidingMenuBar\Search.png");
            }
            if (sender.Equals(picPanel) || sender.Equals(picImg) || sender.Equals(picText))
            {
                picPanel.BackColor = Color.FromName(Properties.Settings.Default.custColor[Properties.Settings.Default.whoIsThisCrazyDoge]);
                picText.ForeColor = Color.White;
                picImg.Image = Image.FromFile(@"C:\ProjectSnowshoes\System\Media\SlidingMenuBar\Images.png");
            }
            if (sender.Equals(docPanel) || sender.Equals(docImg) || sender.Equals(docText))
            {
                docPanel.BackColor = Color.FromName(Properties.Settings.Default.custColor[Properties.Settings.Default.whoIsThisCrazyDoge]);
                docText.ForeColor = Color.White;
                docImg.Image = Image.FromFile(@"C:\ProjectSnowshoes\System\Media\SlidingMenuBar\DocsAgain.png");
            }
            if (sender.Equals(appsPanel) || sender.Equals(appsImg) || sender.Equals(appsText))
            {
                appsPanel.BackColor = Color.FromName(Properties.Settings.Default.custColor[Properties.Settings.Default.whoIsThisCrazyDoge]);
                appsText.ForeColor = Color.White;
                appsImg.Image = Image.FromFile(@"C:\ProjectSnowshoes\System\Media\SlidingMenuBar\AppsIco.png");
            }
        }

        private void inTheaters_Tick(object sender, EventArgs e)
        {
            if (!this.Focused)
            {

                bool temp = false;

                for (int i = 0; i < Application.OpenForms.Count; i++)
                {
                    if (Application.OpenForms[i].ContainsFocus && (Application.OpenForms[i].Name == "ImagesOnMenu" ||
                        Application.OpenForms[i].Name == "Documents" ||
                        Application.OpenForms[i].Name == "AppsSlidingMenu" ||
                        Application.OpenForms[i].Name == "SearchFromSlidingBar"))
                    {
                        temp = true;
                        
                    }
                    
                }
                
                if (!temp)
                {
                    this.Close();
                }
            }
        }

        private void lockImage_Click(object sender, EventArgs e)
        {
            // Same exact code as seen in Space.cs, just with a better name used for the object.
            ObviouslyTurnUpOnLogIn l = new ObviouslyTurnUpOnLogIn();
            l.Show();
            l.BringToFront();
        }

        private void perhapsIShouldJust_MouseLeave(object sender, EventArgs e)
        {
            if (sender.Equals(searchPanel) || sender.Equals(searchImg) || sender.Equals(searchText))
            {
                searchPanel.BackColor = Color.White;
                searchText.ForeColor = Color.FromName(Properties.Settings.Default.custColor[Properties.Settings.Default.whoIsThisCrazyDoge]);

                searchImg.Image = m;
            }
            if (sender.Equals(picPanel) || sender.Equals(picImg) || sender.Equals(picText))
            {
                picPanel.BackColor = Color.White; 
                picText.ForeColor = Color.FromName(Properties.Settings.Default.custColor[Properties.Settings.Default.whoIsThisCrazyDoge]);
                picImg.Image = l;
            }
            if (sender.Equals(docPanel) || sender.Equals(docImg) || sender.Equals(docText))
            {
                docPanel.BackColor = Color.White;
                docText.ForeColor = Color.FromName(Properties.Settings.Default.custColor[Properties.Settings.Default.whoIsThisCrazyDoge]);
                docImg.Image = k;
            }
            if (sender.Equals(appsPanel) || sender.Equals(appsImg) || sender.Equals(appsText))
            {
                appsPanel.BackColor = Color.White;
                appsText.ForeColor = Color.FromName(Properties.Settings.Default.custColor[Properties.Settings.Default.whoIsThisCrazyDoge]);
                appsImg.Image = j;
            }
        }

        private void settingsImage_Click(object sender, EventArgs e)
        {
            UserSettings snoopdoge = new UserSettings();
            snoopdoge.Show();
            snoopdoge.BringToFront();
            this.Close();
        }

        private void searchPanel_Click(object sender, EventArgs e)
        {
            if (sender.Equals(searchPanel) || sender.Equals(searchImg) || sender.Equals(searchText))
            {
                SearchFromSlidingBar sfsbAgain = new SearchFromSlidingBar(this.Width);
                sfsbAgain.Show();
                sfsbAgain.BringToFront();
            }
            if (sender.Equals(picPanel) || sender.Equals(picImg) || sender.Equals(picText))
            {
                ImagesOnMenu iom = new ImagesOnMenu();
                iom.Show();
                iom.BringToFront();
            }
            if (sender.Equals(docPanel) || sender.Equals(docImg) || sender.Equals(docText))
            {
                Documents docs = new Documents();
                docs.Show();
                docs.BringToFront();
            }
            if (sender.Equals(appsPanel) || sender.Equals(appsImg) || sender.Equals(appsText))
            {
                AppsSlidingMenu appsSM = new AppsSlidingMenu();
                appsSM.Show();
                appsSM.BringToFront();
            }
        }

    }
}
