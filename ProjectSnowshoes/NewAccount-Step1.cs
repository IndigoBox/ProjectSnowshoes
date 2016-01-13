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
    public partial class NewAccount_Step1 : Form
    {
        public NewAccount_Step1()
        {
            InitializeComponent();
        }

        public void NewAccount_Step1_Load(object sender, EventArgs e)
        {
            /*this.Controls.Remove(label1);
            this.Controls.Remove(label2);
            pictureBox1.Controls.Add(label1);
            pictureBox1.Controls.Add(label2);
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            pictureBox1.Invalidate();*/


            pleasePanel.Parent = pictureBox1;
            pleasePanel.BackColor = Color.Transparent;

            DoubleBufferManipulation.SetDoubleBuffered(pleasePanel);

            label1.Font = new System.Drawing.Font("Pacifico", 42, FontStyle.Regular);
            /*label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            label1.Font = new System.Drawing.Font("Pacifico", 42, FontStyle.Regular);


            label2.Parent = pictureBox1;
            label2.BackColor = Color.Transparent;*/
            label2.Font = new System.Drawing.Font("Roboto", 20, FontStyle.Regular);

            pictureBox1.Refresh();

            button1.Font = new System.Drawing.Font("Roboto Light", 20, FontStyle.Regular);
            button1.Refresh();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewAccount_Step2 step2 = new NewAccount_Step2();
            step2.Show();
            step2.BringToFront();
            this.Close();
        }
    }
}
