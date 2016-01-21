using ProjectSnowshoes.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImageProcessor;
using System.Net;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;
using Transitions;

namespace ProjectSnowshoes
{
    public partial class Space : Form
    {

        String nP1, nP2, nP3, nP4, nP5, nP6, nP7;
        String currentBGPath;

        [DllImport("user32")]
        static extern bool AnimateWindow(IntPtr hwnd, int time, int flags);

        // We were going to need this user32.dll, after all...hm.
        [DllImport("user32.dll")]
        public static extern IntPtr SendMessageW(IntPtr hWnd, int Msg,
            IntPtr wParam, IntPtr lParam);


        // Former constructed by the aid of Paedow's answer on StackOverflow: http://stackoverflow.com/questions/13139181/how-to-programmatically-set-the-system-volume
        // In this specific line, all of the variable names were kept in case necessary (which they should not be, yet they do refer to what is actually going on).

        // Library usage learned from help of StackOverflow and link to GeekPedia, seemingly written for older implementations.
        // Let's hope this still works, anyway...here we go!

        [DllImport("winmm.dll")]
        public static extern int waveOutGetVolume(IntPtr hwo, out uint dwVolume);

        [DllImport("winmm.dll")]
        public static extern int waveOutSetVolume(IntPtr hwo, uint dwVolume);

        [DllImport("winmm.dll")]
        
        public static extern IntPtr SetMasterVolumeLevel(float fLevelDB, IntPtr pguidEventContext);

        public Space()
        {
            InitializeComponent();
            spaceRightClick.Renderer = new MenuContextRenderer();
            rightClickDevStrip.Renderer = new MenuContextRenderer();
            this.AllowTransparency = true;
            Properties.Settings.Default.runTimes = true;
            Properties.Settings.Default.Save();
        }

        private void Space_Load(object sender, EventArgs e)
        {
            
            // Set size of elements based on screen resolution 

            goFixTheResYas();
            
            // Repair flickering by turning up instead

            this.BackgroundImage = null;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            DoubleBufferManipulation.SetDoubleBuffered(panel1);
            DoubleBufferManipulation.SetDoubleBuffered(spaceForIcons);
            
            // Bottom Bar Load

            /*ThisMayFixTransparency prelimBar = new ThisMayFixTransparency(this.Height);
            prelimBar.Show();
            prelimBar.BringToFront();*/
            
            /*BottomBar newBotBar = new BottomBar(this.Height);
            newBotBar.Show();
            newBotBar.BringToFront();*/

            BottomBar_Concept124 newBotBar = new BottomBar_Concept124(this.Height);
            newBotBar.Show();
            newBotBar.BringToFront();

            // Font Family Setting Load

            timeSpaceContinuum.Font = new System.Drawing.Font(Properties.Settings.Default.fontsOfScience[Properties.Settings.Default.whoIsThisCrazyDoge], 11);

            // Space Background Load

            this.BackColor = Color.FromName(Properties.Settings.Default.custColor[Properties.Settings.Default.whoIsThisCrazyDoge]);

            panel1.BackgroundImage = Image.FromFile(Properties.Settings.Default.space_back_path[Properties.Settings.Default.whoIsThisCrazyDoge]);
            currentBGPath = Properties.Settings.Default.space_back_path[Properties.Settings.Default.whoIsThisCrazyDoge];
            
            // Top Left Account Information 

            accountImg.Image = Image.FromFile(Properties.Settings.Default.userimgacc_path[Properties.Settings.Default.whoIsThisCrazyDoge]);
            name.Text = Properties.Settings.Default.nickname[Properties.Settings.Default.whoIsThisCrazyDoge];

            // Custom Color Integration

            name.BackColor = Color.FromName(Properties.Settings.Default.custColor[Properties.Settings.Default.whoIsThisCrazyDoge]);
            panel3.BackColor = Color.FromName(Properties.Settings.Default.custColor[Properties.Settings.Default.whoIsThisCrazyDoge]);
            date.BackColor = Color.FromName(Properties.Settings.Default.custColor[Properties.Settings.Default.whoIsThisCrazyDoge]);
            time.BackColor = Color.FromName(Properties.Settings.Default.custColor[Properties.Settings.Default.whoIsThisCrazyDoge]);





            // Notification Loader Portion

            for (int index = 0; index <= Properties.Settings.Default.notificationapps.Count - 1; index++)
            {
                String nameThatFile = Settings.Default.notificationapps[index];
                Process.Start(nameThatFile);
            }

            System.IO.File.WriteAllText("C:\\ProjectSnowshoes\\notification.txt", Properties.Settings.Default.notificationtext);



            //Application.DoEvents();

            // Load apps 

            goGenerateTilesFriendship();


            //Application.DoEvents();

            // Load processes

            // goGenerateProcessesFriendship();

            



            // Aw yeah even more spaces
            // Time to do work, or in other words, free the spaceForProcesses from the taskbar so that hover functionality can work
            // (even though I still have to make the hover functionality Robert do you know what you are doing)
            // (no)

            /*panel1.Controls.Add(spaceForProcesses);
            bottomPanel.Controls.Remove(spaceForProcesses);*/


            //Transition.run(this, "Opacity", 0, 1, new TransitionType_EaseInEaseOut(14));

            BackgroundFunctionManager bfm = new BackgroundFunctionManager();
            bfm.Show();

        }

