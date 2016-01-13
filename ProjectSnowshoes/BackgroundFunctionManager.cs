using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectSnowshoes
{
    public partial class BackgroundFunctionManager : Form
    {

        Boolean l1, l2;

        String mainWindowTitleCurrent;
        
        public BackgroundFunctionManager()
        {
            InitializeComponent();
            l1 = false;
            l2 = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void moreTimersWell_Tick(object sender, EventArgs e)
        {
            batteryManagement();
            //spotifyPullNotification();
        }

        private void spotifyPullNotification()
        {
            foreach (var theProcess in Process.GetProcesses())
            {
                
                    //if ((theProcess.MainModule.FileName.Split('\\')[theProcess.MainModule.FileName.Split('\\').Length - 1] == "spotify.exe") && (theProcess.MainWindowTitle != mainWindowTitleCurrent))
                    if (theProcess.ProcessName == "Spotify" && theProcess.MainWindowTitle != mainWindowTitleCurrent)
                    {
                        mainWindowTitleCurrent = theProcess.MainWindowTitle;
                        String sArtist = mainWindowTitleCurrent.Split('-')[0];
                        //sArtist = sArtist.Remove(sArtist.Length - 2);
                        String sSong = mainWindowTitleCurrent.Replace(mainWindowTitleCurrent.Split('-')[0] + " ", "");
                        Notification yepTheyExistStill = new Notification(sSong, sArtist, Image.FromFile(@"C:\ProjectSnowshoes\System\Media\Icons\Applications\Png\Spotify.png"));
                        yepTheyExistStill.Show();
                        yepTheyExistStill.BringToFront();
                    }
                
                
            }
        }

        private void batteryManagement()
        {
            // Charge Level
            float turner = Screen.PrimaryScreen.WorkingArea.Height * SystemInformation.PowerStatus.BatteryLifePercent;
            int turnerInt = (int)Math.Ceiling(turner);

            if (SystemInformation.PowerStatus.BatteryChargeStatus != BatteryChargeStatus.Charging && SystemInformation.PowerStatus.BatteryLifePercent > 0.08 && SystemInformation.PowerStatus.BatteryLifePercent <= 0.12 && !l1)
            {
                l1 = true;
                BattLow nbl = new BattLow();
                nbl.Show();
                nbl.BringToFront();
            }
            else if (SystemInformation.PowerStatus.BatteryChargeStatus != BatteryChargeStatus.Charging && SystemInformation.PowerStatus.BatteryLifePercent <= 0.08 && !l2)
            {
                l2 = true;
                BattCritical bcr = new BattCritical();
                bcr.Show();
                bcr.BringToFront();
            }
            else if (SystemInformation.PowerStatus.BatteryLifePercent > 0.12 || SystemInformation.PowerStatus.BatteryChargeStatus == BatteryChargeStatus.Charging)
            {
                l1 = l2 = false;
            }
        }

        private void BackgroundFunctionManager_Load(object sender, EventArgs e)
        {

        }
    }
}
