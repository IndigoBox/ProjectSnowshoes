using ImageProcessor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transitions;

namespace ProjectSnowshoes
{
    public partial class BottomBar : Form
    {
        int heightToUseInAdj;
        int currentCountProc = 0;

        [DllImport("user32.dll", SetLastError = true)]
        static extern void SwitchToThisWindow(IntPtr hWnd, bool fAltTab);


        public BottomBar(int canYouBelieveThis)
        {
            InitializeComponent();

            heightToUseInAdj = canYouBelieveThis;

            

            this.SetStyle(System.Windows.Forms.ControlStyles.SupportsTransparentBackColor, true);

            this.BackColor = Color.Transparent;

            //this.UpdateStyles();

            //bottomPanel.BackColor = Color.FromArgb(122,Color.DeepSkyBlue);



            

        }


        private void BottomBar_Load(object sender, EventArgs e)
        {
            

            
            
            // Adjust size

            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Height = heightToUseInAdj - Screen.PrimaryScreen.WorkingArea.Height;
            this.Top = Screen.PrimaryScreen.WorkingArea.Height;
            this.Left = 0;

            // Left Account Information 

            name.Text = Properties.Settings.Default.nickname[Properties.Settings.Default.whoIsThisCrazyDoge];

            // Custom Color Integration

            name.BackColor = Color.FromName(Properties.Settings.Default.custColor[Properties.Settings.Default.whoIsThisCrazyDoge]);
            
            // Adjustment of Font and Resolution

            name.Font = new System.Drawing.Font(Properties.Settings.Default.fontsOfScience[Properties.Settings.Default.whoIsThisCrazyDoge], 14);
            timeSpaceContinuum.Font = new System.Drawing.Font(Properties.Settings.Default.fontsOfScience[Properties.Settings.Default.whoIsThisCrazyDoge], 11);
            name.Width = 145;
            
            // Load processes

            spaceForProcesses.Left = 150;
            spaceForProcesses.Width = spaceForProcesses.Width - 150;

            spaceForProcesses.Top = bottomPanel.Top;


            spaceForProcesses.Height = bottomPanel.Height;

            spaceForProcesses.Invalidate();

            //goGenerateProcessesFriendship();

            //Application.DoEvents();

            timeSpaceContinuum.Update();

            // Aw yeah even more spaces
            // Time to do work, or in other words, free the spaceForProcesses from the taskbar so that hover functionality can work
            // (even though I still have to make the hover functionality Robert do you know what you are doing)
            // (no)

            // Have to replace panel and draw on top of other windows...this will be interesting
            // panel1.Controls.Add(spaceForProcesses);

            // So...it's just drawn on the form? Is that how this works? 
            // Robert, you need to comment better when you are actually doing things here
            // bottomPanel.Controls.Remove(spaceForProcesses);
        }

