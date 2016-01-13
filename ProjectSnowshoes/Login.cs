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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            /* Since deprecated, these lines (which were broken by changes in The Bridge) have been commented out to avoid error.
             * 
             * userlargeimage.Image = Image.FromFile(Properties.Settings.Default.userimg_path);
            accountName.Text = Properties.Settings.Default.username;
            accountName.ForeColor = Properties.Settings.Default.custColor;
            enterButton.BackColor = Properties.Settings.Default.custColor;
             * 
             */
        }

        private void accountName_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (weKnowWhatThisIs.Text == Properties.Settings.Default.woahThereHello[Properties.Settings.Default.whoIsThisCrazyDoge])
            {
                Space spaaaaaaaaaaaaaaaaaaace = new Space();
                spaaaaaaaaaaaaaaaaaaace.Show();
                spaaaaaaaaaaaaaaaaaaace.BringToFront();
                this.Close();
            }
            else
            {
                pwdWarning.Visible = true;
                weKnowWhatThisIs.Text = "";
            }
        }
    }
}
