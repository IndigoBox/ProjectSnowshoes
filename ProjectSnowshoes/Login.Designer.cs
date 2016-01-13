namespace ProjectSnowshoes
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.userlargeimage = new System.Windows.Forms.PictureBox();
            this.accountName = new System.Windows.Forms.Label();
            this.weKnowWhatThisIs = new System.Windows.Forms.TextBox();
            this.enterButton = new System.Windows.Forms.Button();
            this.pwdWarning = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userlargeimage)).BeginInit();
            this.SuspendLayout();
            // 
            // userlargeimage
            // 
            this.userlargeimage.Dock = System.Windows.Forms.DockStyle.Left;
            this.userlargeimage.Location = new System.Drawing.Point(0, 0);
            this.userlargeimage.Name = "userlargeimage";
            this.userlargeimage.Size = new System.Drawing.Size(800, 873);
            this.userlargeimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.userlargeimage.TabIndex = 0;
            this.userlargeimage.TabStop = false;
            // 
            // accountName
            // 
            this.accountName.AutoSize = true;
            this.accountName.BackColor = System.Drawing.Color.Transparent;
            this.accountName.Font = new System.Drawing.Font("Roboto Light", 36F);
            this.accountName.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.accountName.Location = new System.Drawing.Point(818, 380);
            this.accountName.Name = "accountName";
            this.accountName.Size = new System.Drawing.Size(339, 127);
            this.accountName.TabIndex = 1;
            this.accountName.Text = "Robert";
            this.accountName.Click += new System.EventHandler(this.accountName_Click);
            // 
            // weKnowWhatThisIs
            // 
            this.weKnowWhatThisIs.Font = new System.Drawing.Font("Roboto", 16.25F);
            this.weKnowWhatThisIs.Location = new System.Drawing.Point(828, 456);
            this.weKnowWhatThisIs.Name = "weKnowWhatThisIs";
            this.weKnowWhatThisIs.Size = new System.Drawing.Size(442, 65);
            this.weKnowWhatThisIs.TabIndex = 2;
            this.weKnowWhatThisIs.UseSystemPasswordChar = true;
            // 
            // enterButton
            // 
            this.enterButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.enterButton.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.enterButton.FlatAppearance.BorderSize = 0;
            this.enterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enterButton.Font = new System.Drawing.Font("Roboto Light", 12.25F);
            this.enterButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.enterButton.Location = new System.Drawing.Point(1286, 456);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(98, 36);
            this.enterButton.TabIndex = 3;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = false;
            this.enterButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // pwdWarning
            // 
            this.pwdWarning.AutoSize = true;
            this.pwdWarning.BackColor = System.Drawing.Color.Transparent;
            this.pwdWarning.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Italic);
            this.pwdWarning.ForeColor = System.Drawing.Color.OrangeRed;
            this.pwdWarning.Location = new System.Drawing.Point(824, 506);
            this.pwdWarning.Name = "pwdWarning";
            this.pwdWarning.Size = new System.Drawing.Size(576, 43);
            this.pwdWarning.TabIndex = 4;
            this.pwdWarning.Text = "The lock won\'t budge. Try something else.";
            this.pwdWarning.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Roboto", 12.25F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(835, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(577, 220);
            this.label1.TabIndex = 5;
            this.label1.Text = "DEPRECATED\r\n\r\nReplaced by ObviouslyTurnUpOnAuth\r\nParadise Theatre Build\r\n9/25/201" +
    "4 1155hrs";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::ProjectSnowshoes.Properties.Resources.LoginBack;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1596, 873);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pwdWarning);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.weKnowWhatThisIs);
            this.Controls.Add(this.accountName);
            this.Controls.Add(this.userlargeimage);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Roboto", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userlargeimage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox userlargeimage;
        private System.Windows.Forms.Label accountName;
        private System.Windows.Forms.TextBox weKnowWhatThisIs;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Label pwdWarning;
        private System.Windows.Forms.Label label1;
    }
}