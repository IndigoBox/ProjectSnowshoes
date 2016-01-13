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
    public partial class NewAccount_New1 : Form
    {
        public NewAccount_New1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Transition.run(ohHeyThere, "Left", 0 - this.Width, new TransitionType_Linear(120));
            Transition.run(dogesInTheOffice, "Left", 0 - this.Width, new TransitionType_Linear(120));
            Transition.run(chc5, "Left", 0 - this.Width, new TransitionType_Linear(120));
            Transition.run(chcMostTimes, "Left", 0 - this.Width, new TransitionType_Linear(120));

            NewAccount_New2 movingOn = new NewAccount_New2();
            movingOn.Show();
            movingOn.BringToFront();

            Hide();
        }

        private void chcMostTimes_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewAccount_New1_Load(object sender, EventArgs e)
        {

        }
    }
}
