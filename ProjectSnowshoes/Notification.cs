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
    public partial class Notification : Form
    {

        String title;
        String subtitle;
        Image image;
        int fordFiveHundred = 0;

        public Notification(string titleA, string subtitleA, Image imageA)
        {
            InitializeComponent();
            title = titleA;
            subtitle = subtitleA;
            image = imageA;
        }

        private void Notification_Load(object sender, EventArgs e)
        {
            notifTitle.Text = title;
            notifSubtitle.Text = subtitle;
            notifIcon.Image = image;

            this.Top = -100;
            Transition.run(this, "Top", 0, new TransitionType_EaseInEaseOut(300));
            
            this.Left = 0;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;


        }

        private void notificationTimer_Tick(object sender, EventArgs e)
        {
            fordFiveHundred++;
            if (fordFiveHundred >= 200)
            {
                Transition.run(this, "Top", -100, new TransitionType_EaseInEaseOut(100));
                //this.Hide();
            }
        }
    }
}
