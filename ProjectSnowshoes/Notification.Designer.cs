namespace ProjectSnowshoes
{
    partial class Notification
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
            this.components = new System.ComponentModel.Container();
            this.notifIcon = new System.Windows.Forms.PictureBox();
            this.notifTitle = new System.Windows.Forms.Label();
            this.notificationTimer = new System.Windows.Forms.Timer(this.components);
            this.notifSubtitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.notifIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // notifIcon
            // 
            this.notifIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.notifIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.notifIcon.Location = new System.Drawing.Point(0, 0);
            this.notifIcon.Name = "notifIcon";
            this.notifIcon.Size = new System.Drawing.Size(100, 100);
            this.notifIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.notifIcon.TabIndex = 1;
            this.notifIcon.TabStop = false;
            // 
            // notifTitle
            // 
            this.notifTitle.AutoEllipsis = true;
            this.notifTitle.BackColor = System.Drawing.Color.Transparent;
            this.notifTitle.Font = new System.Drawing.Font("Roboto Light", 11.25F);
            this.notifTitle.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.notifTitle.Location = new System.Drawing.Point(112, 9);
            this.notifTitle.Name = "notifTitle";
            this.notifTitle.Size = new System.Drawing.Size(248, 22);
            this.notifTitle.TabIndex = 2;
            this.notifTitle.Text = "It\'s midnight.";
            // 
            // notificationTimer
            // 
            this.notificationTimer.Enabled = true;
            this.notificationTimer.Interval = 1;
            this.notificationTimer.Tick += new System.EventHandler(this.notificationTimer_Tick);
            // 
            // notifSubtitle
            // 
            this.notifSubtitle.AutoEllipsis = true;
            this.notifSubtitle.BackColor = System.Drawing.Color.Transparent;
            this.notifSubtitle.Font = new System.Drawing.Font("Roboto Light", 9.25F);
            this.notifSubtitle.ForeColor = System.Drawing.Color.DimGray;
            this.notifSubtitle.Location = new System.Drawing.Point(113, 31);
            this.notifSubtitle.Name = "notifSubtitle";
            this.notifSubtitle.Size = new System.Drawing.Size(247, 60);
            this.notifSubtitle.TabIndex = 3;
            this.notifSubtitle.Text = "At least, it will be soon. You better get going. The quick brown fox jumps over t" +
    "he lazy doge. Woot woot and turn up, and here is some more text.";
            // 
            // Notification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::ProjectSnowshoes.Properties.Resources.LoginBack;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(804, 100);
            this.Controls.Add(this.notifSubtitle);
            this.Controls.Add(this.notifTitle);
            this.Controls.Add(this.notifIcon);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Roboto Light", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Notification";
            this.Text = "Notification";
            this.Load += new System.EventHandler(this.Notification_Load);
            ((System.ComponentModel.ISupportInitialize)(this.notifIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox notifIcon;
        private System.Windows.Forms.Label notifTitle;
        private System.Windows.Forms.Timer notificationTimer;
        private System.Windows.Forms.Label notifSubtitle;
    }
}