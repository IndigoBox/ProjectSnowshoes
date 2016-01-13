using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImageProcessor;
using System.Reflection;

namespace ProjectSnowshoes
{
    public partial class ObviouslyTurnUpOnAuth : Form
    {
        public ObviouslyTurnUpOnAuth()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        

        private void ObviouslyTurnUpOnAuth_Load(object sender, EventArgs e)
        {

            // For better graphical effects and less flickering, introduce double buffering and better background image usage
            this.BackgroundImageLayout = ImageLayout.None;
            DoubleBufferManipulation.SetDoubleBuffered(panel1);
            


            this.BackgroundImage = Image.FromFile(Properties.Settings.Default.lock_path[Properties.Settings.Default.whoIsThisCrazyDoge]);
            
            accountName.Text = Properties.Settings.Default.username[Properties.Settings.Default.whoIsThisCrazyDoge];

            enterButton.BackColor = Color.FromName(Properties.Settings.Default.custColor[Properties.Settings.Default.whoIsThisCrazyDoge]);

            accountImg.BackgroundImage = Image.FromFile(Properties.Settings.Default.userimgacc_path[Properties.Settings.Default.whoIsThisCrazyDoge]);

            // Huge shoutout to the makers of the ImageProcessor library for this one.

            ImageFactory imgf = new ImageFactory();

            Properties.Resources._20pertrans_lighterGray.Save("C:\\ProjectSnowshoes\\loginbacktemp.png");
            imgf.Load("C:\\ProjectSnowshoes\\loginbacktemp.png");
            imgf.Tint(Color.FromName(Properties.Settings.Default.custColor[Properties.Settings.Default.whoIsThisCrazyDoge]));
            

            panel1.BackgroundImage = imgf.Image;

            

            
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            ohThatThingYeahDoThatThanksFriend();
        }

        private void ohThatThingYeahDoThatThanksFriend()
        {
            if (weKnowWhatThisIs.Text == Properties.Settings.Default.woahThereHello[Properties.Settings.Default.whoIsThisCrazyDoge])
            {
                if (Properties.Settings.Default.loggedIn[Properties.Settings.Default.whoIsThisCrazyDoge] == "false")
                {
                    Space spaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaace = new Space();
                    spaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaace.Show();
                    spaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaace.BringToFront();
                    Properties.Settings.Default.loggedIn[Properties.Settings.Default.whoIsThisCrazyDoge] = "true";
                    this.Close();
                }
                else
                {
                    this.Close();
                }
                
            }
            else
            {
                weKnowWhatThisIs.Text = "";
                ImageFactory imgg = new ImageFactory();
                Properties.Resources._20pertrans_lighterGray.Save("C:\\ProjectSnowshoes\\loginbacktempa.png");
                imgg.Load("C:\\ProjectSnowshoes\\loginbacktempa.png");
                imgg.Tint(Color.DarkRed);
                

                panel1.BackgroundImage = imgg.Image;
                pwdWarning.Visible = true;
            }

            
        }

        private void ObviouslyTurnUpOnAuth_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                ohThatThingYeahDoThatThanksFriend();
            }
        }

        private void weKnowWhatThisIs_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                ohThatThingYeahDoThatThanksFriend();
            }
        }
    }
}
