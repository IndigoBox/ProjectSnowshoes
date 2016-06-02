using ImageProcessor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectSnowshoes
{
    public partial class MultipleUsersMain : Form
    {

        int intSel = 0;

        

        public MultipleUsersMain()
        {
            InitializeComponent();
            DoubleBuffered = true;
            

        }

        


        private void MultipleUsersMain_Load(object sender, EventArgs e)
        {

            
            this.BackgroundImageLayout = ImageLayout.None;
            DoubleBufferManipulation.SetDoubleBuffered(panel1);
            DoubleBufferManipulation.SetDoubleBuffered(u0);
            DoubleBufferManipulation.SetDoubleBuffered(u1);
            DoubleBufferManipulation.SetDoubleBuffered(u2);
            DoubleBufferManipulation.SetDoubleBuffered(u3);
            DoubleBufferManipulation.SetDoubleBuffered(u4);

            

            
            
            

            if (Properties.Settings.Default.username.Count == 5)
            {
                activateZero();
                activateOne();
                activateTwo();
                activateThree();
                activateFour();
            }
            else if (Properties.Settings.Default.username.Count == 4)
            {
                activateZero();
                activateOne();
                activateTwo();
                activateThree();
            }
            else if (Properties.Settings.Default.username.Count == 3)
            {
                activateZero();
                activateOne();
                activateTwo();
            }
            else if (Properties.Settings.Default.username.Count == 2)
            {
                activateZero();
                activateOne();
            }
            else
            {
                activateZero();
            }
        }

        private void activateZero()
        {
            up0.Visible = true;
            u0.Visible = true;

            u0.ForeColor = Color.FromName(Properties.Settings.Default.custColor[0]);
            //up0.BackColor = Color.FromName(Properties.Settings.Default.custColor[0]);

            u0.Text = Properties.Settings.Default.username[0];
            up0.BackgroundImage = Image.FromFile(Properties.Settings.Default.userimgacc_path[0]);
        }

        private void activateOne()
        {
            up1.Visible = true;
            u1.Visible = true;

            u1.ForeColor = Color.FromName(Properties.Settings.Default.custColor[1]);
            //up1.BackColor = Color.FromName(Properties.Settings.Default.custColor[1]);

            u1.Text = Properties.Settings.Default.username[1];
            up1.BackgroundImage = Image.FromFile(Properties.Settings.Default.userimgacc_path[1]);
        }

        private void activateTwo()
        {
            up2.Visible = true;
            u2.Visible = true;

            u2.ForeColor = Color.FromName(Properties.Settings.Default.custColor[2]);
            //up2.BackColor = Color.FromName(Properties.Settings.Default.custColor[2]);

            u2.Text = Properties.Settings.Default.username[2];
            up2.BackgroundImage = Image.FromFile(Properties.Settings.Default.userimgacc_path[2]);
        }

        private void activateThree()
        {
            up3.Visible = true;
            u3.Visible = true;

            u3.ForeColor = Color.FromName(Properties.Settings.Default.custColor[3]);
            //up3.BackColor = Color.FromName(Properties.Settings.Default.custColor[3]);

            u3.Text = Properties.Settings.Default.username[3];
            up3.BackgroundImage = Image.FromFile(Properties.Settings.Default.userimgacc_path[3]);
        }

        private void activateFour()
        {
            up4.Visible = true;
            u4.Visible = true;

            u4.ForeColor = Color.FromName(Properties.Settings.Default.custColor[4]);
            //up4.BackColor = Color.FromName(Properties.Settings.Default.custColor[4]);

            u4.Text = Properties.Settings.Default.username[4];
            up4.BackgroundImage = Image.FromFile(Properties.Settings.Default.userimgacc_path[4]);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void selectUserName(object sender, EventArgs e)
        {
            if (sender == u0 || sender == up0)
            {
                Properties.Settings.Default.whoIsThisCrazyDoge = 0;
                ObviouslyTurnUpOnAuth o0 = new ObviouslyTurnUpOnAuth();
                o0.Show();
                o0.BringToFront();
            }
            else if (sender == u1 || sender == up1)
            {
                Properties.Settings.Default.whoIsThisCrazyDoge = 1;
                ObviouslyTurnUpOnAuth o1 = new ObviouslyTurnUpOnAuth();
                o1.Show();
                o1.BringToFront();
            }
            else if (sender == u2 || sender == up2)
            {
                Properties.Settings.Default.whoIsThisCrazyDoge = 2;
                ObviouslyTurnUpOnAuth o2 = new ObviouslyTurnUpOnAuth();
                o2.Show();
                o2.BringToFront();
            }
            else if (sender == u3 || sender == up3)
            {
                Properties.Settings.Default.whoIsThisCrazyDoge = 3;
                ObviouslyTurnUpOnAuth o3 = new ObviouslyTurnUpOnAuth();
                o3.Show();
                o3.BringToFront();
            }
            else if (sender == u4 || sender == up4)
            {
                Properties.Settings.Default.whoIsThisCrazyDoge = 4;
                ObviouslyTurnUpOnAuth o4 = new ObviouslyTurnUpOnAuth();
                o4.Show();
                o4.BringToFront();
            }

        }


        private void themStylesTho(object sender, EventArgs e)
        {

            Properties.Resources._20pertrans_lighterGray.Save("C:\\ProjectSnowshoes\\mttemp.png");

            if (sender == u0 || sender == up0)
            {
                ImageFactory imgf = new ImageFactory();
                
                imgf.Load("C:\\ProjectSnowshoes\\mttemp.png");
                this.BackgroundImage = Image.FromFile(Properties.Settings.Default.lock_path[0]);
                imgf.Tint(Color.FromName(Properties.Settings.Default.custColor[0]));
                //imgf.Save("C:\\ProjectSnowshoes\\mttemp0.png");
                
                panel1.BackgroundImage = imgf.Image;

                u0.ForeColor = Color.White;
                u1.ForeColor = Color.Gray;
                u2.ForeColor = Color.Gray;
                u3.ForeColor = Color.Gray;
                u4.ForeColor = Color.Gray;
            }
            else if (sender == u1 || sender == up1)
            {

                ImageFactory imgg = new ImageFactory();
                
                imgg.Load("C:\\ProjectSnowshoes\\mttemp.png"); 
                this.BackgroundImage = Image.FromFile(Properties.Settings.Default.lock_path[1]);
                imgg.Tint(Color.FromName(Properties.Settings.Default.custColor[1]));
                //imgg.Save("C:\\ProjectSnowshoes\\mttemp1.png");
                panel1.BackgroundImage = imgg.Image;

                u1.ForeColor = Color.White;
                u0.ForeColor = Color.Gray;
                u2.ForeColor = Color.Gray;
                u3.ForeColor = Color.Gray;
                u4.ForeColor = Color.Gray;
            }
            else if (sender == u2 || sender == up2)
            {
                ImageFactory imgi = new ImageFactory();
                
                imgi.Load("C:\\ProjectSnowshoes\\mttemp.png");
                this.BackgroundImage = Image.FromFile(Properties.Settings.Default.lock_path[2]);
                imgi.Tint(Color.FromName(Properties.Settings.Default.custColor[2]));
                //imgi.Save("C:\\ProjectSnowshoes\\mttemp2.png");
                panel1.BackgroundImage = imgi.Image;

                u2.ForeColor = Color.White;
                u1.ForeColor = Color.Gray;
                u0.ForeColor = Color.Gray;
                u3.ForeColor = Color.Gray;
                u4.ForeColor = Color.Gray;
            }
            else if (sender == u3 || sender == up3)
            {
                ImageFactory imgh = new ImageFactory();
                
                imgh.Load("C:\\ProjectSnowshoes\\mttemp.png");
                this.BackgroundImage = Image.FromFile(Properties.Settings.Default.lock_path[3]);
                imgh.Tint(Color.FromName(Properties.Settings.Default.custColor[3]));
                //imgh.Save("C:\\ProjectSnowshoes\\mttemp3.png");
                panel1.BackgroundImage = imgh.Image;

                u3.ForeColor = Color.White;
                u1.ForeColor = Color.Gray;
                u2.ForeColor = Color.Gray;
                u0.ForeColor = Color.Gray;
                u4.ForeColor = Color.Gray;
            }
            else if (sender == u4 || sender == up4)
            {
                ImageFactory imgj = new ImageFactory();
                
                imgj.Load("C:\\ProjectSnowshoes\\mttemp.png");
                this.BackgroundImage = Image.FromFile(Properties.Settings.Default.lock_path[4]);
                imgj.Tint(Color.FromName(Properties.Settings.Default.custColor[4]));
                //imgj.Save("C:\\ProjectSnowshoes\\mttemp4.png");
                panel1.BackgroundImage = imgj.Image;

                u4.ForeColor = Color.White;
                u1.ForeColor = Color.Gray;
                u2.ForeColor = Color.Gray;
                u3.ForeColor = Color.Gray;
                u0.ForeColor = Color.Gray;
            }
        }

        

    }
}
