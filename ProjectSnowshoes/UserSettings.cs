using ImageProcessor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectSnowshoes
{
    public partial class UserSettings : Form
    {

        String proPicToSet, accLockToSet;

        public UserSettings()
        {
            InitializeComponent();
        }

        [DllImport("user32")]
        static extern bool AnimateWindow(IntPtr hwnd, int time, int flags);

        private void UserSettings_Load(object sender, EventArgs e)
        {

            

            this.Top = Screen.PrimaryScreen.WorkingArea.Height / 2 - 240;
            this.Left = Screen.PrimaryScreen.WorkingArea.Width / 2 - 320;
            
            colorizationsOfScience(Color.FromName(Properties.Settings.Default.custColor[Properties.Settings.Default.whoIsThisCrazyDoge]));
            accountImg.BackgroundImage = Image.FromFile(Properties.Settings.Default.userimgacc_path[Properties.Settings.Default.whoIsThisCrazyDoge]);
            accountName.Text = Properties.Settings.Default.username[Properties.Settings.Default.whoIsThisCrazyDoge];
            nickname.Text = "\"" + Properties.Settings.Default.nickname[Properties.Settings.Default.whoIsThisCrazyDoge] + "\"";
            lockBack.BackgroundImage = Image.FromFile(Properties.Settings.Default.lock_path[Properties.Settings.Default.whoIsThisCrazyDoge]);

            // Handle new size resolutions

            accountName.Font = new System.Drawing.Font("Pacifico", 24);
            nickname.Font = new System.Drawing.Font("Pacifico", 14);

            otherAcc_text.Text = "Manage Other Accounts";

            accInfo_text.Font = space_text.Font = otherAcc_text.Font = new System.Drawing.Font("Roboto", 12);


            const int AW_BLEND = 0x00080000;
            const int AW_VER_POSITIVE = 0x8;

            // User32 and StackOverflow persons, you da real MVPs.
            AnimateWindow(this.Handle, 160, AW_BLEND | AW_VER_POSITIVE);

        }

        private void colorizationsOfScience(Color theColorWow)
        {
            accountName.ForeColor = theColorWow;
            accInfo_text.ForeColor = theColorWow;
            space_text.ForeColor = theColorWow;
            otherAcc_text.ForeColor = theColorWow;


            ImageFactory guessWhosBack = new ImageFactory();
            guessWhosBack.Load(@"C:\ProjectSnowshoes\System\Media\ResourcesMore\PersonOfScience.png");
            guessWhosBack.Tint(theColorWow);
            accInfo_img.BackgroundImage = guessWhosBack.Image;

            guessWhosBack.Load(@"C:\ProjectSnowshoes\System\Media\ResourcesMore\Solar.png");
            guessWhosBack.Tint(theColorWow);
            space_img.BackgroundImage = guessWhosBack.Image;

            guessWhosBack.Load(@"C:\ProjectSnowshoes\System\Media\ResourcesMore\MorePeople.png");
            guessWhosBack.Tint(theColorWow);
            otherAcc_img.BackgroundImage = guessWhosBack.Image;


        }

        private void spaceChanger_Click(object sender, EventArgs e)
        {
            ChangeBackground legitNames = new ChangeBackground();
            legitNames.Show();
            legitNames.BringToFront();
        }


        private void accountInfoItems_Hover(object sender, EventArgs e)
        {
            accInfo.BackColor = Color.FromName(Properties.Settings.Default.custColor[Properties.Settings.Default.whoIsThisCrazyDoge]);
            accInfo_img.BackgroundImage = Image.FromFile(@"C:\ProjectSnowshoes\System\Media\ResourcesMore\PersonOfScience.png");
            accInfo_text.ForeColor = Color.White;
        }

        private void spaceItems_Hover (object sender, EventArgs e)
        {
            space.BackColor = Color.FromName(Properties.Settings.Default.custColor[Properties.Settings.Default.whoIsThisCrazyDoge]);
            space_img.BackgroundImage = Image.FromFile(@"C:\ProjectSnowshoes\System\Media\ResourcesMore\Solar.png");
            space_text.ForeColor = Color.White;
        }

        private void otherAccItems_Hover(object sender, EventArgs e)
        {
            otherAcc.BackColor = Color.FromName(Properties.Settings.Default.custColor[Properties.Settings.Default.whoIsThisCrazyDoge]);
            otherAcc_img.BackgroundImage = Image.FromFile(@"C:\ProjectSnowshoes\System\Media\ResourcesMore\MorePeople.png");
            otherAcc_text.ForeColor = Color.White;
        }

        private void accountInfoItems_MouseLeave(object sender, EventArgs e)
        {
            accInfo.BackColor = Color.Transparent;
            ImageFactory guessWhosBackA = new ImageFactory();
            guessWhosBackA.Load(@"C:\ProjectSnowshoes\System\Media\ResourcesMore\PersonOfScience.png");
            guessWhosBackA.Tint(Color.FromName(Properties.Settings.Default.custColor[Properties.Settings.Default.whoIsThisCrazyDoge]));
            accInfo_img.BackgroundImage = guessWhosBackA.Image;
            accInfo_text.ForeColor = Color.FromName(Properties.Settings.Default.custColor[Properties.Settings.Default.whoIsThisCrazyDoge]);
        }

        private void spaceItems_MouseLeave(object sender, EventArgs e)
        {
            space.BackColor = Color.Transparent;
            ImageFactory guessWhosBackA = new ImageFactory();
            guessWhosBackA.Load(@"C:\ProjectSnowshoes\System\Media\ResourcesMore\Solar.png");
            guessWhosBackA.Tint(Color.FromName(Properties.Settings.Default.custColor[Properties.Settings.Default.whoIsThisCrazyDoge]));
            space_img.BackgroundImage = guessWhosBackA.Image;
            space_text.ForeColor = Color.FromName(Properties.Settings.Default.custColor[Properties.Settings.Default.whoIsThisCrazyDoge]);
        }

        private void otherAccItems_MouseLeave(object sender, EventArgs e)
        {
            otherAcc.BackColor = Color.Transparent;
            ImageFactory guessWhosBackA = new ImageFactory();
            guessWhosBackA.Load(@"C:\ProjectSnowshoes\System\Media\ResourcesMore\MorePeople.png");
            guessWhosBackA.Tint(Color.FromName(Properties.Settings.Default.custColor[Properties.Settings.Default.whoIsThisCrazyDoge]));
            otherAcc_img.BackgroundImage = guessWhosBackA.Image;
            otherAcc_text.ForeColor = Color.FromName(Properties.Settings.Default.custColor[Properties.Settings.Default.whoIsThisCrazyDoge]);
        }

        private void accountImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdlg = new OpenFileDialog();
            if (ofdlg.ShowDialog() == DialogResult.OK)
            {
                proPicToSet = ofdlg.FileName;
                accountImg.BackgroundImage = Image.FromFile(ofdlg.FileName);
            }
        }

        private void saveSettings_Click(object sender, EventArgs e)
        {
            if (accLockToSet != null)
            {
                Properties.Settings.Default.lock_path[Properties.Settings.Default.whoIsThisCrazyDoge] = accLockToSet;
            }
            if (proPicToSet != null)
            {
                Properties.Settings.Default.userimgacc_path[Properties.Settings.Default.whoIsThisCrazyDoge] = proPicToSet;
            }
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void lockBack_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdlga = new OpenFileDialog();
            if (ofdlga.ShowDialog() == DialogResult.OK)
            {
                accLockToSet = ofdlga.FileName;
                lockBack.BackgroundImage = Image.FromFile(ofdlga.FileName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewAccount_New1 newPM = new NewAccount_New1();
            newPM.Show();
            newPM.BringToFront();
            // Start closing other items            
            this.Close();

        }

        private void otherAcc_img_Click(object sender, EventArgs e)
        {
            OtherAcc oacc = new OtherAcc();
            oacc.Show();
            oacc.BringToFront();
        }

        private void otherAcc_text_Click(object sender, EventArgs e)
        {
            OtherAcc oacc = new OtherAcc();
            oacc.Show();
            oacc.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WoahWoahWoah deleteAcc = new WoahWoahWoah();
            deleteAcc.Show();
            deleteAcc.BringToFront();

            this.Close();
        }



    }
}
