using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectSnowshoes
{
    public partial class OtherAcc : Form
    {
        public OtherAcc()
        {
            InitializeComponent();
        }

        private void retreat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OtherAcc_Load(object sender, EventArgs e)
        {
            populateUsers();
        }

        // Yeah, yeah, so I should probably make this accept params. We'll see if it happens later on. 
        private void populateUsers()
        {
            // Also shoutout to automatic definition handling 
            // Ah, C#, it's great to be here again.

            // Go through each user
            // (could have also used the count from anything else that holds a user property)
            for (int i = 0; i < Properties.Settings.Default.username.Count; i++)
            {

           
                Panel uA = new Panel();
                uA.Show();
                uA.BackColor = Color.White;
                uA.Left = 0;
                uA.Width = this.Width;
                uA.Height = 50;
                uA.Margin = new Padding(0, 2, 0, 0);
                
                userList.Controls.Add(uA);

                PictureBox pImg = new PictureBox();
                pImg.Image = Image.FromFile(Properties.Settings.Default.userimgacc_path[i]);
                pImg.Left = 0;
                pImg.Width = 50;
                pImg.Height = 50;
                pImg.Dock = DockStyle.Left;
                pImg.BackColor = Color.White;
                pImg.SizeMode = PictureBoxSizeMode.Zoom;
                
                Label turnip = new Label();
                turnip.Show();
                turnip.BackColor = Color.Transparent;
                turnip.AutoEllipsis = true;
                turnip.Left = 64;
                turnip.Width = this.Width - 64 - 50;
                turnip.Height = 50;
                turnip.Top = 0;
                turnip.Font = new System.Drawing.Font(Properties.Settings.Default.fontsOfScience[Properties.Settings.Default.whoIsThisCrazyDoge], 11);
                turnip.ForeColor = Color.DimGray;
                turnip.TextAlign = ContentAlignment.MiddleLeft;
                turnip.Text = Properties.Settings.Default.username[i];

                uA.Controls.Add(pImg);
                uA.Controls.Add(turnip);

                Button dl = new Button();
                dl.Show();
                dl.BackColor = Color.Firebrick;
                
                dl.Width = 50;
                dl.Left = uA.Width - 50;
                dl.Height = 50;
                dl.Dock = DockStyle.Right;

                dl.Font = new System.Drawing.Font(Properties.Settings.Default.fontsOfScience[Properties.Settings.Default.whoIsThisCrazyDoge], 11);
                dl.ForeColor = Color.White;
                dl.TextAlign = ContentAlignment.MiddleCenter;
                dl.Text = "X";

                dl.FlatStyle = FlatStyle.Flat;
                dl.FlatAppearance.BorderSize = 0;
                
                uA.Controls.Add(dl);

                // Shhhhhhhhhhh hidden controls

                Label toDel = new Label();

                toDel.Show();
                toDel.BackColor = Color.Transparent;
                toDel.AutoEllipsis = true;
                toDel.Left = 64;
                toDel.Width = this.Width - 64 - 50;
                toDel.Height = 14;
                toDel.Top = 50;
                toDel.Font = new System.Drawing.Font(Properties.Settings.Default.fontsOfScience[Properties.Settings.Default.whoIsThisCrazyDoge], 11);
                toDel.ForeColor = Color.Red;
                toDel.TextAlign = ContentAlignment.MiddleLeft;
                toDel.Text = "To delete the account, enter a password:";

                uA.Controls.Add(toDel);

                TextBox pBox = new TextBox();
                pBox.Show();
                pBox.BackColor = Color.White;
                pBox.Left = 64;
                pBox.Width = this.Width - 64 - 50;
                pBox.Height = 14;
                pBox.Top = 50;
                pBox.Font = new System.Drawing.Font(Properties.Settings.Default.fontsOfScience[Properties.Settings.Default.whoIsThisCrazyDoge], 11);
                pBox.ForeColor = Color.Red;
                pBox.PasswordChar = '·';


                /* Need this for event usage later
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
                }; */

                dl.Click += (sender, args) =>
                {
                    if (uA.Height != 90)
                    {
                        uA.Height = 90;
                    }
                    else
                    {
                        uA.Height = 50;
                    }
                };

            }
        }

        public void goBackJack()
        {

        }

        
    }
}
