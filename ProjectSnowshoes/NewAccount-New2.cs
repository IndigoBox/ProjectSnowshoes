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
using System.IO;

namespace ProjectSnowshoes
{
    public partial class NewAccount_New2 : Form
    {
        
        // All to be saved at the end, just in case the user wants to cancel or exits prematurely.

        // Speaking of which, those means of exit still need to be added...

        String formalName, nickname;

        String hiAgain;
        String accentColor;
        String accountPicturePath, lockScreenPath, spacePath;

        String spaceCopyPath, appsCopyPath, docsCopyPath, imgCopyPath;

        String hiWhatNow;

        int spaceGuide, milesToGoBeforeISleep;

        
        public NewAccount_New2()
        {
            InitializeComponent();
        }

        private void NewAccount_New2_Load(object sender, EventArgs e)
        {
            // Mask password here

            password_ThatPWTho.PasswordChar = '•';

            // Add AutoEllipses for Paths

            mayfieldPanel_AppsPath.AutoEllipsis = true;
            mayfieldPanel_DocumentsPath.AutoEllipsis = true;
            mayfieldPanel_ImagesPath.AutoEllipsis = true;
            mayfieldPanel_SpacePath.AutoEllipsis = true;

            // Preliminary path data 

            accountPicturePath = @"C:\ProjectSnowshoes\System\Media\DefaultIcon.png";
            lockScreenPath = @"C:\ProjectSnowshoes\System\Media\blackBackSearch.png";
            spacePath = @"C:\ProjectSnowshoes\System\Media\RunningOnIce.png";
            
            // Non-primary panels

            passwordPanel_2.Left = 0 - passwordPanel_2.Width;
            aestheticsColorPanel.Left = 0 - aestheticsColorPanel.Width;
            accountPicturePanel.Left = 0 - accountPicturePanel.Width;
            backgroundsPanel.Left = 0 - backgroundsPanel.Width;
            mayfieldPanel.Left = 0 - mayfieldPanel.Width;
            arcadePanel.Left = 0 - arcadePanel.Width;
            
            
            
            spaceGuide = step1.Width;
            Transition.run(step1, "Left", 0-spaceGuide, 35, new TransitionType_Linear(220));
            Transition.run(step2, "Left", 0 - spaceGuide, 95 + spaceGuide, new TransitionType_Linear(220));
            Transition.run(step3, "Left", 0 - spaceGuide, 155 + (spaceGuide * 2), new TransitionType_Linear(220));
            Transition.run(step4, "Left", 0 - spaceGuide, 215 + (spaceGuide * 3), new TransitionType_Linear(220));
            Transition.run(step5, "Left", 0 - spaceGuide, 315 + (spaceGuide * 4), new TransitionType_Linear(220));

            milesToGoBeforeISleep = about1Panel1.Left;
            Transition.run(about1Panel1, "Left", 0-about1Panel1.Width, milesToGoBeforeISleep, new TransitionType_Linear(220));

        }

        private void about1Panel1_OK_Click(object sender, EventArgs e)
        {
            if (formalName == null && about1Panel1_Text.Text != "")
            {
                Transition.run(this, "BackColor", Color.FromArgb(255, 32, 87, 143), new TransitionType_EaseInEaseOut(200));
                Transition.run(about1Panel1_WhoAreYou, "Text", "Now for that nickname.", new TransitionType_EaseInEaseOut(120));
                Transition.run(about1Panel1_Caption, "Text", "Since you wrote " + about1Panel1_Text.Text + ", a nickname was created for you. You can edit the text below or keep it and move on.", new TransitionType_EaseInEaseOut(120));
                formalName = about1Panel1_Text.Text;
                about1Panel1_Text.Text = formalName.Split(' ')[0];

                about1Panel1_Info.Text = "Minerva can change this later; just say \"Call me [name]\".";
            }
            else if (about1Panel1_Text.Text == "")
            {
                Transition.run(this, "BackColor", Color.DarkRed, new TransitionType_EaseInEaseOut(200));
                about1Panel1_Info.Text = "Please write in a name before you move on.";
            }
            else
            {
                Transition.run(this, "BackColor", Color.FromArgb(255, 32, 87, 143), new TransitionType_EaseInEaseOut(200));
                nickname = about1Panel1_Text.Text;
                Transition.run(about1Panel1, "Left", this.Width, new TransitionType_Linear(220));
                Transition.run(passwordPanel_2, "Left", milesToGoBeforeISleep, new TransitionType_Linear(220));
                Transition.run(step2, "ForeColor", Color.White, new TransitionType_EaseInEaseOut(220));
                Transition.run(step1, "ForeColor", Color.Gray, new TransitionType_EaseInEaseOut(220));
            }
        }

