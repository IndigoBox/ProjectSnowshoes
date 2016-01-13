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
    public partial class SlidingMenuBar : Form
    {
        public SlidingMenuBar()
        {
            InitializeComponent();
        }

        [DllImport("user32")]
        static extern bool AnimateWindow(IntPtr hwnd, int time, int flags);

        

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void SlidingMenuBar_Load(object sender, EventArgs e)
        {

            

            userName.Text = Properties.Settings.Default.nickname[Properties.Settings.Default.whoIsThisCrazyDoge];

            userEmail.Text = Properties.Settings.Default.emailList[Properties.Settings.Default.whoIsThisCrazyDoge];

            apps.ForeColor = Color.FromName(Properties.Settings.Default.custColor[Properties.Settings.Default.whoIsThisCrazyDoge]);
            documents.ForeColor = Color.FromName(Properties.Settings.Default.custColor[Properties.Settings.Default.whoIsThisCrazyDoge]);
            pictures.ForeColor = Color.FromName(Properties.Settings.Default.custColor[Properties.Settings.Default.whoIsThisCrazyDoge]);
            search.ForeColor = Color.FromName(Properties.Settings.Default.custColor[Properties.Settings.Default.whoIsThisCrazyDoge]);


            ImageFactory moveThatTint = new ImageFactory();
            moveThatTint.Load(Properties.Settings.Default.userimgacc_path[Properties.Settings.Default.whoIsThisCrazyDoge]);
            moveThatTint.Tint(Color.FromName(Properties.Settings.Default.custColor[Properties.Settings.Default.whoIsThisCrazyDoge]));

            infoPanel.BackgroundImage = moveThatTint.Image;


            moveThatTint.Load(@"C:\ProjectSnowshoes\System\Media\SlidingMenuBar\XIco.png");
            moveThatTint.Tint(Color.FromName(Properties.Settings.Default.custColor[Properties.Settings.Default.whoIsThisCrazyDoge]));
            turnOffImage.BackgroundImage = moveThatTint.Image;
            turnOffLabel.ForeColor = Color.FromName(Properties.Settings.Default.custColor[Properties.Settings.Default.whoIsThisCrazyDoge]);
            turnOffImage.BackgroundImageLayout = ImageLayout.Zoom;
            turnOffImage.Top = 5;
            turnOffLabel.Top = 5;
            turnOffImage.Height = 40;
            turnOffLabel.Height = 40;
            turnOffPanel.Top = 0;
            turnOffPanel.Height = 50;
            turnOffLabel.TextAlign = ContentAlignment.MiddleLeft;
            turnOffImage.Width = 40;
            turnOffLabel.Width = 100;
            turnOffImage.Left = this.Width - (this.Width / 2) - 70;
            turnOffLabel.Left = turnOffImage.Left + 45;
            turnOffLabel.Font = new System.Drawing.Font("Roboto Light", 14);


            /*ImageFactory anotherTint = new ImageFactory();
            anotherTint.Load(Properties.Settings.Default.lock_path[Properties.Settings.Default.whoIsThisCrazyDoge]);
            anotherTint.Tint(Color.FromName(Properties.Settings.Default.custColor[Properties.Settings.Default.whoIsThisCrazyDoge]));

            notifPanel.BackgroundImage = anotherTint.Image;*/
            notifPanel.BackColor = Color.FromName(Properties.Settings.Default.custColor[Properties.Settings.Default.whoIsThisCrazyDoge]);


            this.Left = 0;
            const int AW_SLIDE = 0X40000;
            const int AW_HOR_POSITIVE = 0X1;

            this.Top = 0;
            
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            
            

            infoPanel.Height = 144;

            notifPanel.Left = 0;
            notifPanel.Top = 50;
            notifPanel.Height = 186;
            notifPanel.Width = this.Width;

            thatBridgeTho.Left = 10;
            thatBridgeTho.Height = notifPanel.Height;
            thatBridgeTho.Width = 90;

            notifTitle.Left = 106;
            notifTitle.Width = notifPanel.Width - 106;
            notifTitle.Height = 30;
            notifTitle.TextAlign = ContentAlignment.MiddleLeft;
            notifTitle.Font = new System.Drawing.Font("Roboto", 18);

            notifSubtitle.Left = 106;
            notifSubtitle.Width = notifPanel.Width - 106;
            notifTitle.Height = 60;
            notifTitle.Font = new System.Drawing.Font("Roboto Light", 12);
            notifTitle.TextAlign = ContentAlignment.TopLeft;
            
            

            


            int remainingSpace = this.Height - 380;

            search.Height = pictures.Height = documents.Height = apps.Height = remainingSpace / 4;
            
            search.Top = notifPanel.Bottom;
            pictures.Top = search.Bottom;
            documents.Top = pictures.Bottom;
            apps.Top = documents.Bottom;

            double oneOfThemMischeviousHeights = 0.2 * search.Height; // Looks like we obviously like pictures more than anything here.
            int hmmmmThatWasThePlanWellIMeanSureQuestionMark = (int)oneOfThemMischeviousHeights;

            search.Font = new System.Drawing.Font("Pacifico", hmmmmThatWasThePlanWellIMeanSureQuestionMark);
            pictures.Font = new System.Drawing.Font("Pacifico", hmmmmThatWasThePlanWellIMeanSureQuestionMark);
            documents.Font = new System.Drawing.Font("Pacifico", hmmmmThatWasThePlanWellIMeanSureQuestionMark);
            apps.Font = new System.Drawing.Font("Pacifico", hmmmmThatWasThePlanWellIMeanSureQuestionMark);
            


            // Omg these people better be getting credit they have saved you so much 

            ImageFactory yepAnotherOneHiFriendsHowAreYouImageFactory = new ImageFactory();
            yepAnotherOneHiFriendsHowAreYouImageFactory.Load(@"C:\ProjectSnowshoes\System\Media\SlidingMenuBar\AppsIco.png");
            yepAnotherOneHiFriendsHowAreYouImageFactory.Tint(Color.FromName(Properties.Settings.Default.custColor[Properties.Settings.Default.whoIsThisCrazyDoge]));

            apps.Image = yepAnotherOneHiFriendsHowAreYouImageFactory.Image;
            search.Image = yepAnotherOneHiFriendsHowAreYouImageFactory.Image;
            documents.Image = yepAnotherOneHiFriendsHowAreYouImageFactory.Image;
            pictures.Image = yepAnotherOneHiFriendsHowAreYouImageFactory.Image;



            // User32 and StackOverflow persons, you da real MVPs.
            AnimateWindow(this.Handle, 100, AW_SLIDE | AW_HOR_POSITIVE);


        }

        private void turnOffElement_Hover(object sender, EventArgs e)
        {
            turnOffPanel.BackColor = Color.FromName(Properties.Settings.Default.custColor[Properties.Settings.Default.whoIsThisCrazyDoge]);
            turnOffImage.BackgroundImage = Image.FromFile(@"C:\ProjectSnowshoes\System\Media\SlidingMenuBar\XIco.png");
            turnOffLabel.ForeColor = Color.White;
        }

        private void turnOffElement_MouseLeave(object sender, EventArgs e)
        {
            turnOffPanel.BackColor = Color.Transparent;

            ImageFactory moreTintingAreYouSerious = new ImageFactory();
            moreTintingAreYouSerious.Load(@"C:\ProjectSnowshoes\System\Media\SlidingMenuBar\XIco.png");
            moreTintingAreYouSerious.Tint(Color.FromName(Properties.Settings.Default.custColor[Properties.Settings.Default.whoIsThisCrazyDoge]));
            turnOffImage.BackgroundImage = moreTintingAreYouSerious.Image;
            turnOffLabel.ForeColor = Color.FromName(Properties.Settings.Default.custColor[Properties.Settings.Default.whoIsThisCrazyDoge]);
        }


        private void barItem_Hover(object sender, EventArgs e)
        {
            if (sender.Equals(search))
            {
                search.BackColor = Color.FromName(Properties.Settings.Default.custColor[Properties.Settings.Default.whoIsThisCrazyDoge]);
                search.ForeColor = Color.White;
                search.Image = Image.FromFile(@"C:\ProjectSnowshoes\System\Media\SlidingMenuBar\AppsIco.png");
            }
            if (sender.Equals(pictures))
            {
                pictures.BackColor = Color.FromName(Properties.Settings.Default.custColor[Properties.Settings.Default.whoIsThisCrazyDoge]);
                pictures.ForeColor = Color.White;
                pictures.Image = Image.FromFile(@"C:\ProjectSnowshoes\System\Media\SlidingMenuBar\AppsIco.png");
            }
            if (sender.Equals(documents))
            {
                documents.BackColor = Color.FromName(Properties.Settings.Default.custColor[Properties.Settings.Default.whoIsThisCrazyDoge]);
                documents.ForeColor = Color.White;
                documents.Image = Image.FromFile(@"C:\ProjectSnowshoes\System\Media\SlidingMenuBar\AppsIco.png");
            }
            if (sender.Equals(apps))
            {
                apps.BackColor = Color.FromName(Properties.Settings.Default.custColor[Properties.Settings.Default.whoIsThisCrazyDoge]);
                apps.ForeColor = Color.White;
                apps.Image = Image.FromFile(@"C:\ProjectSnowshoes\System\Media\SlidingMenuBar\AppsIco.png");
            }
        }

        private void barItem_MouseLeave(object sender, EventArgs e)
        {
            if (sender.Equals(search))
            {
                search.BackColor = Color.Transparent;
                search.ForeColor = Color.FromName(Properties.Settings.Default.custColor[Properties.Settings.Default.whoIsThisCrazyDoge]);

                ImageFactory yepAnotherOneHiFriendsHowAreYouImageFactory = new ImageFactory();
                yepAnotherOneHiFriendsHowAreYouImageFactory.Load(@"C:\ProjectSnowshoes\System\Media\SlidingMenuBar\AppsIco.png");
                yepAnotherOneHiFriendsHowAreYouImageFactory.Tint(Color.FromName(Properties.Settings.Default.custColor[Properties.Settings.Default.whoIsThisCrazyDoge]));

                search.Image = yepAnotherOneHiFriendsHowAreYouImageFactory.Image;

            }
            if (sender.Equals(pictures))
            {
                pictures.BackColor = Color.Transparent;
                pictures.ForeColor = Color.FromName(Properties.Settings.Default.custColor[Properties.Settings.Default.whoIsThisCrazyDoge]);

                ImageFactory yepAnotherOneHiFriendsHowAreYouImageFactory = new ImageFactory();
                yepAnotherOneHiFriendsHowAreYouImageFactory.Load(@"C:\ProjectSnowshoes\System\Media\SlidingMenuBar\AppsIco.png");
                yepAnotherOneHiFriendsHowAreYouImageFactory.Tint(Color.FromName(Properties.Settings.Default.custColor[Properties.Settings.Default.whoIsThisCrazyDoge]));

                pictures.Image = yepAnotherOneHiFriendsHowAreYouImageFactory.Image;

            }
            if (sender.Equals(documents))
            {
                documents.BackColor = Color.Transparent;
                documents.ForeColor = Color.FromName(Properties.Settings.Default.custColor[Properties.Settings.Default.whoIsThisCrazyDoge]);

                ImageFactory yepAnotherOneHiFriendsHowAreYouImageFactory = new ImageFactory();
                yepAnotherOneHiFriendsHowAreYouImageFactory.Load(@"C:\ProjectSnowshoes\System\Media\SlidingMenuBar\AppsIco.png");
                yepAnotherOneHiFriendsHowAreYouImageFactory.Tint(Color.FromName(Properties.Settings.Default.custColor[Properties.Settings.Default.whoIsThisCrazyDoge]));

                documents.Image = yepAnotherOneHiFriendsHowAreYouImageFactory.Image;

            }
            if (sender.Equals(apps))
            {
                apps.BackColor = Color.Transparent;
                apps.ForeColor = Color.FromName(Properties.Settings.Default.custColor[Properties.Settings.Default.whoIsThisCrazyDoge]);

                ImageFactory yepAnotherOneHiFriendsHowAreYouImageFactory = new ImageFactory();
                yepAnotherOneHiFriendsHowAreYouImageFactory.Load(@"C:\ProjectSnowshoes\System\Media\SlidingMenuBar\AppsIco.png");
                yepAnotherOneHiFriendsHowAreYouImageFactory.Tint(Color.FromName(Properties.Settings.Default.custColor[Properties.Settings.Default.whoIsThisCrazyDoge]));

                apps.Image = yepAnotherOneHiFriendsHowAreYouImageFactory.Image;

            }
        }

        private void turnOffLabel_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer");
            Application.Exit();
        }

        private void turnOffImage_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer");
            Application.Exit();
        }

        private void search_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.stayHere = true;
            Properties.Settings.Default.Save();
            SearchFromSlidingBar sfsb = new SearchFromSlidingBar(this.Width);
            sfsb.Show();
            sfsb.BringToFront();
        }

        private void SlidingMenuBar_Deactivate(object sender, EventArgs e)
        {
            
            if (!Properties.Settings.Default.stayHere){
                this.Close();
            }
            
            
            
        }

    }
}
