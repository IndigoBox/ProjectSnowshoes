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
    public partial class ObviouslyTurnUpOnLogIn : Form  
    {

        

        public ObviouslyTurnUpOnLogIn()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        private void timeTimer_Tick(object sender, EventArgs e)
        {
            time.Text = System.DateTime.Now.ToShortTimeString();
        }

        private void dataTimer_Tick(object sender, EventArgs e)
        {
            date.Text = System.DateTime.Today.DayOfWeek + "\n" + System.DateTime.Now.ToString("MMMM") +" " + System.DateTime.Today.Day + "\n" + System.DateTime.Today.Year;
        }
        
        private void TurnDown_KeyDown(object sender, KeyEventArgs e)
        {
            ObviouslyTurnUpOnAuth auth = new ObviouslyTurnUpOnAuth();
            auth.Show();
            auth.BringToFront();
            this.Close();
        }


        private void ObviouslyTurnUpOnLogIn_Load(object sender, EventArgs e)
        {

            
            
            
            // Set custom color
            foreChargePanel.BackColor = Color.FromName(Properties.Settings.Default.custColor[Properties.Settings.Default.whoIsThisCrazyDoge]);


            // Set background image
            this.BackgroundImage = Image.FromFile(Properties.Settings.Default.lock_path[Properties.Settings.Default.whoIsThisCrazyDoge]);



            // Charge Level
            float turner = this.Height * SystemInformation.PowerStatus.BatteryLifePercent;
            int turnerInt = (int)Math.Ceiling(turner);

            if (turnerInt > 200)
            {
                foreChargePanel.Height = turnerInt;
                percentRemain.Text = (SystemInformation.PowerStatus.BatteryLifePercent * 100) + "% remaining.";
            }
            else
            {

                time.Top = Screen.PrimaryScreen.WorkingArea.Height - 400;
                date.Top = Screen.PrimaryScreen.WorkingArea.Height - 340;
                percentRemain.Text = (SystemInformation.PowerStatus.BatteryLifePercent * 100) + "% remaining.";




                foreChargePanel.Height = turnerInt;
            }









        }
    }
}