        private void password_ThatPWTho_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Moved to TextChanged (reacted one character too late most times)
        }

        private void password_ThatPWTho_TextChanged(object sender, EventArgs e)
        {
            // Top 25 passwords from SplashData's Report in 2014
            // Link: http://splashdata.com/press/worst-passwords-of-2014.htm

            if (password_ThatPWTho.Text == "123456" ||
                password_ThatPWTho.Text == "password" ||
                password_ThatPWTho.Text == "12345" ||
                password_ThatPWTho.Text == "12345678" ||
                password_ThatPWTho.Text == "qwerty" ||
                password_ThatPWTho.Text == "123456789" ||
                password_ThatPWTho.Text == "1234" ||
                password_ThatPWTho.Text == "baseball" ||
                password_ThatPWTho.Text == "dragon" ||
                password_ThatPWTho.Text == "football" ||
                password_ThatPWTho.Text == "1234567" ||
                password_ThatPWTho.Text == "monkey" ||
                password_ThatPWTho.Text == "letmein" ||
                password_ThatPWTho.Text == "abc123" ||
                password_ThatPWTho.Text == "111111" ||
                password_ThatPWTho.Text == "mustang" ||
                password_ThatPWTho.Text == "access" ||
                password_ThatPWTho.Text == "shadow" ||
                password_ThatPWTho.Text == "master" ||
                password_ThatPWTho.Text == "michael" ||
                password_ThatPWTho.Text == "superman" ||
                password_ThatPWTho.Text == "696969" ||
                password_ThatPWTho.Text == "123123" ||
                password_ThatPWTho.Text == "batman" ||
                password_ThatPWTho.Text == "trustno1")
            {
                password_StrengthGuide.Text = "I might actually cry. That password is one of the 25 most used (SplashData).";
                Transition.run(this, "BackColor", Color.Black, new TransitionType_EaseInEaseOut(200));
            }
            else if (password_ThatPWTho.Text == "knight")
            {
                password_StrengthGuide.Text = "Nice to see you, Viktor.";
                Transition.run(this, "BackColor", Color.Indigo, new TransitionType_EaseInEaseOut(200));
            }
            else if (password_ThatPWTho.Text.Length <= 6)
            {
                password_StrengthGuide.Text = "My dog could come up with a better password than that. Let's try something else.";
                Transition.run(this, "BackColor", Color.DarkRed, new TransitionType_EaseInEaseOut(200));
            }
            else if (password_ThatPWTho.Text.Length < 12 && 
                
                !(password_ThatPWTho.Text.Contains("!") || 
                password_ThatPWTho.Text.Contains("@") || 
                password_ThatPWTho.Text.Contains("#") || 
                password_ThatPWTho.Text.Contains("$") || 
                password_ThatPWTho.Text.Contains("%") ||
                password_ThatPWTho.Text.Contains("^") || 
                password_ThatPWTho.Text.Contains("&") || 
                password_ThatPWTho.Text.Contains("*") ||
                password_ThatPWTho.Text.Contains("(") || 
                password_ThatPWTho.Text.Contains(")") ||
                password_ThatPWTho.Text.Contains("-") ||
                password_ThatPWTho.Text.Contains("_") ||
                password_ThatPWTho.Text.Contains("+") ||
                password_ThatPWTho.Text.Contains("=") ||
                password_ThatPWTho.Text.Contains("{") ||
                password_ThatPWTho.Text.Contains("}") ||
                password_ThatPWTho.Text.Contains("[") ||
                password_ThatPWTho.Text.Contains("]") ||
                password_ThatPWTho.Text.Contains("|") ||
                password_ThatPWTho.Text.Contains(@"\") ||
                password_ThatPWTho.Text.Contains("~") ||
                password_ThatPWTho.Text.Contains("`") ||
                password_ThatPWTho.Text.Contains(":") ||
                password_ThatPWTho.Text.Contains(";") ||
                password_ThatPWTho.Text.Contains("\"") ||
                password_ThatPWTho.Text.Contains("'") ||
                password_ThatPWTho.Text.Contains("<") ||
                password_ThatPWTho.Text.Contains(">") ||
                password_ThatPWTho.Text.Contains("?") ||
                password_ThatPWTho.Text.Contains(",") ||
                password_ThatPWTho.Text.Contains(".") ||
                password_ThatPWTho.Text.Contains("/"))
                
                ) {
                    Transition.run(this, "BackColor", Color.DarkGoldenrod, new TransitionType_EaseInEaseOut(200));
                    password_StrengthGuide.Text = "That is a password, alright, but it still could be better. Let's try just a bit more here.";
            }
            else
            {
                password_StrengthGuide.Text = "That password is pretty good. We might need a CAPTCHA just to prove you are human.";
                Transition.run(this, "BackColor", Color.DarkGreen, new TransitionType_EaseInEaseOut(200));
            }
        }

        private void password_SaveIt_Click(object sender, EventArgs e)
        {
            hiAgain = password_ThatPWTho.Text;

            Transition.run(passwordPanel_2, "Left", this.Width, new TransitionType_Linear(220));
            Transition.run(aestheticsColorPanel, "Left", milesToGoBeforeISleep, new TransitionType_Linear(220));
            Transition.run(step3, "ForeColor", Color.White, new TransitionType_EaseInEaseOut(220));
            Transition.run(step2, "ForeColor", Color.Gray, new TransitionType_EaseInEaseOut(220));
            Transition.run(this, "BackColor", Color.FromArgb(255, 32, 87, 143), new TransitionType_EaseInEaseOut(200));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            accentColor = "Black";
            Transition.run(this, "BackColor", Color.Black, new TransitionType_EaseInEaseOut(200));
            button1.Text = "✓";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            button10.Text = "";
            button11.Text = "";
            button12.Text = "";
            button13.Text = "";
            button14.Text = "";
            button15.Text = "";
            button16.Text = "";
            button17.Text = "";
            button18.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            accentColor = "Maroon";
            Transition.run(this, "BackColor", Color.Maroon, new TransitionType_EaseInEaseOut(200));
            
            button1.Text = "";
            button2.Text = "✓";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            button10.Text = "";
            button11.Text = "";
            button12.Text = "";
            button13.Text = "";
            button14.Text = "";
            button15.Text = "";
            button16.Text = "";
            button17.Text = "";
            button18.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            accentColor = "Sienna";
            Transition.run(this, "BackColor", Color.Sienna, new TransitionType_EaseInEaseOut(200));

            button1.Text = "";
            button2.Text = "";
            button3.Text = "✓";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            button10.Text = "";
            button11.Text = "";
            button12.Text = "";
            button13.Text = "";
            button14.Text = "";
            button15.Text = "";
            button16.Text = "";
            button17.Text = "";
            button18.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            accentColor = "DarkOrange";
            Transition.run(this, "BackColor", Color.DarkOrange, new TransitionType_EaseInEaseOut(200));

            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "✓";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            button10.Text = "";
            button11.Text = "";
            button12.Text = "";
            button13.Text = "";
            button14.Text = "";
            button15.Text = "";
            button16.Text = "";
            button17.Text = "";
            button18.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            accentColor = "Goldenrod";
            Transition.run(this, "BackColor", Color.Goldenrod, new TransitionType_EaseInEaseOut(200));

            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "✓";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            button10.Text = "";
            button11.Text = "";
            button12.Text = "";
            button13.Text = "";
            button14.Text = "";
            button15.Text = "";
            button16.Text = "";
            button17.Text = "";
            button18.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            accentColor = "SeaGreen";
            Transition.run(this, "BackColor", Color.SeaGreen, new TransitionType_EaseInEaseOut(200));

            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "✓";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            button10.Text = "";
            button11.Text = "";
            button12.Text = "";
            button13.Text = "";
            button14.Text = "";
            button15.Text = "";
            button16.Text = "";
            button17.Text = "";
            button18.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            accentColor = "LightSeaGreen";
            Transition.run(this, "BackColor", Color.LightSeaGreen, new TransitionType_EaseInEaseOut(200));

            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "✓";
            button8.Text = "";
            button9.Text = "";
            button10.Text = "";
            button11.Text = "";
            button12.Text = "";
            button13.Text = "";
            button14.Text = "";
            button15.Text = "";
            button16.Text = "";
            button17.Text = "";
            button18.Text = "";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            accentColor = "Teal";
            Transition.run(this, "BackColor", Color.Teal, new TransitionType_EaseInEaseOut(200));

            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "✓";
            button9.Text = "";
            button10.Text = "";
            button11.Text = "";
            button12.Text = "";
            button13.Text = "";
            button14.Text = "";
            button15.Text = "";
            button16.Text = "";
            button17.Text = "";
            button18.Text = "";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            accentColor = "DeepSkyBlue";
            Transition.run(this, "BackColor", Color.DeepSkyBlue, new TransitionType_EaseInEaseOut(200));

            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "✓";
            button10.Text = "";
            button11.Text = "";
            button12.Text = "";
            button13.Text = "";
            button14.Text = "";
            button15.Text = "";
            button16.Text = "";
            button17.Text = "";
            button18.Text = "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            accentColor = "SteelBlue";
            Transition.run(this, "BackColor", Color.SteelBlue, new TransitionType_EaseInEaseOut(200));

            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            button10.Text = "✓";
            button11.Text = "";
            button12.Text = "";
            button13.Text = "";
            button14.Text = "";
            button15.Text = "";
            button16.Text = "";
            button17.Text = "";
            button18.Text = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            accentColor = "RoyalBlue";
            Transition.run(this, "BackColor", Color.RoyalBlue, new TransitionType_EaseInEaseOut(200));

            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            button10.Text = "";
            button11.Text = "✓";
            button12.Text = "";
            button13.Text = "";
            button14.Text = "";
            button15.Text = "";
            button16.Text = "";
            button17.Text = "";
            button18.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            accentColor = "MidnightBlue";
            Transition.run(this, "BackColor", Color.MidnightBlue, new TransitionType_EaseInEaseOut(200));

            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            button10.Text = "";
            button11.Text = "";
            button12.Text = "✓";
            button13.Text = "";
            button14.Text = "";
            button15.Text = "";
            button16.Text = "";
            button17.Text = "";
            button18.Text = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            accentColor = "BlueViolet";
            Transition.run(this, "BackColor", Color.BlueViolet, new TransitionType_EaseInEaseOut(200));

            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            button10.Text = "";
            button11.Text = "";
            button12.Text = "";
            button13.Text = "✓";
            button14.Text = "";
            button15.Text = "";
            button16.Text = "";
            button17.Text = "";
            button18.Text = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            accentColor = "Indigo";
            Transition.run(this, "BackColor", Color.Indigo, new TransitionType_EaseInEaseOut(200));

            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            button10.Text = "";
            button11.Text = "";
            button12.Text = "";
            button13.Text = "";
            button14.Text = "✓";
            button15.Text = "";
            button16.Text = "";
            button17.Text = "";
            button18.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            accentColor = "DarkViolet";
            Transition.run(this, "BackColor", Color.DarkViolet, new TransitionType_EaseInEaseOut(200));

            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            button10.Text = "";
            button11.Text = "";
            button12.Text = "";
            button13.Text = "";
            button14.Text = "";
            button15.Text = "✓";
            button16.Text = "";
            button17.Text = "";
            button18.Text = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            accentColor = "Fuchsia";
            Transition.run(this, "BackColor", Color.Fuchsia, new TransitionType_EaseInEaseOut(200));

            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            button10.Text = "";
            button11.Text = "";
            button12.Text = "";
            button13.Text = "";
            button14.Text = "";
            button15.Text = "";
            button16.Text = "✓";
            button17.Text = "";
            button18.Text = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            accentColor = "MediumVioletRed";
            Transition.run(this, "BackColor", Color.MediumVioletRed, new TransitionType_EaseInEaseOut(200));

            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            button10.Text = "";
            button11.Text = "";
            button12.Text = "";
            button13.Text = "";
            button14.Text = "";
            button15.Text = "";
            button16.Text = "";
            button17.Text = "✓";
            button18.Text = "";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            accentColor = "Crimson";
            Transition.run(this, "BackColor", Color.Crimson, new TransitionType_EaseInEaseOut(200));

            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            button10.Text = "";
            button11.Text = "";
            button12.Text = "";
            button13.Text = "";
            button14.Text = "";
            button15.Text = "";
            button16.Text = "";
            button17.Text = "";
            button18.Text = "✓";
        }

        private void aestheticsColorPanel_Proceed_Click(object sender, EventArgs e)
        {
            accountPicturePanel_Name.Text = formalName;
            
            Transition.run(aestheticsColorPanel, "Left", this.Width, new TransitionType_Linear(220));
            Transition.run(accountPicturePanel, "Left", milesToGoBeforeISleep, new TransitionType_Linear(220));
            Transition.run(this, "BackColor", Color.FromArgb(255, 32, 87, 143), new TransitionType_EaseInEaseOut(200));
        }

        private void accountPicturePanel_Change_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdlg = new OpenFileDialog();
            ofdlg.Title = "Choose an image...";
            if (ofdlg.ShowDialog() == DialogResult.OK)
            {
                accountPicturePath = ofdlg.FileName;
                accountPicturePanel_Change.BackgroundImage = Image.FromFile(ofdlg.FileName);
            }
        }

