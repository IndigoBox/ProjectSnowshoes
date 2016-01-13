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
    public partial class PrelimSetup : Form
    {
        public PrelimSetup()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void PrelimSetup_Load(object sender, EventArgs e)
        {

        }

        private void goFriendGoAgain_Click(object sender, EventArgs e)
        {
            /* With The Bridge, not sure if this is going to be necessary anymore.
             * 
             * Properties.Settings.Default.space_back_path = spPath.Text;
            Properties.Settings.Default.lock_path = lpPath.Text;
            Properties.Settings.Default.userimgacc_path = apPath.Text;

            Properties.Settings.Default.custColor = accColors.BackColor;
            Properties.Settings.Default.nickname = nickname.Text;
            Properties.Settings.Default.username = userName.Text;
            Properties.Settings.Default.woahThereHello = shhhhhhhhh.Text;

             */

            Properties.Settings.Default.runTimes = true;
            Properties.Settings.Default.Save();

            Form1 shouldRenameThatFormSeriously = new Form1();
            shouldRenameThatFormSeriously.Show();
            shouldRenameThatFormSeriously.BringToFront();

            

            this.Hide();
        }

        private void accColors_Click(object sender, EventArgs e)
        {
            ColorDialog cdlg = new ColorDialog();
            if (cdlg.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.custColor[Properties.Settings.Default.whoIsThisCrazyDoge] = cdlg.Color.Name;
                accColors.BackColor = cdlg.Color;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdlg = new OpenFileDialog();
            if (ofdlg.ShowDialog() == DialogResult.OK)
            {
                apPath.Text = ofdlg.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdlg = new OpenFileDialog();
            if (ofdlg.ShowDialog() == DialogResult.OK)
            {
                lpPath.Text = ofdlg.FileName;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdlg = new OpenFileDialog();
            if (ofdlg.ShowDialog() == DialogResult.OK)
            {
                spPath.Text = ofdlg.FileName;
            }
        }
    }
}
