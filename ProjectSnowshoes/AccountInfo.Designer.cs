namespace ProjectSnowshoes
{
    partial class AccountInfo
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
            this.lockBack = new System.Windows.Forms.PictureBox();
            this.nickname = new System.Windows.Forms.Label();
            this.accountName = new System.Windows.Forms.Label();
            this.accountImg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.lockBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountImg)).BeginInit();
            this.SuspendLayout();
            // 
            // lockBack
            // 
            this.lockBack.BackgroundImage = global::ProjectSnowshoes.Properties.Resources.img104;
            this.lockBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.lockBack.Dock = System.Windows.Forms.DockStyle.Top;
            this.lockBack.Location = new System.Drawing.Point(0, 0);
            this.lockBack.Name = "lockBack";
            this.lockBack.Size = new System.Drawing.Size(640, 69);
            this.lockBack.TabIndex = 4;
            this.lockBack.TabStop = false;
            // 
            // nickname
            // 
            this.nickname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nickname.Font = new System.Drawing.Font("Pacifico", 7.875F);
            this.nickname.ForeColor = System.Drawing.Color.DimGray;
            this.nickname.Location = new System.Drawing.Point(35, 127);
            this.nickname.Name = "nickname";
            this.nickname.Size = new System.Drawing.Size(437, 46);
            this.nickname.TabIndex = 7;
            this.nickname.Text = "\"Doge\"";
            this.nickname.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // accountName
            // 
            this.accountName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.accountName.Font = new System.Drawing.Font("Pacifico", 10.875F);
            this.accountName.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.accountName.Location = new System.Drawing.Point(26, 69);
            this.accountName.Name = "accountName";
            this.accountName.Size = new System.Drawing.Size(446, 58);
            this.accountName.TabIndex = 6;
            this.accountName.Text = "Jack Altman";
            this.accountName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // accountImg
            // 
            this.accountImg.BackColor = System.Drawing.Color.Transparent;
            this.accountImg.BackgroundImage = global::ProjectSnowshoes.Properties.Resources.the_bridge_4e802407b8b80_1_;
            this.accountImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.accountImg.Location = new System.Drawing.Point(478, 23);
            this.accountImg.Name = "accountImg";
            this.accountImg.Size = new System.Drawing.Size(150, 150);
            this.accountImg.TabIndex = 5;
            this.accountImg.TabStop = false;
            // 
            // AccountInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 480);
            this.Controls.Add(this.nickname);
            this.Controls.Add(this.accountName);
            this.Controls.Add(this.accountImg);
            this.Controls.Add(this.lockBack);
            this.Font = new System.Drawing.Font("Roboto Light", 7.875F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AccountInfo";
            this.Text = "AccountInfo";
            ((System.ComponentModel.ISupportInitialize)(this.lockBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox lockBack;
        private System.Windows.Forms.Label nickname;
        private System.Windows.Forms.Label accountName;
        private System.Windows.Forms.PictureBox accountImg;
    }
}