        private void accountPicturePanel_Save_Click(object sender, EventArgs e)
        {
            Transition.run(accountPicturePanel, "Left", this.Width, new TransitionType_Linear(220));
            Transition.run(backgroundsPanel, "Left", milesToGoBeforeISleep, new TransitionType_Linear(220));
            
        }

        private void backgroundsPanel_LockScreen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdlgA = new OpenFileDialog();
            ofdlgA.Title = "Choose an image...";
            if (ofdlgA.ShowDialog() == DialogResult.OK)
            {
                lockScreenPath = ofdlgA.FileName;
                backgroundsPanel_LockScreen.BackgroundImage = Image.FromFile(ofdlgA.FileName);
            }
        }

        private void backgroundsPanel_Space_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdlgAA = new OpenFileDialog();
            ofdlgAA.Title = "Choose an image...";
            if (ofdlgAA.ShowDialog() == DialogResult.OK)
            {
                spacePath = ofdlgAA.FileName;
                backgroundsPanel_Space.BackgroundImage = Image.FromFile(ofdlgAA.FileName);
            }
        }

        private void mayfieldPanel_Space_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog spacefbd = new FolderBrowserDialog();
            spacefbd.Description = "Choose where your files for Space are located.";
            if (spacefbd.ShowDialog() == DialogResult.OK)
            {
                spaceCopyPath = spacefbd.SelectedPath;
                mayfieldPanel_SpacePath.Text = spaceCopyPath.Split('\\')[spaceCopyPath.Split('\\').Length - 1];
                mayfieldPanel_SpacePath.ForeColor = Color.LimeGreen;
            }
        }

        private void mayfieldPanel_Apps_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog spacefbd = new FolderBrowserDialog();
            spacefbd.Description = "Choose where your Apps are located.";
            if (spacefbd.ShowDialog() == DialogResult.OK)
            {
                appsCopyPath = spacefbd.SelectedPath;
                mayfieldPanel_AppsPath.Text = appsCopyPath.Split('\\')[appsCopyPath.Split('\\').Length - 1];
                mayfieldPanel_AppsPath.ForeColor = Color.LimeGreen;
            }
        }

        private void mayfieldPanel_Documents_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog spacefbd = new FolderBrowserDialog();
            spacefbd.Description = "Choose where your documents are located.";
            if (spacefbd.ShowDialog() == DialogResult.OK)
            {
                docsCopyPath = spacefbd.SelectedPath;
                mayfieldPanel_DocumentsPath.Text = docsCopyPath.Split('\\')[docsCopyPath.Split('\\').Length - 1];
                mayfieldPanel_DocumentsPath.ForeColor = Color.LimeGreen;
            }
        }

        private void mayfieldPanel_Images_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog spacefbd = new FolderBrowserDialog();
            spacefbd.Description = "Choose where your images are located.";
            if (spacefbd.ShowDialog() == DialogResult.OK)
            {
                imgCopyPath = spacefbd.SelectedPath;
                mayfieldPanel_ImagesPath.Text = imgCopyPath.Split('\\')[imgCopyPath.Split('\\').Length - 1];
                mayfieldPanel_ImagesPath.ForeColor = Color.LimeGreen;
            }
        }

        private void mayfieldPanel_Save_Click(object sender, EventArgs e)
        {
            if (mayfieldPanel_AppsPath.Text != "No Path Selected"
                && mayfieldPanel_DocumentsPath.Text != "No Path Selected"
                && mayfieldPanel_ImagesPath.Text != "No Path Selected"
                && mayfieldPanel_SpacePath.Text != "No Path Selected")
            {
                Transition.run(mayfieldPanel, "Left", this.Width, new TransitionType_Linear(220));
                Transition.run(arcadePanel, "Left", milesToGoBeforeISleep, new TransitionType_Linear(220));
                Transition.run(step5, "ForeColor", Color.White, new TransitionType_EaseInEaseOut(220));
                Transition.run(step4, "ForeColor", Color.Gray, new TransitionType_EaseInEaseOut(220));
                Transition.run(this, "BackColor", Color.FromName(accentColor), new TransitionType_EaseInEaseOut(200));
            }
            else
            {
                Transition.run(this, "BackColor", Color.DarkRed, new TransitionType_EaseInEaseOut(200));
                mayfieldPanel_Information.Text = "Please select paths for all four libraries before moving on.";
            }
        }

        private void backgroundsPanel_Save_Click(object sender, EventArgs e)
        {
            Transition.run(backgroundsPanel, "Left", this.Width, new TransitionType_Linear(220));
            Transition.run(mayfieldPanel, "Left", milesToGoBeforeISleep, new TransitionType_Linear(220));
            Transition.run(step4, "ForeColor", Color.White, new TransitionType_EaseInEaseOut(220));
            Transition.run(step3, "ForeColor", Color.Gray, new TransitionType_EaseInEaseOut(220));
        }

        private void arcadePanel_Create_Click(object sender, EventArgs e)
        {
            // Well, here we are!

            // Let's start off with some of the settings the user had no idea about (evil laugh)

            Properties.Settings.Default.darkerFontsOfScience.Add("Roboto");
            Properties.Settings.Default.fontsOfScience.Add("Roboto Light");
            Properties.Settings.Default.loggedIn.Add("false");

            arcadePanel_Reflektions.Text = "Saving personalized settings...your files will move after this.";

            // Now to identity...

            Properties.Settings.Default.username.Add(formalName);
            Properties.Settings.Default.nickname.Add(nickname);

            // Time to whisper
            Properties.Settings.Default.woahThereHello.Add(hiAgain);

            // Aesthetic settings
            Properties.Settings.Default.userimgacc_path.Add(accountPicturePath);
            Properties.Settings.Default.lock_path.Add(lockScreenPath);
            Properties.Settings.Default.space_back_path.Add(spacePath);
            Properties.Settings.Default.custColor.Add(accentColor);

            // Perhaps the most difficult part of them all...copying and creating all associated files and directories.
                // About seven hours later...THIS IS ABSOLUTELY THE MOST DIFFICULT PART. Wow. 
                // Also, should we tell the user that this is happening?
                // Should I post that to the suggestions?
                // Should I stop with all of the questions and move on? (Yes)
            System.IO.Directory.CreateDirectory(@"C:\ProjectSnowshoes\User\" + formalName);
            System.IO.Directory.CreateDirectory(@"C:\ProjectSnowshoes\User\" + formalName + @"\Apps");
            System.IO.Directory.CreateDirectory(@"C:\ProjectSnowshoes\User\" + formalName + @"\Documents");
            System.IO.Directory.CreateDirectory(@"C:\ProjectSnowshoes\User\" + formalName + @"\Pictures");
            System.IO.Directory.CreateDirectory(@"C:\ProjectSnowshoes\User\" + formalName + @"\Space");
            //These following two directories are not used as of 7152015 1814hrs (Bridge)
            System.IO.Directory.CreateDirectory(@"C:\ProjectSnowshoes\User\" + formalName + @"\Music");
            System.IO.Directory.CreateDirectory(@"C:\ProjectSnowshoes\User\" + formalName + @"\Settings");

            // Apps
            for (int i = 0; i < Directory.GetFiles(appsCopyPath,"*.lnk",SearchOption.AllDirectories).Length; i++)
            {
                arcadePanel_Reflektions.Text = "Copying app shortcut \"" + Directory.GetFiles(appsCopyPath, "*.lnk", SearchOption.AllDirectories)[i].Split('\\')[
                    Directory.GetFiles(appsCopyPath, "*.lnk", SearchOption.AllDirectories)[i].Split('\\').Length - 1] + "\"";
                Application.DoEvents();
                File.Copy(Directory.GetFiles(appsCopyPath, "*.lnk", SearchOption.AllDirectories)[i],
                    @"C:\ProjectSnowshoes\User\" + formalName + @"\Apps\" + Directory.GetFiles(appsCopyPath, "*.lnk", SearchOption.AllDirectories)[i].Split('\\')[
                    Directory.GetFiles(appsCopyPath, "*.lnk", SearchOption.AllDirectories)[i].Split('\\').Length - 1]);
            }

            // Space
            for (int j = 0; j < Directory.GetFiles(spaceCopyPath, "*.*", SearchOption.TopDirectoryOnly).Length; j++)
            {
                arcadePanel_Reflektions.Text = "Placing " + appsCopyPath + "on Space...";
                File.Copy(Directory.GetFiles(spaceCopyPath, "*.*", SearchOption.TopDirectoryOnly)[j],
                    @"C:\ProjectSnowshoes\User\" + formalName + @"\Space\" + Directory.GetFiles(spaceCopyPath, "*.*", SearchOption.AllDirectories)[j].Split('\\')[
                    Directory.GetFiles(spaceCopyPath, "*.*", SearchOption.AllDirectories)[j].Split('\\').Length - 1]);
            }

            // Documents
            // I'll leave one remnant of there originally being a List<string> above: subDirsA = new List<string>();
            DirectoryInfo dInf = new DirectoryInfo(docsCopyPath);
            hiWhatNow = "Documents";
            populateDirectories(dInf);
            
            
            
            /*for (int k = 0; k < docDirs.Length; k++)
            {
                Directory.CreateDirectory(@"C:\ProjectSnowshoes\User\" + formalName + @"\Documents" + docDirs[k].Replace(docsCopyPath,""));
            }
            for (int l = 0; l < docDirs.Length; l++)
            {
                try { 
                for (int ll = 0; ll < Directory.GetFiles(docDirs[l], "*.*", SearchOption.TopDirectoryOnly).Length; ll++)
                {
                    File.Copy(Directory.GetFiles(docDirs[l], "*.*", SearchOption.TopDirectoryOnly)[ll],
                       @"C:\ProjectSnowshoes\User\" + formalName + @"\Documents\" +
                       Directory.GetFiles(docsCopyPath, "*.*", SearchOption.AllDirectories)[ll].Replace(docsCopyPath, ""),true);
                }
                }
                catch (Exception ex)
                {

                }
            }*/

            // Images
            DirectoryInfo dInfA = new DirectoryInfo(imgCopyPath);
            hiWhatNow = "Pictures";
            populateDirectories(dInfA);
            /*for (int m = 0; m < imgDirs.Length; m++)
            {
                Directory.CreateDirectory(@"C:\ProjectSnowshoes\User\" + formalName + @"\Pictures" + imgDirs[m].Replace(imgCopyPath, ""));
            }
            for (int l = 0; l < imgDirs.Length; l++)
            {
                try
                {
                    for (int ll = 0; ll < Directory.GetFiles(imgDirs[l], "*.*", SearchOption.TopDirectoryOnly).Length; ll++)
                    {
                        File.Copy(Directory.GetFiles(imgDirs[l], "*.*", SearchOption.TopDirectoryOnly)[ll],
                           @"C:\ProjectSnowshoes\User\" + formalName + @"\Pictures\" +
                           Directory.GetFiles(imgCopyPath, "*.*", SearchOption.AllDirectories)[ll].Replace(imgCopyPath, ""), true);
                    }
                }
                catch (Exception ex)
                {

                }
            }*/

            

            // Please work.

            // Moving on, this should close this new account setup and log-in the new user. 

            Properties.Settings.Default.Save();

            Properties.Settings.Default.whoIsThisCrazyDoge = Properties.Settings.Default.nickname.Count - 1;
            Space spaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaace = new Space();
            spaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaace.Show();
            spaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaace.BringToFront();
            Properties.Settings.Default.loggedIn[Properties.Settings.Default.whoIsThisCrazyDoge] = "true";
            this.Close();

        }

        public void populateDirectories(System.IO.DirectoryInfo initPath)
        {
            // Quite a bit (but definitely not all) of this code's skeleton is provided by Microsoft.
            // Playing around without it, and even working with it specifically for this, took hours and is either commented out, removed, here, or somewhere else. You know, Robert.

            // Anyway, here's a link: https://msdn.microsoft.com/en-us/library/bb513869.aspx
            
            System.IO.FileInfo[] files = null;
            System.IO.DirectoryInfo[] subDirs = null;

            
            try
            {
                files = initPath.GetFiles("*.*");
            }
            // MICROSOFT: "This is thrown if even one of the files requires permissions greater 
            // than the application provides."
            // Side note: Why did Microsoft create pseudo-folders to My Music, My Documents, and My Videos?
            // We get it, some of you like XP, but it is time to move on!
            catch (UnauthorizedAccessException e)
            {
                // For now, we will not report any unauthorized access exceptions. We could log it, as in the Microsoft example, but...well, nahhh. 
                // By that, this should be discussed with evaluators...and myself.
            }

            catch (System.IO.DirectoryNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }

            if (files != null)
            {
                if (hiWhatNow == "Documents")
                {
                    Directory.CreateDirectory(@"C:\ProjectSnowshoes\User\" + formalName + @"\Documents\" + initPath.FullName.Replace(docsCopyPath, ""));
                    arcadePanel_Reflektions.Text = "Creating Directory for User: " + @"\Documents\" + initPath.FullName.Replace(docsCopyPath, "");

                    foreach (System.IO.FileInfo fi in files)
                    {
                        File.Copy(fi.FullName, @"C:\ProjectSnowshoes\User\" + formalName + @"\Documents\" + fi.FullName.Replace(docsCopyPath,""));
                        arcadePanel_Reflektions.Text = "Copying file: " + fi.FullName + " to Documents\\" + fi.FullName.Replace(docsCopyPath,"");
                        this.Invalidate();
                    }
                }
                else
                {
                    Directory.CreateDirectory(@"C:\ProjectSnowshoes\User\" + formalName + @"\Pictures\" + initPath.FullName.Replace(imgCopyPath, ""));
                    arcadePanel_Reflektions.Text = "Creating Directory for User: " + @"\Pictures\" + initPath.FullName.Replace(imgCopyPath, "");
                    
                    foreach (System.IO.FileInfo fi in files)
                    {
                        File.Copy(fi.FullName, @"C:\ProjectSnowshoes\User\" + formalName + @"\Pictures\" + fi.FullName.Replace(imgCopyPath, ""));
                        arcadePanel_Reflektions.Text = "Copying file: " + fi.FullName + " to Pictures\\" + fi.FullName.Replace(imgCopyPath, "");
                        
                    }
                }
                // "Now find all the subdirectories under this directory."
                subDirs = initPath.GetDirectories();

                foreach (System.IO.DirectoryInfo dirInfo in subDirs)
                {
                    // "Recursive call for each subdirectory."
                    populateDirectories(dirInfo);
                }



            }

        }

    }
}