        private void goGenerateProcessesFriendship()
        {

            

            int artOfficial = 0;

            foreach (var theProcess in Process.GetProcesses())
            {

                
                // hmGreatJobFantasticAmazing.BackgroundImageLayout = ImageLayout.Center;

                if (theProcess.MainWindowTitle != "" && theProcess.MainWindowTitle != "Space")
                {
                    artOfficial++;
                }
            }

            if (artOfficial != currentCountProc) {

                spaceForProcesses.Controls.Clear();

                foreach (var theProcess in Process.GetProcesses())
                {
                
                Label hmGreatJobFantasticAmazing = new Label();
                if (theProcess.MainWindowTitle != "" && theProcess.MainWindowTitle != "Space")
                {
                    
                    //hmGreatJobFantasticAmazing.Text = theProcess.MainWindowTitle;
                    hmGreatJobFantasticAmazing.Margin = new Padding(6, 0, 6, 0);

                    hmGreatJobFantasticAmazing.Visible = true;

                    // hmGreatJobFantasticAmazing.Font = new System.Drawing.Font(Properties.Settings.Default.fontsOfScience[Properties.Settings.Default.whoIsThisCrazyDoge], 13, FontStyle.Italic);


                    Icon.ExtractAssociatedIcon(theProcess.Modules[0].FileName).ToBitmap().Save(@"C:\ProjectSnowshoes\temptaskico.png");

                    /*DualImageForm thanksVKLines = new DualImageForm();
                    thanksVKLines.pic = Icon.ExtractAssociatedIcon(theProcess.Modules[0].FileName).ToBitmap();
                    thanksVKLines.analyze();
                    thanksVKLines.pic2.Save(@"C:\ProjectSnowshoes\newtemptaskico.png");*/

                    ImageFactory grayify = new ImageFactory();
                    grayify.Load(@"C:\ProjectSnowshoes\temptaskico.png");
                    //grayify.Tint(Color.FromName(Properties.Settings.Default.custColor[Properties.Settings.Default.whoIsThisCrazyDoge]));
                    //grayify.Tint(Color.FromName("Gray"));
                    hmGreatJobFantasticAmazing.Image = grayify.Image;

                    hmGreatJobFantasticAmazing.Click += (sender, args) =>
                    {
                        //System.Diagnostics.Process.Start(theProcess.Modules[0].FileName);
                        SwitchToThisWindow(theProcess.MainWindowHandle, false);
                    };
                    hmGreatJobFantasticAmazing.MouseHover += (sender, args) =>
                    {
                        Properties.Settings.Default.stayHere = true;
                        Properties.Settings.Default.Save();

                        int recordNao = hmGreatJobFantasticAmazing.Left;
                        

                        hmGreatJobFantasticAmazing.BackColor = Color.FromName(Properties.Settings.Default.custColor[Properties.Settings.Default.whoIsThisCrazyDoge]);


                        // Yeahhhhhhhhh I'm going to have to do this another way
                        // panel1.Controls.Add(areYouSeriouslyStillDoingThisLetItGo);

                        // Oh
                        // I can just make another form to draw over and go have turnips with parameters
                        // Also credits to Microsoft Word's "Sentence Case" option as this came out in all caps originally



                        //Measuring string turnt-up-edness was guided by an answer on Stack Overflow by Tom Anderson.

                        String keepThisShortWeNeedToOptimize = Process.GetProcessById(theProcess.Id).MainWindowTitle;
                        
                        Graphics heyGuessWhatGraphicsYeahThatsRight = Graphics.FromImage(new Bitmap(1, 1));
                        SizeF sure = heyGuessWhatGraphicsYeahThatsRight.MeasureString(keepThisShortWeNeedToOptimize, new System.Drawing.Font(Properties.Settings.Default.fontsOfScience[Properties.Settings.Default.whoIsThisCrazyDoge], 14, FontStyle.Regular, GraphicsUnit.Point));
                        Size sureAgain = sure.ToSize();

                        int recordThatJim;

                        if (sureAgain.Width >= 300)
                        {
                            recordThatJim = sureAgain.Width + 10;
                        }
                        else
                        {
                            recordThatJim = 300;
                        }

                        

                        CanWeMakeAHoverFormLikeThisIsThisLegal notAsLongInstanceName = new CanWeMakeAHoverFormLikeThisIsThisLegal(recordNao + 150, bottomPanel.Height, recordThatJim, keepThisShortWeNeedToOptimize);
                        notAsLongInstanceName.Show();
                        notAsLongInstanceName.BringToFront();

                        //hmGreatJobFantasticAmazing.BringToFront();
                        //panel1.Controls.Add(hmGreatJobFantasticAmazing);
                        //hmGreatJobFantasticAmazing.Top = bottomPanel.Top - 40;
                        //hmGreatJobFantasticAmazing.Left = recordNao + 150;
                        //hmGreatJobFantasticAmazing.BringToFront();
                        //hmGreatJobFantasticAmazing.Invalidate();


                        /*hmGreatJobFantasticAmazing.Height = 100;
                        hmGreatJobFantasticAmazing.Width = 100;*/
                    };
                    hmGreatJobFantasticAmazing.MouseLeave += (sender, args) =>
                    {
                        /*hmGreatJobFantasticAmazing.ImageAlign = ContentAlignment.MiddleCenter;
                        hmGreatJobFantasticAmazing.AutoEllipsis = false;
                        hmGreatJobFantasticAmazing.Width = 40;
                        hmGreatJobFantasticAmazing.BackColor = Color.Transparent;
                        //hmGreatJobFantasticAmazing.Font = new System.Drawing.Font(Properties.Settings.Default.fontsOfScience[Properties.Settings.Default.whoIsThisCrazyDoge], 14, FontStyle.Regular);
                        //hmGreatJobFantasticAmazing.ForeColor = Color.White;

                        hmGreatJobFantasticAmazing.TextAlign = ContentAlignment.MiddleLeft;
                        hmGreatJobFantasticAmazing.Text = "";*/

                        try
                        {
                            Application.OpenForms["CanWeMakeAHoverFormLikeThisIsThisLegal"].Close();
                        }
                        catch (Exception exTurnip)
                        {
                            
                        }
                        
                        hmGreatJobFantasticAmazing.BackColor = Color.Transparent;

                        hmGreatJobFantasticAmazing.Invalidate();

                        Properties.Settings.Default.stayHere = false;
                        Properties.Settings.Default.Save();


                    };



                    //openFileToolTip.SetToolTip(hmGreatJobFantasticAmazing, theProcess.MainWindowTitle);
                    //hmGreatJobFantasticAmazing.BackgroundImage = Icon.ExtractAssociatedIcon(theProcess.Modules[0].FileName).ToBitmap();



                    hmGreatJobFantasticAmazing.Height = bottomPanel.Height;
                    hmGreatJobFantasticAmazing.Width = 50;



                    spaceForProcesses.Controls.Add(hmGreatJobFantasticAmazing);

                    hmGreatJobFantasticAmazing.Invalidate();
                    

                }}

            }

            currentCountProc = artOfficial;
            

        }

        private void name_Click(object sender, EventArgs e)
        {
            SlidingMenuBar slidingMenu = new SlidingMenuBar();
            slidingMenu.Show();
            slidingMenu.BringToFront();
        }

        private void timeTimer_Tick(object sender, EventArgs e)
        {
            timeSpaceContinuum.Text = System.DateTime.Now.ToShortTimeString();
            
            goGenerateProcessesFriendship();
            
        }

        private void theoreticalTurnips()
        {
            int i = 0;
            foreach (var theProcess in Process.GetProcesses())
            {
                if (theProcess.MainWindowTitle != "" && theProcess.MainWindowTitle != "Space")
                {
                    i++;
                }
            }

            if (i != currentCountProc)
            {
                currentCountProc = i;
                spaceForProcesses.Controls.Clear();
                goGenerateProcessesFriendship();
            }
        }

        private void timeSpaceContinuum_Click(object sender, EventArgs e)
        {
            // In the references document, make sure you credit this one to Henry Fidel Bradley Post. 

            UserSettings snoopdoge = new UserSettings();
            snoopdoge.Show();
            snoopdoge.BringToFront();
        }

        private void dogeAccountImg_Click(object sender, EventArgs e)
        {
            MinervaIntegrated minervuh = new MinervaIntegrated();

            minervuh.Show();
            minervuh.BringToFront();
        }

    }
}
