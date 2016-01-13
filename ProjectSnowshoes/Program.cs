using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectSnowshoes
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            /* Not yet: Disabled for skipped debug purposes in The Bridge Build.
             * Change confirmed 10142014 1940hrs
             * 
             * if (!Properties.Settings.Default.runTimes)
            {
                Application.Run(new PrelimSetup());
            }
            else
            {
                Application.Run(new Form1());
            }
             * 
             */

            //Application.Run(new Form1());
            //Application.Run(new LockScreen_TrueColors_V2());

            // Guess what's back again!
            if (Properties.Settings.Default.username.Count != 0)
            {
                if (!System.IO.Directory.Exists(@"C:\ProjectSnowshoes\User\" + Properties.Settings.Default.username[0]))
                {
                    
                    Properties.Settings.Default.custColor.Clear();
                    Properties.Settings.Default.darkerFontsOfScience.Clear();
                    Properties.Settings.Default.emailList.Clear();
                    Properties.Settings.Default.fontsOfScience.Clear();
                    Properties.Settings.Default.lock_path.Clear();
                    Properties.Settings.Default.loggedIn.Clear();
                    Properties.Settings.Default.nickname.Clear();
                    Properties.Settings.Default.runTimes = false;
                    Properties.Settings.Default.space_back_path.Clear();
                    Properties.Settings.Default.userimg_path.Clear();
                    Properties.Settings.Default.userimgacc_path.Clear();
                    Properties.Settings.Default.username.Clear();
                    Properties.Settings.Default.woahThereHello.Clear();
                    Properties.Settings.Default.youAreTheSpecial.Clear();
                    Properties.Settings.Default.youAreTheSpecialOrganization.Clear();
                    Properties.Settings.Default.Save();
                }
            }
            if (!Properties.Settings.Default.runTimes)
            {
                Application.Run(new NewAccount_New1());
            }
            else
            {
                Application.Run(new Form1());
            }


        }
    }
}
