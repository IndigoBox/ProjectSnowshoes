namespace ProjectSnowshoes
{
    partial class ObviouslyTurnUpOnAuth
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pwdWarning = new System.Windows.Forms.Label();
            this.enterButton = new System.Windows.Forms.Button();
            this.weKnowWhatThisIs = new System.Windows.Forms.TextBox();
            this.accountName = new System.Windows.Forms.Label();
            this.accountImg = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountImg)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::ProjectSnowshoes.Properties.Resources._20pertrans_lighterGray;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.pwdWarning);
            this.panel1.Controls.Add(this.enterButton);
            this.panel1.Controls.Add(this.weKnowWhatThisIs);
            this.panel1.Controls.Add(this.accountName);
            this.panel1.Controls.Add(this.accountImg);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1932, 1092);
            this.panel1.TabIndex = 7;
            // 
            // pwdWarning
            // 
            this.pwdWarning.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pwdWarning.AutoSize = true;
            this.pwdWarning.BackColor = System.Drawing.Color.Transparent;
            this.pwdWarning.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Italic);
            this.pwdWarning.ForeColor = System.Drawing.Color.White;
            this.pwdWarning.Location = new System.Drawing.Point(618, 644);
            this.pwdWarning.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.pwdWarning.Name = "pwdWarning";
            this.pwdWarning.Size = new System.Drawing.Size(589, 38);
            this.pwdWarning.TabIndex = 11;
            this.pwdWarning.Text = "The lock won\'t budge. Try something else.";
            this.pwdWarning.Visible = false;
            // 
            // enterButton
            // 
            this.enterButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.enterButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.enterButton.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.enterButton.FlatAppearance.BorderSize = 2;
            this.enterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enterButton.Font = new System.Drawing.Font("Roboto Light", 12.25F);
            this.enterButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.enterButton.Location = new System.Drawing.Point(1542, 550);
            this.enterButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(196, 69);
            this.enterButton.TabIndex = 10;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = false;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // weKnowWhatThisIs
            // 
            this.weKnowWhatThisIs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.weKnowWhatThisIs.Font = new System.Drawing.Font("Roboto", 16.25F);
            this.weKnowWhatThisIs.Location = new System.Drawing.Point(626, 550);
            this.weKnowWhatThisIs.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.weKnowWhatThisIs.Name = "weKnowWhatThisIs";
            this.weKnowWhatThisIs.PasswordChar = '•';
            this.weKnowWhatThisIs.Size = new System.Drawing.Size(880, 60);
            this.weKnowWhatThisIs.TabIndex = 9;
            this.weKnowWhatThisIs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.weKnowWhatThisIs_KeyPress);
            // 
            // accountName
            // 
            this.accountName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.accountName.AutoSize = true;
            this.accountName.BackColor = System.Drawing.Color.Transparent;
            this.accountName.Font = new System.Drawing.Font("Roboto Light", 32.25F);
            this.accountName.ForeColor = System.Drawing.Color.White;
            this.accountName.Location = new System.Drawing.Point(606, 408);
            this.accountName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.accountName.Name = "accountName";
            this.accountName.Size = new System.Drawing.Size(630, 104);
            this.accountName.TabIndex = 8;
            this.accountName.Text = "Turnt Up Doges";
            // 
            // accountImg
            // 
            this.accountImg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.accountImg.BackgroundImage = global::ProjectSnowshoes.Properties.Resources._50pertrans_gray;
            this.accountImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.accountImg.Location = new System.Drawing.Point(194, 354);
            this.accountImg.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.accountImg.Name = "accountImg";
            this.accountImg.Size = new System.Drawing.Size(400, 385);
            this.accountImg.TabIndex = 7;
            this.accountImg.TabStop = false;
            // 
            // ObviouslyTurnUpOnAuth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BackgroundImage = global::ProjectSnowshoes.Properties.Resources.img104;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1932, 1092);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "ObviouslyTurnUpOnAuth";
            this.Text = "ObviouslyTurnUpOnAuth";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.DeepPink;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ObviouslyTurnUpOnAuth_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ObviouslyTurnUpOnAuth_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label pwdWarning;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.TextBox weKnowWhatThisIs;
        private System.Windows.Forms.Label accountName;
        private System.Windows.Forms.PictureBox accountImg;

    }
}