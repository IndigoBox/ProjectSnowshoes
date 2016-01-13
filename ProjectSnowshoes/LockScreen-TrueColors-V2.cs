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
    public partial class LockScreen_TrueColors_V2 : Form
    {
        public LockScreen_TrueColors_V2()
        {
            InitializeComponent();

        }

        private void foreChargePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataTimer_Tick(object sender, EventArgs e)
        {
            dateLabel.Text = System.DateTime.Today.ToLongDateString();
        }

        private void timeTimer_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = System.DateTime.Now.ToLongTimeString();
        }

        private void LockScreen_TrueColors_V2_Load(object sender, EventArgs e)
        {
            
            
            // Set custom color
            foreChargePanel.BackColor = Color.FromName(Properties.Settings.Default.custColor[Properties.Settings.Default.whoIsThisCrazyDoge]);


            // Set background image
            this.BackgroundImage = Image.FromFile(Properties.Settings.Default.lock_path[Properties.Settings.Default.whoIsThisCrazyDoge]);



            // Charge Level
            float turner = Screen.PrimaryScreen.WorkingArea.Width * SystemInformation.PowerStatus.BatteryLifePercent;
            int turnerInt = (int)Math.Ceiling(turner);

            if (turnerInt > 200)
            {
                foreChargePanel.Width = turnerInt;
                percentRemain.Text = (SystemInformation.PowerStatus.BatteryLifePercent * 100) + "% remaining.";
            }
            else
            {

                percentRemain.Text = (SystemInformation.PowerStatus.BatteryLifePercent * 100) + "% remaining.";

                foreChargePanel.Width = turnerInt;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



    }
}
