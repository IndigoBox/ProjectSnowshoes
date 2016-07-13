using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transitions;

namespace ProjectSnowshoes
{
    public partial class ChangeBackground : Form
    {

        bool panelClicked;

        public ChangeBackground()
        {
            InitializeComponent();
        }

        private void ChangeBackground_Load(object sender, EventArgs e)
        {
            pathText.Text = Properties.Settings.Default.space_back_path[Properties.Settings.Default.whoIsThisCrazyDoge];
            chooseWiselyWelcome.BackColor = Color.FromName(Properties.Settings.Default.custColor[Properties.Settings.Default.whoIsThisCrazyDoge]);
            finalizeButton.BackColor = Color.FromName(Properties.Settings.Default.custColor[Properties.Settings.Default.whoIsThisCrazyDoge]);
            browsePathButton.BackColor = Color.FromName(Properties.Settings.Default.custColor[Properties.Settings.Default.whoIsThisCrazyDoge]);
            greeting.Text = "Choose wisely, " + Properties.Settings.Default.nickname[Properties.Settings.Default.whoIsThisCrazyDoge] + ".";

            colorPanel.BackColor = Color.FromName(Properties.Settings.Default.custColor[Properties.Settings.Default.whoIsThisCrazyDoge]);
            spaceImg.Image = Image.FromFile(pathText.Text);
            colorPanel.Text = Properties.Settings.Default.custColor[Properties.Settings.Default.whoIsThisCrazyDoge];

            panelClicked = false;
        }

        private void finalizeButton_Click(object sender, EventArgs e)
        {
            
            Properties.Settings.Default.space_back_path[Properties.Settings.Default.whoIsThisCrazyDoge] = pathText.Text;
            Properties.Settings.Default.custColor[Properties.Settings.Default.whoIsThisCrazyDoge] = colorPanel.Text;
            Properties.Settings.Default.Save();

            /*Space spaaaaaaaaaaaaaaaaaaace1 = new Space();
            spaaaaaaaaaaaaaaaaaaace1.Show();
            spaaaaaaaaaaaaaaaaaaace1.Show();*/
            
            //Space.ActiveForm.BackgroundImage = Image.FromFile(Properties.Settings.Default.space_back_path[Properties.Settings.Default.whoIsThisCrazyDoge]);
            for (int i = 0; i < Application.OpenForms.Count; i++)
            {
                finalizeButton.Text = finalizeButton.Text + Application.OpenForms[i].Name;
                if (Application.OpenForms[i].Name == "Space") {
                    Application.OpenForms[i].Controls.Find("panel1",true)[0].BackgroundImage = Image.FromFile(pathText.Text);
                }
                else if (Application.OpenForms[i].Name == "BottomBar_Concept124")
                {
                    Application.OpenForms[i].Controls.Find("name", true)[0].BackColor = Color.FromName(colorPanel.Text);
                }

            }

            this.Close();

        }

        private void browsePathButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdlg = new OpenFileDialog();
            ofdlg.Filter = "Image Files (*.bmp, *.jpg, *.png, *.gif)|*.bmp;*.jpg;*.png;*.gif";
            if (ofdlg.ShowDialog() == DialogResult.OK)
            {
                pathText.Text = ofdlg.FileName;
                spaceImg.Image = Image.FromFile(pathText.Text);
            }
        }

        private void colorPanel_Click(object sender, EventArgs e)
        {

            // Only run if the panel is not already active 

            if (!panelClicked)
            {

                panelClicked = true;
                
                // Regular: 571px width
                // Extended: 840px width

                Transition.run(this, "Width", this.Width, this.Width + 269, new TransitionType_Acceleration(340));

                // 141 supported colors with Transparent included here

                for (int lVar = 0; lVar < Properties.Settings.Default.allThePrettyColorsHere.Count; lVar++)
                {
                    // These names may not be exciting...my apologies for that, my turnt doges. 

                    Panel panel1 = new Panel();
                    panel1.Width = colorLayoutPanel.Width;
                    panel1.Height = 30;

                    Label theCol = new Label();
                    theCol.Height = 30;
                    theCol.Width = 30;
                    theCol.Left = 0;

                    Label theName = new Label();
                    theName.Height = 30;
                    theName.Left = 30;
                    theName.Width = colorLayoutPanel.Width - 30;
                    theName.TextAlign = ContentAlignment.MiddleLeft;
                    theName.Font = new System.Drawing.Font(Properties.Settings.Default.fontsOfScience[Properties.Settings.Default.whoIsThisCrazyDoge], 12);
                    theName.ForeColor = Color.DarkGray;

                    theCol.BackColor = Color.FromName(Properties.Settings.Default.allThePrettyColorsHere[lVar]);
                    theName.Text = Properties.Settings.Default.allThePrettyColorsHere[lVar];

                    panel1.Controls.Add(theCol);
                    panel1.Controls.Add(theName);

                    colorLayoutPanel.Controls.Add(panel1);

                    theCol.Click += (senderA, args) =>
                    {
                        /*hmGreatJobFantasticAmazing.ImageAlign = ContentAlignment.MiddleCenter;
                        hmGreatJobFantasticAmazing.AutoEllipsis = false;
                        hmGreatJobFantasticAmazing.Width = 40;
                        hmGreatJobFantasticAmazing.BackColor = Color.Transparent;
                        //hmGreatJobFantasticAmazing.Font = new System.Drawing.Font(Properties.Settings.Default.fontsOfScience[Properties.Settings.Default.whoIsThisCrazyDoge], 14, FontStyle.Regular);
                        //hmGreatJobFantasticAmazing.ForeColor = Color.White;

                        hmGreatJobFantasticAmazing.TextAlign = ContentAlignment.MiddleLeft;
                        hmGreatJobFantasticAmazing.Text = "";*/

                        colorPanel.BackColor = Color.FromName(theName.Text);
                        colorPanel.Text = theName.Text;

                        colorLayoutPanel.Controls.Clear();

                        Transition.run(this, "Width", this.Width, this.Width - 269, new TransitionType_Acceleration(340));
                        panelClicked = false;
                    };

                    theName.Click += (senderA, args) =>
                    {
                        /*hmGreatJobFantasticAmazing.ImageAlign = ContentAlignment.MiddleCenter;
                        hmGreatJobFantasticAmazing.AutoEllipsis = false;
                        hmGreatJobFantasticAmazing.Width = 40;
                        hmGreatJobFantasticAmazing.BackColor = Color.Transparent;
                        //hmGreatJobFantasticAmazing.Font = new System.Drawing.Font(Properties.Settings.Default.fontsOfScience[Properties.Settings.Default.whoIsThisCrazyDoge], 14, FontStyle.Regular);
                        //hmGreatJobFantasticAmazing.ForeColor = Color.White;

                        hmGreatJobFantasticAmazing.TextAlign = ContentAlignment.MiddleLeft;
                        hmGreatJobFantasticAmazing.Text = "";*/

                        colorPanel.BackColor = Color.FromName(theName.Text);
                        colorPanel.Text = theName.Text;

                        colorLayoutPanel.Controls.Clear();

                        Transition.run(this, "Width", this.Width, this.Width - 269, new TransitionType_Acceleration(340));
                        panelClicked = false;
                    };
                }

            }


        }
    }
}
