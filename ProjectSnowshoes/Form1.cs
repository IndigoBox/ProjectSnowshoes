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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        [DllImport("user32")]
        static extern bool AnimateWindow(IntPtr hwnd, int time, int flags);

        private void timeTimer_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = System.DateTime.Now.ToLongTimeString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {



            /* When the color gets out of control again, remove this and the ending comment here.
            
            Properties.Settings.Default.custColor[0] = "DeepSkyBlue";
            Properties.Settings.Default.Save();
              
              
             * Bananagrams.
              
             Properties.Settings.Default.lock_path[0] = @"C:\Windows\Web\Wallpaper\Theme1\img2.jpg";
             Properties.Settings.Default.Save();
             
             Properties.Settings.Default.space_back_path[0] = 
             Properties.Settings.Default.space_back_path[1] = 
             Properties.Settings.Default.space_back_path[2] =
             @"C:\ProjectSnowshoes\System\Media\RunningOnIce.png";

             Properties.Settings.Default.Save();
             
             */


            /* Bringing Snowshoes to the doges. 

            // IndigoBox Studios Account Addition

            Properties.Settings.Default.custColor.Add("BlueViolet");
            Properties.Settings.Default.lock_path.Add(@"C:\ProjectSnowshoes\System\Media\img7.jpg");
            Properties.Settings.Default.loggedIn.Add("false");
            Properties.Settings.Default.nickname.Add("IndigoBox");
            Properties.Settings.Default.space_back_path.Add(@"C:\ProjectSnowshoes\System\Media\RunningOnIce.png");
            Properties.Settings.Default.userimg_path.Add(@"C:\ProjectSnowshoes\System\Media\img7.jpg");
            Properties.Settings.Default.userimgacc_path.Add(@"C:\ProjectSnowshoes\System\Media\ibox.png");
            Properties.Settings.Default.username.Add("IndigoBox Studios");
            Properties.Settings.Default.woahThereHello.Add("------------------");

            Properties.Settings.Default.Save(); // Am I going to regret this? Find out on the next episode of Snowshoes crashes well then
            
            */

            /*
             * Stop that. By order of Billy Joel.
             * (He actually had nothing to do with it, yet the Bridge build did. Sorry, sir.)
             * 
            if (!Properties.Settings.Default.runTimes)
            {
                PrelimSetup prset = new PrelimSetup();
                prset.Show();
                prset.BringToFront();
                /* Properties.Settings.Default.runTimes = true;
                Properties.Settings.Default.Save(); Not yet, goose 
            }*/

            // Previously would set time color
            // May reinstate later
            // "The Bridge" change: 10/10/2014 2005hours
            // timeLabel.ForeColor = Properties.Settings.Default.custColor;
            

            
            // Reset all of the logged in values to false
            /*
             * Actually nah not yet it turns out we might still want this page
             * 
             * Actually yah it turns out everybody has to be off in order to see this
             */ 
            for (int i = 0; i < Properties.Settings.Default.loggedIn.Count; i++)
            {
                Properties.Settings.Default.loggedIn[i] = "false";
            }

            //I can't believe we are commenting this out but
            //Well who am I kidding at least once it was going to happen
            //Oh now what it was the comments that just stayed
            //Oh
            //Oh

            

            //(Oh)
            System.Diagnostics.Process.Start("taskkill.exe", "/F /IM explorer.exe");
            
            /* Revisiting these comments about two months later. Apparently, I either removed the line, or it is right there. 
            It may be watching us. Shhhh...quiet! */

            label3.Left = 0;
            label3.Top = Screen.PrimaryScreen.WorkingArea.Height - 20;
            label3.TextAlign = ContentAlignment.MiddleLeft;
            label4.Top = Screen.PrimaryScreen.WorkingArea.Height - 20;
            label4.Width = Screen.PrimaryScreen.WorkingArea.Width - 500;
            label4.Left = 0;
            label4.Left = 500;
            label4.TextAlign = ContentAlignment.MiddleRight;


        }

        

        private void Form1_KeyDown (object sender, KeyEventArgs e)
        {
            // Edited 9252014 1200hrs (exactly to the minute)
            // Replaced Login with ObviouslyTurnUpOnAuth

            // Edited again 10142014 1535hrs
            // Replaced ObviouslyTurnUpOnAuth with MultipleUsersMain
            
            MultipleUsersMain loginform = new MultipleUsersMain();
            loginform.Show();
            loginform.BringToFront();
            this.Hide();
        }

        private void dataTimer_Tick(object sender, EventArgs e)
        {
            dateLabel.Text = System.DateTime.Today.ToLongDateString();
        }

        private void panel1_VisibleChanged(object sender, EventArgs e)
        {
            const int AW_SLIDE = 0X40000;
            const int AW_HOR_POSITIVE = 0X1;

            // User32 and StackOverflow persons, you da real MVPs.
            AnimateWindow(this.Handle, 300, AW_SLIDE | AW_HOR_POSITIVE);
        }
    }
}
