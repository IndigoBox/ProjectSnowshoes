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

namespace ProjectSnowshoes
{
    public partial class ImagesOnMenu : Form
    {
        public ImagesOnMenu()
        {
            InitializeComponent();
        }

        private void ImagesOnMenu_Load(object sender, EventArgs e)
        {
            base.Left = 0x91;
            base.Top = Screen.PrimaryScreen.WorkingArea.Height - 0x267;
            base.Height = 0x267;
            base.Width = 420;
            this.seriousNamesComeOnRobert("*.png");
            this.seriousNamesComeOnRobert("*.jpg");
            this.seriousNamesComeOnRobert("*.bmp");
            this.seriousNamesComeOnRobert("*.gif");
        }

        private void seriousNamesComeOnRobert(string fileExt)
        {
            string path = @"C:\ProjectSnowshoes\User\" + Properties.Settings.Default.username[Properties.Settings.Default.whoIsThisCrazyDoge] + @"\Pictures";
            for (int i = 0; i < Directory.GetFiles(path, fileExt, SearchOption.AllDirectories).Length; i++)
            {
                FileInfo fiInf = new FileInfo(Directory.GetFiles(path, fileExt, SearchOption.AllDirectories)[i]);
                char[] separator = new char[] { '.' };
                string str2 = fiInf.Name.Split(separator)[0];
                Panel panel = new Panel();
                panel.Show();
                panel.BackColor = Color.Transparent;
                panel.Left = 0;
                panel.Width = 180;
                panel.Height = 110;
                panel.Margin = new Padding(10);
                this.imagePanel.Controls.Add(panel);
                PictureBox box = new PictureBox();
                box.Show();
                box.Width = 160;
                box.Height = 90;
                box.Left = 10;
                box.BackgroundImage = Image.FromFile(fiInf.FullName);
                box.BackgroundImageLayout = ImageLayout.Zoom;
                panel.Controls.Add(box);
                Label label = new Label();
                label.Show();
                label.Width = 170;
                label.AutoEllipsis = true;
                label.Height = 14;
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.Font = new Font(Properties.Settings.Default.fontsOfScience[Properties.Settings.Default.whoIsThisCrazyDoge], 11f);
                label.BackColor = Color.Transparent;
                label.ForeColor = Color.DarkGray;
                label.Left = 5;
                label.Text = str2;
                label.Top = 0x5d;
                panel.Controls.Add(label);
                panel.Click += (senderA, args) => Process.Start(fiInf.FullName);
                box.Click += (senderA, args) => Process.Start(fiInf.FullName);
                label.Click += (senderA, args) => Process.Start(fiInf.FullName);
            }
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