        private void accountImg_Click(object sender, EventArgs e)
        {
            /* New menu implementation in The Bridge Build replaces original design. (11/24/2014)
             * 
             * accountImg.Left = 300;
            name.Left = 300;
            sidebar.Left = 0;*/

            SlidingMenuBarPostEG whatIsGoingOn = new SlidingMenuBarPostEG();
            whatIsGoingOn.Show();
            whatIsGoingOn.BringToFront();

        }

        private void timeTimer_Tick(object sender, EventArgs e)
        {
            time.Text = System.DateTime.Now.ToShortTimeString();
            timeSpaceContinuum.Text = System.DateTime.Now.ToShortTimeString();

            // Not for time, but come on now I'm not organized like wow

            // Actually wait this may not be the best move right now because tiles do not work with this code here
            // I mean this works but to a point and graphics get turnt but yeah

            // Never mind we are going to try this again wow make up your mind

            /*int i = 0;
            foreach (var theProcess in Process.GetProcesses())
            {
                if (theProcess.MainWindowTitle != "")
                {
                    i++;
                }
            }
            if (i != spaceForProcesses.Controls.Count) {
                spaceForProcesses.Controls.Clear();
                goGenerateProcessesFriendship();
            }  
    
            Application.DoEvents();*/

        }

        private void dateTimer_Tick(object sender, EventArgs e)
        {
            date.Text = System.DateTime.Today.ToShortDateString();
        }

        private void exitWindows_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer");
            Application.Exit();

        }

