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
    public partial class WoahWoahWoah : Form
    {
        public WoahWoahWoah()
        {
            InitializeComponent();
        }

        private void WoahWoahWoah_Load(object sender, EventArgs e)
        {
            surePlusName.Text = "Are you sure about this, " + Properties.Settings.Default.nickname[Properties.Settings.Default.whoIsThisCrazyDoge] + "?";

            thisIsWhereThatGoes.Left = this.Width;
            getBackTwo.Left = this.Width;
            TheScienceIsRealButTheCheckmarksAreTheoretical.Left = this.Width + thisIsWhereThatGoes.Width + 6;

        }

        private void goOnWithIt_Click(object sender, EventArgs e)
        {
            subCaption.Text = "Alright. Just show us your password, make sure no other Snowshoes users are logged in, and we'll let you go.";
            int initLeft = goOnWithIt.Left;
            int theDistance = thisIsWhereThatGoes.Left - initLeft;
            Transition.run(goOnWithIt, "Left", goOnWithIt.Left, -317, new TransitionType_Linear(100));
            Transition.run(goBack, "Top", goBack.Top, goBack.Top + 100, new TransitionType_Linear(100));
            Transition.run(thisIsWhereThatGoes, "Left", thisIsWhereThatGoes.Left, initLeft, new TransitionType_Linear(100));
            Transition.run(TheScienceIsRealButTheCheckmarksAreTheoretical, "Left", TheScienceIsRealButTheCheckmarksAreTheoretical.Left, 
                TheScienceIsRealButTheCheckmarksAreTheoretical.Left - theDistance, new TransitionType_Linear(100));
            goBack.Text = "Just kidding. Take me back!"; // In a project full of references and puns, why is this not named getBack?
        }

        private void TheScienceIsRealButTheCheckmarksAreTheoretical_Click(object sender, EventArgs e)
        {
            int initLeftTwo = thisIsWhereThatGoes.Left;
            
            if (thisIsWhereThatGoes.Text == Properties.Settings.Default.woahThereHello[Properties.Settings.Default.whoIsThisCrazyDoge])
            {
                surePlusName.Text = "Take care, " + Properties.Settings.Default.nickname[Properties.Settings.Default.whoIsThisCrazyDoge] + "!";
                subCaption.Text = "Thanks for using Project Snowshoes. Hopefully we'll see you back some day!";
                Transition.run(goBack, "Left", goBack.Left, -317, new TransitionType_Linear(100));
                // Not actually, though! Some events need to happen here


                // Close other Snowshoes forms
                for (int i = 1; i < Application.OpenForms.Count - 1; i++)
                {
                    Application.OpenForms[i].Close();
                }

                

                // Actually remove the data

                System.IO.Directory.Delete(@"C:\ProjectSnowshoes\User\" + Properties.Settings.Default.username[Properties.Settings.Default.whoIsThisCrazyDoge],true);

                Properties.Settings.Default.custColor.RemoveAt(Properties.Settings.Default.whoIsThisCrazyDoge);
                Properties.Settings.Default.lock_path.RemoveAt(Properties.Settings.Default.whoIsThisCrazyDoge);
                Properties.Settings.Default.loggedIn.RemoveAt(Properties.Settings.Default.whoIsThisCrazyDoge);
                Properties.Settings.Default.nickname.RemoveAt(Properties.Settings.Default.whoIsThisCrazyDoge);
                Properties.Settings.Default.space_back_path.RemoveAt(Properties.Settings.Default.whoIsThisCrazyDoge);
                Properties.Settings.Default.userimgacc_path.RemoveAt(Properties.Settings.Default.whoIsThisCrazyDoge);
                Properties.Settings.Default.username.RemoveAt(Properties.Settings.Default.whoIsThisCrazyDoge);
                Properties.Settings.Default.woahThereHello.RemoveAt(Properties.Settings.Default.whoIsThisCrazyDoge);
                Properties.Settings.Default.fontsOfScience.RemoveAt(Properties.Settings.Default.whoIsThisCrazyDoge);
                Properties.Settings.Default.darkerFontsOfScience.RemoveAt(Properties.Settings.Default.whoIsThisCrazyDoge);
                Properties.Settings.Default.Save();
 

                // Alright, now you can go

                Transition.run(getBackTwo, "Left", getBackTwo.Left, initLeftTwo, new TransitionType_Linear(100));
                
            }
            else
            {
                surePlusName.Text = "That password won't work.";
                subCaption.Text = "Perhaps it is a sign not to leave yet. Try again, if you wish.";
            }
        }

        private void getBackTwo_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.username.Count != 0)
            {
                MultipleUsersMain mewMew = new MultipleUsersMain();
                mewMew.Show();
            }
            else
            {
                NewAccount_New1 notANumber = new NewAccount_New1();
                notANumber.Show();
            }
            this.Close();
            
        }

        private void goBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
