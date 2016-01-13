using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectSnowshoes
{
    public partial class Documents : Form
    {
        public Documents()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void goGenerateTilesFriendship()
        {

            String pathPlease = @"C:\ProjectSnowshoes\User\" + Properties.Settings.Default.username[Properties.Settings.Default.whoIsThisCrazyDoge] + @"\Documents";
            //String pathPlease = @"C:\Users\Robert\Documents";

            for (int i = 0; i < Directory.GetFiles(pathPlease, "*.*", SearchOption.TopDirectoryOnly).Length; i++)
            {
                
                Button doc1 = new Button();
                doc1.Show();
                doc1.BackColor = Color.Transparent;
                doc1.Left = 0;
                doc1.Width = this.Width - 17;
                doc1.Height = openDocsWinExp.Height;
                doc1.Margin = new Padding(0);
                doc1.FlatStyle = FlatStyle.Flat;
                doc1.FlatAppearance.BorderSize = 0;
                doc1.TextAlign = ContentAlignment.MiddleLeft;
                doc1.ImageAlign = ContentAlignment.MiddleLeft;
                
                themDocsTho.Controls.Add(doc1);

                FileInfo fiInf = new FileInfo(Directory.GetFiles(pathPlease, "*.*", SearchOption.TopDirectoryOnly)[i]);
                String fiInfStr = fiInf.Name;
                fiInfStr = fiInfStr.Split('.')[0];

                Label turnip = new Label();
                turnip.Show();
                turnip.BackColor = Color.Transparent;
                turnip.AutoEllipsis = true;
                turnip.Left = 64;
                turnip.Width = doc1.Width - 64;
                turnip.Height = doc1.Height;
                turnip.Top = 0;
                turnip.Font = new System.Drawing.Font(Properties.Settings.Default.fontsOfScience[Properties.Settings.Default.whoIsThisCrazyDoge], 11);
                turnip.ForeColor = Color.DimGray;
                turnip.TextAlign = ContentAlignment.MiddleLeft;
                turnip.Text = fiInfStr;

                IconManager areYouForRealRightNowLikeReallyRealVSWow = new IconManager();
                doc1.Image = areYouForRealRightNowLikeReallyRealVSWow.icoExtReturner(fiInf.FullName, fiInfStr, false);

                DoubleBufferManipulation.SetDoubleBuffered(turnip);
                doc1.Controls.Add(turnip);
                
                doc1.Click += (sender, args) =>
                {
                    System.Diagnostics.Process.Start(fiInf.FullName);
                };

                turnip.Click += (sender, args) =>
                {
                    System.Diagnostics.Process.Start(fiInf.FullName);
                };

            }



        }

        private void Documents_Load(object sender, EventArgs e)
        {
            themDocsTho.Top = 0;
            themDocsTho.Height = 615 - openDocsWinExp.Height;

            openDocsWinExp.Image = Icon.ExtractAssociatedIcon(@"C:\Windows\explorer.exe").ToBitmap();

            goGenerateTilesFriendship();
            this.Left = 145;
            this.Top = Screen.PrimaryScreen.WorkingArea.Height - 615;
            this.Height = 615;
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
