using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.WindowsAPICodePack.Shell;

namespace ProjectSnowshoes
{
    public partial class AppsSlidingMenu : Form
    {
        public AppsSlidingMenu()
        {
            InitializeComponent();
        }

        private void goGenerateTilesFriendship()
        {    
            String pathPlease = @"C:\ProjectSnowshoes\User\" + Properties.Settings.Default.username[Properties.Settings.Default.whoIsThisCrazyDoge] + @"\Apps";
            //String pathPlease = @"C:\Users\Robert\Apps";
            //String pathPlease = @"C:\ProgramData\Microsoft\Windows\Start Menu\Programs";

            for (int i = 0; i < Directory.GetFiles(pathPlease, "*.lnk", SearchOption.AllDirectories).Length; i++)
            {
                

                Panel app1Panel = new Panel();
                app1Panel.Width = 120;
                app1Panel.Height = 120;
                app1Panel.Padding = new Padding(30,40,30,30);

                PictureBox app1 = new PictureBox();
                app1.SizeMode = PictureBoxSizeMode.Zoom;
                app1.Show();
                app1.BackColor = Color.Transparent;
                app1.Left = 42;
                app1.Top = 20;
                app1.Width = 36;
                app1.Height = 36;
                app1.Margin = new Padding(0);
                
                app1Panel.Controls.Add(app1);

                FileInfo fiInf = new FileInfo(Directory.GetFiles(pathPlease, "*.lnk", SearchOption.AllDirectories)[i]);
                String fiInfStr = fiInf.Name;
                fiInfStr = fiInfStr.Split('.')[0];

                Label turnip = new Label();
                turnip.Show();
                turnip.BackColor = Color.Transparent;
                turnip.AutoEllipsis = true;
                turnip.Left = 10;
                turnip.Width = 100;
                turnip.Height = 50;
                turnip.Top = 70;
                turnip.Font = new System.Drawing.Font(Properties.Settings.Default.fontsOfScience[Properties.Settings.Default.whoIsThisCrazyDoge], 9);
                turnip.ForeColor = Color.DimGray;
                turnip.TextAlign = ContentAlignment.TopCenter;
                turnip.Text = fiInfStr;

                IconManager areYouForRealRightNowLikeReallyRealVSWow = new IconManager();
                app1.Image = areYouForRealRightNowLikeReallyRealVSWow.icoExtReturner(fiInf.FullName, fiInfStr, false);
                

                DoubleBufferManipulation.SetDoubleBuffered(turnip);
                app1Panel.Controls.Add(turnip);
                
                app1.Click += (sender, args) =>
                {
                    System.Diagnostics.Process.Start(fiInf.FullName);
                };

                turnip.Click += (sender, args) =>
                {
                    System.Diagnostics.Process.Start(fiInf.FullName);
                };

                app1Panel.Click += (sender, args) =>
                {
                    System.Diagnostics.Process.Start(fiInf.FullName);
                };

                themAppsTho.Controls.Add(app1Panel);

            }

            

        }

        private void AppsSlidingMenu_Load(object sender, EventArgs e)
        {
            themAppsTho.Top = 0;
            
            goGenerateTilesFriendship();
            this.Left = 145;
            this.Top = Screen.PrimaryScreen.WorkingArea.Height - 615;
            this.Height = 615;
        }

        private void inTheaters_Tick(object sender, EventArgs e)
        {
            if (!this.Focused)
            {
                this.Close();
            }
        }
    }
}