        private void exitWindowsText_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer");
            Application.Exit();
        }

        private void notificationTimer_Tick(object sender, EventArgs e)
        {
            
                if (System.IO.File.ReadAllText("C:\\ProjectSnowshoes\\notification.txt") != Properties.Settings.Default.notificationtext)
                {

                    String turntUp = System.IO.File.ReadAllText("C:\\ProjectSnowshoes\\notification.txt").Split('\n')[0];
                    String turntUpA = System.IO.File.ReadAllText("C:\\ProjectSnowshoes\\notification.txt").Split('\n')[1];
                    String turntUpAA = System.IO.File.ReadAllText("C:\\ProjectSnowshoes\\notification.txt").Split('\n')[2];

                    Notification notif = new Notification(turntUp, turntUpA, Image.FromFile("C:\\ProjectSnowshoes\\notificationIcon.png"));
                    notif.Show();
                    notif.BringToFront();

                    Properties.Settings.Default.notificationtext = System.IO.File.ReadAllText("C:\\ProjectSnowshoes\\notification.txt");
                    Properties.Settings.Default.Save();

                    if (n1a.Visible == false)
                    {
                        n1a.Visible = true;
                        n1b.Visible = true;
                        n1c.Visible = true;
                        n1a.Image = Image.FromFile("C:\\ProjectSnowshoes\\notificationIcon.png");
                        n1b.Text = turntUp;
                        n1c.Text = turntUpA;
                        nP1 = turntUpAA;
                    }
                    else if (n2a.Visible == false)
                    {
                        n2a.Visible = true;
                        n2b.Visible = true;
                        n2c.Visible = true;
                        n2a.Image = Image.FromFile("C:\\ProjectSnowshoes\\notificationIcon.png");
                        n2b.Text = turntUp;
                        n2c.Text = turntUpA;
                        nP2 = turntUpAA;
                    }
                    else if (n3a.Visible == false)
                    {
                        n3a.Visible = true;
                        n3b.Visible = true;
                        n3c.Visible = true;
                        n3a.Image = Image.FromFile("C:\\ProjectSnowshoes\\notificationIcon.png");
                        n3b.Text = turntUp;
                        n3c.Text = turntUpA;
                        nP3 = turntUpAA;
                    }
                    else if (n4a.Visible == false)
                    {
                        n4a.Visible = true;
                        n4b.Visible = true;
                        n4c.Visible = true;
                        n4a.Image = Image.FromFile("C:\\ProjectSnowshoes\\notificationIcon.png");
                        n4b.Text = turntUp;
                        n4c.Text = turntUpA;
                        nP4 = turntUpAA;
                    }
                    else if (n5a.Visible == false)
                    {
                        n5a.Visible = true;
                        n5b.Visible = true;
                        n5c.Visible = true;
                        n5a.Image = Image.FromFile("C:\\ProjectSnowshoes\\notificationIcon.png");
                        n5b.Text = turntUp;
                        n5c.Text = turntUpA;
                        nP5 = turntUpAA;
                    }
                    else if (n6a.Visible == false)
                    {
                        n6a.Visible = true;
                        n6b.Visible = true;
                        n6c.Visible = true;
                        n6a.Image = Image.FromFile("C:\\ProjectSnowshoes\\notificationIcon.png");
                        n6b.Text = turntUp;
                        n6c.Text = turntUpA;
                        nP6 = turntUpAA;
                    }
                    else if (n7a.Visible == false)
                    {
                        n7a.Visible = true;
                        n7b.Visible = true;
                        n7c.Visible = true;
                        n7a.Image = Image.FromFile("C:\\ProjectSnowshoes\\notificationIcon.png");
                        n7b.Text = turntUp;
                        n7c.Text = turntUpA;
                        nP7 = turntUpAA;
                    }
                    else
                    {
                        n1a.Image = Image.FromFile("C:\\ProjectSnowshoes\\notificationIcon.png");
                        n1b.Text = turntUp;
                        n1c.Text = turntUpA;
                        nP1 = turntUpAA;
                    }


                }
            
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void n7c_Click(object sender, EventArgs e)
        {

        }

        private void n5c_Click(object sender, EventArgs e)
        {

        }

        private void n7b_Click(object sender, EventArgs e)
        {

        }

        private void n5b_Click(object sender, EventArgs e)
        {

        }

        private void n7a_Click(object sender, EventArgs e)
        {

        }

        private void n5a_Click(object sender, EventArgs e)
        {

        }

        private void n6c_Click(object sender, EventArgs e)
        {

        }

        private void n4c_Click(object sender, EventArgs e)
        {

        }

        private void n6b_Click(object sender, EventArgs e)
        {

        }

        private void n4b_Click(object sender, EventArgs e)
        {

        }

        private void n6a_Click(object sender, EventArgs e)
        {

        }

        private void n4a_Click(object sender, EventArgs e)
        {

        }

        private void n3c_Click(object sender, EventArgs e)
        {

        }

        private void n3b_Click(object sender, EventArgs e)
        {

        }

        private void n3a_Click(object sender, EventArgs e)
        {

        }

        private void n2c_Click(object sender, EventArgs e)
        {

        }

        private void n2b_Click(object sender, EventArgs e)
        {

        }

        private void n2a_Click(object sender, EventArgs e)
        {

        }

        private void n1c_Click(object sender, EventArgs e)
        {

        }

        private void powerText_Click(object sender, EventArgs e)
        {

        }

        private void n1b_Click(object sender, EventArgs e)
        {

        }

        private void powerOff_Click(object sender, EventArgs e)
        {

        }

        private void n1a_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void date_Click(object sender, EventArgs e)
        {

        }

        private void time_Click(object sender, EventArgs e)
        {

        }

        private void name_Click(object sender, EventArgs e)
        {

        }

        private void changeBackgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeBackground chromebook = new ChangeBackground();
            chromebook.Show();
            chromebook.BringToFront();
        }

        private void changeBackgroundToolStripMenuItem_Hover(object sender, EventArgs e)
        {
            // Future Reference: Sender cannot be passed in like this.
            // sender.ForeColor = Color.White;
        }

        private void bgTimer_Tick(object sender, EventArgs e)
        {
            /*if (currentBGPath != Properties.Settings.Default.space_back_path[Properties.Settings.Default.whoIsThisCrazyDoge])
            {
                this.BackgroundImage = Image.FromFile(Properties.Settings.Default.space_back_path[Properties.Settings.Default.whoIsThisCrazyDoge]);
                currentBGPath = Properties.Settings.Default.space_back_path[Properties.Settings.Default.whoIsThisCrazyDoge];
            }*/
        }

        private void changeColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cdlg = new ColorDialog();
            if (cdlg.ShowDialog() == DialogResult.OK) {
                Properties.Settings.Default.custColor[Properties.Settings.Default.whoIsThisCrazyDoge] = cdlg.Color.Name;
                Properties.Settings.Default.Save();
                Space spaaaaaaaaaaaaaaaaaaace1 = new Space();
                spaaaaaaaaaaaaaaaaaaace1.Show();
                spaaaaaaaaaaaaaaaaaaace1.Show();
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ObviouslyTurnUpOnLogIn turntturnt = new ObviouslyTurnUpOnLogIn();
            turntturnt.Show();
            turntturnt.BringToFront();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutSnowshoes aboutA = new AboutSnowshoes();
            aboutA.Show();
            aboutA.BringToFront();
        }

        private void logincsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login loginOld = new Login();
            loginOld.Show();
            loginOld.BringToFront();
        }

        private void goFixTheResYas()
        {
            
            //if (Screen.PrimaryScreen.Bounds.Width == 3200 && Screen.PrimaryScreen.Bounds.Height == 1800)
            //{
                accountImg.Height = 145;
                accountImg.Width = 145;
                accountImg.Top = Screen.PrimaryScreen.Bounds.Height - 145 - bottomPanel.Height;
                //name.Top = 100;
                //name.Height = 25;
                //name.Width = 100;
                name.Font = new System.Drawing.Font(Properties.Settings.Default.fontsOfScience[Properties.Settings.Default.whoIsThisCrazyDoge], 14);
                name.Width = 145;
                

                panel3.Height = 125;
                panel3.Top = 0;

                bottomPanel.Height = this.Height - Screen.PrimaryScreen.WorkingArea.Height;
                





            //}
        }

        private void goGenerateProcessesFriendship()
        {

            spaceForProcesses.Left = 150;
            spaceForProcesses.Width = spaceForProcesses.Width - 150;

            spaceForProcesses.Top = bottomPanel.Top;
            

            spaceForProcesses.Height = bottomPanel.Height;

            spaceForProcesses.Invalidate();
            
            foreach (var theProcess in Process.GetProcesses())
            {
                
            
                Label hmGreatJobFantasticAmazing = new Label();
                // hmGreatJobFantasticAmazing.BackgroundImageLayout = ImageLayout.Center;

                if (theProcess.MainWindowTitle != "")
                {
                    //hmGreatJobFantasticAmazing.Text = theProcess.MainWindowTitle;
                    hmGreatJobFantasticAmazing.Margin = new Padding(6,0,6,0);
                    
                    hmGreatJobFantasticAmazing.Visible = true;
                    
                    // hmGreatJobFantasticAmazing.Font = new System.Drawing.Font(Properties.Settings.Default.fontsOfScience[Properties.Settings.Default.whoIsThisCrazyDoge], 13, FontStyle.Italic);
                    

                    Icon.ExtractAssociatedIcon(theProcess.Modules[0].FileName).ToBitmap().Save(@"C:\ProjectSnowshoes\temptaskico.png");

                    DualImageForm thanksVKLines = new DualImageForm();
                    thanksVKLines.pic = Icon.ExtractAssociatedIcon(theProcess.Modules[0].FileName).ToBitmap();
                    thanksVKLines.analyze();
                    thanksVKLines.pic2.Save(@"C:\ProjectSnowshoes\newtemptaskico.png");

                    ImageFactory grayify = new ImageFactory();
                    grayify.Load(@"C:\ProjectSnowshoes\temptaskico.png");
                    //grayify.Tint(Color.FromName(Properties.Settings.Default.custColor[Properties.Settings.Default.whoIsThisCrazyDoge]));
                    //grayify.Tint(Color.FromName("Gray"));
                    hmGreatJobFantasticAmazing.Image = grayify.Image;

                    Label areYouSeriouslyStillDoingThisLetItGo = new Label();

                    hmGreatJobFantasticAmazing.Click += (sender, args) =>
                    {
                            System.Diagnostics.Process.Start(theProcess.Modules[0].FileName);   
                    };
                    hmGreatJobFantasticAmazing.MouseHover += (sender, args) =>
                        {
                            int recordNao = hmGreatJobFantasticAmazing.Left;
                            //hmGreatJobFantasticAmazing.BackgroundImageLayout = ImageLayout.Zoom;
                            //hmGreatJobFantasticAmazing.Height = 75;
                            /*hmGreatJobFantasticAmazing.ImageAlign = ContentAlignment.MiddleLeft;
                            hmGreatJobFantasticAmazing.AutoEllipsis = true;
                            hmGreatJobFantasticAmazing.Width = 250;
                            hmGreatJobFantasticAmazing.BackColor = Color.FromName(Properties.Settings.Default.custColor[Properties.Settings.Default.whoIsThisCrazyDoge]);
                            hmGreatJobFantasticAmazing.Font = new System.Drawing.Font(Properties.Settings.Default.fontsOfScience[Properties.Settings.Default.whoIsThisCrazyDoge], 14, FontStyle.Regular);
                            hmGreatJobFantasticAmazing.ForeColor = Color.White;
                            
                            hmGreatJobFantasticAmazing.TextAlign = ContentAlignment.MiddleLeft;
                            hmGreatJobFantasticAmazing.Text = "        " + theProcess.MainWindowTitle;*/

                            hmGreatJobFantasticAmazing.BackColor = Color.FromName(Properties.Settings.Default.custColor[Properties.Settings.Default.whoIsThisCrazyDoge]);

                            
                            areYouSeriouslyStillDoingThisLetItGo.Left = recordNao + 150;
                            areYouSeriouslyStillDoingThisLetItGo.Text = theProcess.MainWindowTitle;
                            areYouSeriouslyStillDoingThisLetItGo.BackColor = Color.FromName(Properties.Settings.Default.custColor[Properties.Settings.Default.whoIsThisCrazyDoge]);
                            areYouSeriouslyStillDoingThisLetItGo.Font = new System.Drawing.Font(Properties.Settings.Default.fontsOfScience[Properties.Settings.Default.whoIsThisCrazyDoge], 14, FontStyle.Regular);
                            areYouSeriouslyStillDoingThisLetItGo.ForeColor = Color.White;
                            areYouSeriouslyStillDoingThisLetItGo.TextAlign = ContentAlignment.MiddleLeft;

                            panel1.Controls.Add(areYouSeriouslyStillDoingThisLetItGo);

                            //Measuring string turnt-up-edness was guided by an answer on Stack Overflow by Tom Anderson.
                            Graphics heyGuessWhatGraphicsYeahThatsRight = Graphics.FromImage(new Bitmap(1,1));
                            SizeF sure = heyGuessWhatGraphicsYeahThatsRight.MeasureString(theProcess.MainWindowTitle, new System.Drawing.Font(Properties.Settings.Default.fontsOfScience[Properties.Settings.Default.whoIsThisCrazyDoge], 14, FontStyle.Regular, GraphicsUnit.Point));
                            Size sureAgain = sure.ToSize();

                            if (sureAgain.Width >= 300)
                            {
                                areYouSeriouslyStillDoingThisLetItGo.Width = sureAgain.Width + 10;
                            }
                            else
                            {
                                areYouSeriouslyStillDoingThisLetItGo.Width = 300;
                            }

                            areYouSeriouslyStillDoingThisLetItGo.Height = bottomPanel.Height;
                            areYouSeriouslyStillDoingThisLetItGo.Top = Screen.PrimaryScreen.WorkingArea.Height - bottomPanel.Height;
                            


                            areYouSeriouslyStillDoingThisLetItGo.Show();
                            areYouSeriouslyStillDoingThisLetItGo.Visible = true;
                            areYouSeriouslyStillDoingThisLetItGo.BringToFront();
                            areYouSeriouslyStillDoingThisLetItGo.Invalidate();

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

                            panel1.Controls.Remove(areYouSeriouslyStillDoingThisLetItGo);
                            hmGreatJobFantasticAmazing.BackColor = Color.Transparent;


                        };
                    
                    

                    openFileToolTip.SetToolTip(hmGreatJobFantasticAmazing, theProcess.MainWindowTitle);
                    //hmGreatJobFantasticAmazing.BackgroundImage = Icon.ExtractAssociatedIcon(theProcess.Modules[0].FileName).ToBitmap();
                    
                    
                    
                    hmGreatJobFantasticAmazing.Height = bottomPanel.Height;
                    hmGreatJobFantasticAmazing.Width = 40;
                    
                    spaceForProcesses.Controls.Add(hmGreatJobFantasticAmazing);
                }

            }
        }
        
        private void goGenerateTilesFriendship()
        {
            
            String pathPlease = @"C:\ProjectSnowshoes\User\" + Properties.Settings.Default.username[Properties.Settings.Default.whoIsThisCrazyDoge] + @"\Space";

            for (int i = 0; i < Directory.GetFiles(pathPlease,"*.*",SearchOption.TopDirectoryOnly).Length; i++) {
                
                FileInfo fiInf = new FileInfo(Directory.GetFiles(pathPlease, "*.*", SearchOption.TopDirectoryOnly)[i]);
                String fiInfStr = fiInf.Name;
                String fiInfStillWIthExt = fiInfStr;
                fiInfStr = fiInfStr.Split('.')[0];

                // if (fiInfStillWIthExt != "desktop.ini" || 
                if ((fiInf.Attributes & FileAttributes.Hidden) != FileAttributes.Hidden)
                {

                    String panelname = "app" + i;
                    Panel app1 = new Panel();
                    app1.Show();
                    app1.BackColor = Color.Transparent;
                    app1.Width = 150;
                    app1.Height = 150;
                    app1.Margin = new Padding(20);
                    app1.BackgroundImageLayout = ImageLayout.Stretch;


                    iconMatch(Directory.GetFiles(pathPlease, "*.*", SearchOption.TopDirectoryOnly)[i]);

                    DoubleBufferManipulation.SetDoubleBuffered(app1);

                    spaceForIcons.Controls.Add(app1);

                    Panel turnip = new Panel();
                    turnip.Show();
                    turnip.BackColor = Color.Transparent;
                    turnip.Width = 150;
                    turnip.Height = 150;
                    turnip.BackgroundImageLayout = ImageLayout.Zoom;

                    IconManager areYouForRealRightNowLikeReallyRealVSWow = new IconManager();
                    app1.BackColor = Color.FromName(Properties.Settings.Default.custColor[Properties.Settings.Default.whoIsThisCrazyDoge]);
                    app1.BackgroundImage = Properties.Resources._20pertrans_lighterGray;
                    turnip.BackgroundImage = areYouForRealRightNowLikeReallyRealVSWow.icoExtReturner(fiInf.FullName, fiInfStr, true);

                    DoubleBufferManipulation.SetDoubleBuffered(turnip);
                    app1.Controls.Add(turnip);
                    turnip.Left = 0;
                    turnip.Top = 0;

                    Label whatEvenIsThis = new Label();
                    whatEvenIsThis.BackColor = Color.Transparent;
                    whatEvenIsThis.Show();

                    /*ImageFactory imga = new ImageFactory();

                    Properties.Resources.TheOpacityIsAlmostReal.Save("C:\\ProjectSnowshoes\\loginbacktempAA.png");
                    imga.Load("C:\\ProjectSnowshoes\\loginbacktempAA.png");
                    imga.Tint(Color.FromName(Properties.Settings.Default.custColor[Properties.Settings.Default.whoIsThisCrazyDoge]));

                    whatEvenIsThis.BackgroundImage = imga.Image;*/

                    whatEvenIsThis.BackgroundImage = Image.FromFile("C:\\ProjectSnowshoes\\loginbacktempAA.png");


                    whatEvenIsThis.Width = 150;
                    whatEvenIsThis.Height = 40;
                    /* whatEvenIsThis.Text = Directory.GetFiles(pathPlease, "*.*", SearchOption.TopDirectoryOnly)[i];
                    FileInfo fiInf = new FileInfo(Directory.GetFiles(pathPlease, "*.*", SearchOption.TopDirectoryOnly)[i]);
                    String fiInfStr = fiInf.Name; 
                    fiInfStr = fiInfStr.Split('.')[0]; */
                    whatEvenIsThis.AutoSize = false;
                    whatEvenIsThis.TextAlign = ContentAlignment.MiddleCenter;
                    whatEvenIsThis.Text = fiInfStr;
                    whatEvenIsThis.ForeColor = Color.White;
                    whatEvenIsThis.Font = new System.Drawing.Font(Properties.Settings.Default.fontsOfScience[Properties.Settings.Default.whoIsThisCrazyDoge], 10);
                    turnip.Controls.Add(whatEvenIsThis);
                    whatEvenIsThis.BringToFront();
                    DoubleBufferManipulation.SetDoubleBuffered(whatEvenIsThis);
                    whatEvenIsThis.Left = 0;
                    whatEvenIsThis.Top = 110;

                    /* app1.Click += hmThatIsAReallyInterestingActionWow;                    
                    turnip.Click += hmThatIsAReallyInterestingActionWow;
                    whatEvenIsThis.Click += hmThatIsAReallyInterestingActionWow; */

                    // Yes, I had to refer to StackOverflow in order to remember how to do this following portion.
                    // Yes, I'm doing that a lot.
                    // Yes, you and my doge are judging me harshly right now.

                    app1.Click += (sender, args) =>
                    {
                        System.Diagnostics.Process.Start(fiInf.FullName);
                    };

                    turnip.Click += (sender, args) =>
                    {
                        System.Diagnostics.Process.Start(fiInf.FullName);
                    };

                    whatEvenIsThis.Click += (sender, args) =>
                    {
                        System.Diagnostics.Process.Start(fiInf.FullName);
                    };

                }


            }

            // Transition.run(spaceForIcons, "Visible", false, true, new TransitionType_EaseInEaseOut(150));
            spaceForIcons.Visible = true;
   
        }

        /* 
         * Deprecated for now on the hopes that some code that was found/integrated actually turns up.
         * 
         * private void hmThatIsAReallyInterestingActionWow(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer");
        } */


        private void iconMatch(string path)
        {
            
            
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timeSpaceContinuum_Click(object sender, EventArgs e)
        {
            // In the references document, make sure you credit this one to Henry Fidel Bradley Post. 
            
            UserSettings snoopdoge = new UserSettings();
            snoopdoge.Show();
            snoopdoge.BringToFront();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            /*
             * UserSettings backInTheUssettings = new UserSettings();
            backInTheUssettings.Show();
            backInTheUssettings.BringToFront();
             * 
             */

            MinervaIntegrated minervuh = new MinervaIntegrated();
            
            minervuh.Show();
            minervuh.BringToFront();

            
        }

        private void spaceForProcesses_Paint(object sender, PaintEventArgs e)
        {
            /*spaceForProcesses.Left = 150;
            spaceForProcesses.Width = spaceForProcesses.Width - 150;

            spaceForProcesses.Top = 850;*/
            spaceForProcesses.BringToFront();

            //spaceForProcesses.Height = bottomPanel.Height;
        }
        
        
        // Well then...looks like we assigned more items here
        
        private const int APPCOMMAND_VOLUME_MUTE = 0x80000;
        private const int APPCOMMAND_VOLUME_UP = 0xA0000;
        private const int APPCOMMAND_VOLUME_DOWN = 0x90000;
        private const int WM_APPCOMMAND = 0x319;
        private void takeTheLongKeyHome(object sender, KeyEventArgs e)
        {
            
            
            
            if (e.KeyCode == Keys.VolumeUp)
            {

            }
            if (e.KeyCode == Keys.Up)
            {
                /* Robert, does this look like the times of XP anymore?
                
                uint meowingDoges;
                waveOutGetVolume(IntPtr.Zero, out meowingDoges);
                meowingDoges = meowingDoges & 0x0000ffff;
                MessageBox.Show(meowingDoges.ToString());*/

                waveOutSetVolume(this.Handle, 0x0000);
                MessageBox.Show(waveOutSetVolume(this.Handle, 0x0000).ToString());
                
                // Well since this already works when Explorer is actually open
                // Guess what is happening now
                // I SWEAR WINDMILL IF THERE IS NO WAY TO CONTROL VOLUME OUTSIDE OF EXPLORER
                // Also that is the first instance of the term Windmill in replacement of Windows in this code
                // Wow that joke has been around with me for so many years now
                
                // Wait, what was I doing?
                // Oh yeah, that's right, commenting out code, here goes...
                SendMessageW(this.Handle, 0x0319, this.Handle, (IntPtr)14);
                
            }
        }

        private void virtualKeyboardsForScienceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VirtualKeyboardsForScience viktorForScience = new VirtualKeyboardsForScience();
            viktorForScience.Show();
            viktorForScience.BringToFront();
        }

        private void thanksScn9AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThanksScn9A t = new ThanksScn9A();
            t.Show();
            t.BringToFront();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BattCritical battCriticalHm = new BattCritical();
            battCriticalHm.Show();
            battCriticalHm.BringToFront();
        }

        private void battLowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BattLow battLowA = new BattLow();
            battLowA.Show();
            battLowA.BringToFront();
        }

        private void customSearchImplementationOneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Call supposed to be made from SlidingMenuBar here 
            CustomSearchImplementationOne yeahThat = new CustomSearchImplementationOne(this.Width);
            yeahThat.Show();
            yeahThat.BringToFront();
        }

        private void rightClickDevStrip_Opening(object sender, CancelEventArgs e)
        {

        }

        private void slidingMenuBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SlidingMenuBar smbagain = new SlidingMenuBar();
            smbagain.Show();
            smbagain.BringToFront();
        }

        public void youMayWantToRepaint()
        {
            this.Refresh();
        }

        private void lockScreenTrueColorsV2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LockScreen_TrueColors_V2 lstcv2 = new LockScreen_TrueColors_V2();
            lstcv2.Show();
            lstcv2.BringToFront();
        }


    }
}
