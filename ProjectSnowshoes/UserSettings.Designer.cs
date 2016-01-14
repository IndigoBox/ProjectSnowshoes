namespace ProjectSnowshoes
{
    partial class UserSettings
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
            this.accountName = new System.Windows.Forms.Label();
            this.nickname = new System.Windows.Forms.Label();
            this.accInfo = new System.Windows.Forms.Panel();
            this.accInfo_text = new System.Windows.Forms.Label();
            this.accInfo_img = new System.Windows.Forms.PictureBox();
            this.space = new System.Windows.Forms.Panel();
            this.space_text = new System.Windows.Forms.Label();
            this.space_img = new System.Windows.Forms.PictureBox();
            this.otherAcc = new System.Windows.Forms.Panel();
            this.otherAcc_text = new System.Windows.Forms.Label();
            this.otherAcc_img = new System.Windows.Forms.PictureBox();
            this.saveSettings = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.accountImg = new System.Windows.Forms.PictureBox();
            this.lockBack = new System.Windows.Forms.PictureBox();
            this.accInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accInfo_img)).BeginInit();
            this.space.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.space_img)).BeginInit();
            this.otherAcc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.otherAcc_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lockBack)).BeginInit();
            this.SuspendLayout();
            // 
            // accountName
            // 
            this.accountName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.accountName.Font = new System.Drawing.Font("Pacifico", 10.875F);
            this.accountName.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.accountName.Location = new System.Drawing.Point(0, 73);
            this.accountName.Name = "accountName";
            this.accountName.Size = new System.Drawing.Size(446, 58);
            this.accountName.TabIndex = 2;
            this.accountName.Text = "William Martin Joel";
            this.accountName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nickname
            // 
            this.nickname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nickname.Font = new System.Drawing.Font("Pacifico", 7.875F);
            this.nickname.ForeColor = System.Drawing.Color.DimGray;
            this.nickname.Location = new System.Drawing.Point(9, 131);
            this.nickname.Name = "nickname";
            this.nickname.Size = new System.Drawing.Size(437, 46);
            this.nickname.TabIndex = 3;
            this.nickname.Text = "\"Billy\"";
            this.nickname.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // accInfo
            // 
            this.accInfo.Controls.Add(this.accInfo_text);
            this.accInfo.Controls.Add(this.accInfo_img);
            this.accInfo.Location = new System.Drawing.Point(75, 232);
            this.accInfo.Name = "accInfo";
            this.accInfo.Size = new System.Drawing.Size(150, 150);
            this.accInfo.TabIndex = 4;
            this.accInfo.MouseLeave += new System.EventHandler(this.accountInfoItems_MouseLeave);
            this.accInfo.MouseHover += new System.EventHandler(this.accountInfoItems_Hover);
            // 
            // accInfo_text
            // 
            this.accInfo_text.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.accInfo_text.Location = new System.Drawing.Point(5, 86);
            this.accInfo_text.Name = "accInfo_text";
            this.accInfo_text.Size = new System.Drawing.Size(140, 60);
            this.accInfo_text.TabIndex = 7;
            this.accInfo_text.Text = "Account Information";
            this.accInfo_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.accInfo_text.MouseLeave += new System.EventHandler(this.accountInfoItems_MouseLeave);
            this.accInfo_text.MouseHover += new System.EventHandler(this.accountInfoItems_Hover);
            // 
            // accInfo_img
            // 
            this.accInfo_img.BackgroundImage = global::ProjectSnowshoes.Properties.Resources.PersonsOfScience;
            this.accInfo_img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.accInfo_img.Location = new System.Drawing.Point(45, 18);
            this.accInfo_img.Name = "accInfo_img";
            this.accInfo_img.Size = new System.Drawing.Size(60, 60);
            this.accInfo_img.TabIndex = 7;
            this.accInfo_img.TabStop = false;
            this.accInfo_img.MouseLeave += new System.EventHandler(this.accountInfoItems_MouseLeave);
            this.accInfo_img.MouseHover += new System.EventHandler(this.accountInfoItems_Hover);
            // 
            // space
            // 
            this.space.Controls.Add(this.space_text);
            this.space.Controls.Add(this.space_img);
            this.space.Location = new System.Drawing.Point(245, 232);
            this.space.Name = "space";
            this.space.Size = new System.Drawing.Size(150, 150);
            this.space.TabIndex = 8;
            this.space.Click += new System.EventHandler(this.spaceChanger_Click);
            this.space.MouseLeave += new System.EventHandler(this.spaceItems_MouseLeave);
            this.space.MouseHover += new System.EventHandler(this.spaceItems_Hover);
            // 
            // space_text
            // 
            this.space_text.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.space_text.Location = new System.Drawing.Point(5, 86);
            this.space_text.Name = "space_text";
            this.space_text.Size = new System.Drawing.Size(140, 60);
            this.space_text.TabIndex = 7;
            this.space_text.Text = "Space and Visuals";
            this.space_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.space_text.Click += new System.EventHandler(this.spaceChanger_Click);
            this.space_text.MouseLeave += new System.EventHandler(this.spaceItems_MouseLeave);
            this.space_text.MouseHover += new System.EventHandler(this.spaceItems_Hover);
            // 
            // space_img
            // 
            this.space_img.BackgroundImage = global::ProjectSnowshoes.Properties.Resources.WooooooooooooooooooooooooooooooooooooooDoges;
            this.space_img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.space_img.Location = new System.Drawing.Point(45, 18);
            this.space_img.Name = "space_img";
            this.space_img.Size = new System.Drawing.Size(60, 60);
            this.space_img.TabIndex = 7;
            this.space_img.TabStop = false;
            this.space_img.Click += new System.EventHandler(this.spaceChanger_Click);
            this.space_img.MouseLeave += new System.EventHandler(this.spaceItems_MouseLeave);
            this.space_img.MouseHover += new System.EventHandler(this.spaceItems_Hover);
            // 
            // otherAcc
            // 
            this.otherAcc.Controls.Add(this.otherAcc_text);
            this.otherAcc.Controls.Add(this.otherAcc_img);
            this.otherAcc.Location = new System.Drawing.Point(416, 232);
            this.otherAcc.Name = "otherAcc";
            this.otherAcc.Size = new System.Drawing.Size(150, 150);
            this.otherAcc.TabIndex = 8;
            this.otherAcc.MouseLeave += new System.EventHandler(this.otherAccItems_MouseLeave);
            this.otherAcc.MouseHover += new System.EventHandler(this.otherAccItems_Hover);
            // 
            // otherAcc_text
            // 
            this.otherAcc_text.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.otherAcc_text.Location = new System.Drawing.Point(5, 86);
            this.otherAcc_text.Name = "otherAcc_text";
            this.otherAcc_text.Size = new System.Drawing.Size(140, 60);
            this.otherAcc_text.TabIndex = 7;
            this.otherAcc_text.Text = "Other Accounts";
            this.otherAcc_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.otherAcc_text.MouseLeave += new System.EventHandler(this.otherAccItems_MouseLeave);
            this.otherAcc_text.MouseHover += new System.EventHandler(this.otherAccItems_Hover);
            // 
            // otherAcc_img
            // 
            this.otherAcc_img.BackgroundImage = global::ProjectSnowshoes.Properties.Resources.LookAtDat;
            this.otherAcc_img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.otherAcc_img.Location = new System.Drawing.Point(45, 18);
            this.otherAcc_img.Name = "otherAcc_img";
            this.otherAcc_img.Size = new System.Drawing.Size(60, 60);
            this.otherAcc_img.TabIndex = 7;
            this.otherAcc_img.TabStop = false;
            this.otherAcc_img.MouseLeave += new System.EventHandler(this.otherAccItems_MouseLeave);
            this.otherAcc_img.MouseHover += new System.EventHandler(this.otherAccItems_Hover);
            // 
            // saveSettings
            // 
            this.saveSettings.BackColor = System.Drawing.Color.RoyalBlue;
            this.saveSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.saveSettings.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.saveSettings.FlatAppearance.BorderSize = 0;
            this.saveSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveSettings.Image = global::ProjectSnowshoes.Properties.Resources.GroceryShoppingCheckmarks;
            this.saveSettings.Location = new System.Drawing.Point(426, 430);
            this.saveSettings.Name = "saveSettings";
            this.saveSettings.Size = new System.Drawing.Size(214, 50);
            this.saveSettings.TabIndex = 11;
            this.saveSettings.UseVisualStyleBackColor = false;
            this.saveSettings.Click += new System.EventHandler(this.saveSettings_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Firebrick;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::ProjectSnowshoes.Properties.Resources.XIco;
            this.button2.Location = new System.Drawing.Point(213, 430);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(213, 50);
            this.button2.TabIndex = 10;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SeaGreen;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::ProjectSnowshoes.Properties.Resources.PlusOne;
            this.button1.Location = new System.Drawing.Point(0, 430);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 50);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // accountImg
            // 
            this.accountImg.BackColor = System.Drawing.Color.Transparent;
            this.accountImg.BackgroundImage = global::ProjectSnowshoes.Properties.Resources.the_bridge_4e802407b8b80_1_;
            this.accountImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.accountImg.Location = new System.Drawing.Point(452, 27);
            this.accountImg.Name = "accountImg";
            this.accountImg.Size = new System.Drawing.Size(150, 150);
            this.accountImg.TabIndex = 1;
            this.accountImg.TabStop = false;
            this.accountImg.Click += new System.EventHandler(this.accountImg_Click);
            // 
            // lockBack
            // 
            this.lockBack.BackgroundImage = global::ProjectSnowshoes.Properties.Resources.img104;
            this.lockBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.lockBack.Dock = System.Windows.Forms.DockStyle.Top;
            this.lockBack.Location = new System.Drawing.Point(0, 0);
            this.lockBack.Name = "lockBack";
            this.lockBack.Size = new System.Drawing.Size(640, 69);
            this.lockBack.TabIndex = 0;
            this.lockBack.TabStop = false;
            this.lockBack.Click += new System.EventHandler(this.lockBack_Click);
            // 
            // UserSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(640, 480);
            this.Controls.Add(this.saveSettings);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.otherAcc);
            this.Controls.Add(this.space);
            this.Controls.Add(this.accInfo);
            this.Controls.Add(this.nickname);
            this.Controls.Add(this.accountName);
            this.Controls.Add(this.accountImg);
            this.Controls.Add(this.lockBack);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Roboto Light", 7.875F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserSettings";
            this.Text = "UserSettings";
            this.Load += new System.EventHandler(this.UserSettings_Load);
            this.accInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accInfo_img)).EndInit();
            this.space.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.space_img)).EndInit();
            this.otherAcc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.otherAcc_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lockBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox lockBack;
        private System.Windows.Forms.PictureBox accountImg;
        private System.Windows.Forms.Label accountName;
        private System.Windows.Forms.Label nickname;
        private System.Windows.Forms.Panel accInfo;
        private System.Windows.Forms.PictureBox accInfo_img;
        private System.Windows.Forms.Label accInfo_text;
        private System.Windows.Forms.Panel space;
        private System.Windows.Forms.Label space_text;
        private System.Windows.Forms.PictureBox space_img;
        private System.Windows.Forms.Panel otherAcc;
        private System.Windows.Forms.Label otherAcc_text;
        private System.Windows.Forms.PictureBox otherAcc_img;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button saveSettings;
    }
}