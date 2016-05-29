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

                /*  The following has not been edited fully from the Documents.cs file, so please don't treat as actually working 

                (This part, with Button uA, has received some modifications.) */
                Panel uA = new Panel();
                uA.Show();
                uA.BackColor = Color.Transparent;
                uA.Left = 0;
                uA.Width = this.Width;
                uA.Height = 50;
                uA.Margin = new Padding(0);
                
                userList.Controls.Add(uA);

                PictureBox pImg = new PictureBox();
                pImg.Image = Image.FromFile(Properties.Settings.Default.userimgacc_path[i]);
                pImg.Left = 0;
                pImg.Width = 50;
                pImg.Height = 50;
                pImg.Dock = DockStyle.Left;
                
                Label turnip = new Label();
                turnip.Show();
                turnip.BackColor = Color.Transparent;
                turnip.AutoEllipsis = true;
                turnip.Left = 64;
                turnip.Width = this.Width - 64;
                turnip.Height = 50;
                turnip.Top = 0;
                turnip.Font = new System.Drawing.Font(Properties.Settings.Default.fontsOfScience[Properties.Settings.Default.whoIsThisCrazyDoge], 11);
                turnip.ForeColor = Color.DimGray;
                turnip.TextAlign = ContentAlignment.MiddleLeft;
                turnip.Text = Properties.Settings.Default.username[i];

                uA.Controls.Add(pImg);
                uA.Controls.Add(turnip);


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

            }
        }

        

        
    }
}
