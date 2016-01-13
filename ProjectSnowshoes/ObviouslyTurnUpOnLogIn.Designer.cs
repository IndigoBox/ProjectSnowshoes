namespace ProjectSnowshoes
{
    partial class ObviouslyTurnUpOnLogIn
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
            this.backChargePanel = new System.Windows.Forms.Panel();
            this.foreChargePanel = new System.Windows.Forms.Panel();
            this.percentRemain = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.timeTimer = new System.Windows.Forms.Timer(this.components);
            this.dataTimer = new System.Windows.Forms.Timer(this.components);
            this.backChargePanel.SuspendLayout();
            this.foreChargePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // backChargePanel
            // 
            this.backChargePanel.BackColor = System.Drawing.Color.Transparent;
            this.backChargePanel.BackgroundImage = global::ProjectSnowshoes.Properties.Resources._50pertrans_gray;
            this.backChargePanel.Controls.Add(this.foreChargePanel);
            this.backChargePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.backChargePanel.Location = new System.Drawing.Point(0, 0);
            this.backChargePanel.Margin = new System.Windows.Forms.Padding(6);
            this.backChargePanel.Name = "backChargePanel";
            this.backChargePanel.Size = new System.Drawing.Size(400, 1385);
            this.backChargePanel.TabIndex = 0;
            // 
            // foreChargePanel
            // 
            this.foreChargePanel.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.foreChargePanel.Controls.Add(this.percentRemain);
            this.foreChargePanel.Controls.Add(this.date);
            this.foreChargePanel.Controls.Add(this.time);
            this.foreChargePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.foreChargePanel.Location = new System.Drawing.Point(0, 670);
            this.foreChargePanel.Margin = new System.Windows.Forms.Padding(6);
            this.foreChargePanel.Name = "foreChargePanel";
            this.foreChargePanel.Size = new System.Drawing.Size(400, 715);
            this.foreChargePanel.TabIndex = 2;
            // 
            // percentRemain
            // 
            this.percentRemain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.percentRemain.BackColor = System.Drawing.Color.Transparent;
            this.percentRemain.Font = new System.Drawing.Font("Roboto Light", 10.25F);
            this.percentRemain.ForeColor = System.Drawing.Color.Silver;
            this.percentRemain.Location = new System.Drawing.Point(28, 660);
            this.percentRemain.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.percentRemain.Name = "percentRemain";
            this.percentRemain.Size = new System.Drawing.Size(370, 44);
            this.percentRemain.TabIndex = 1;
            this.percentRemain.Text = "94% remaining";
            this.percentRemain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // date
            // 
            this.date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.date.BackColor = System.Drawing.Color.Transparent;
            this.date.Font = new System.Drawing.Font("Roboto Light", 16.25F);
            this.date.ForeColor = System.Drawing.Color.Silver;
            this.date.Location = new System.Drawing.Point(24, 479);
            this.date.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(370, 183);
            this.date.TabIndex = 3;
            this.date.Text = "Wednesday\r\nSeptember 24\r\n2014";
            this.date.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // time
            // 
            this.time.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.time.BackColor = System.Drawing.Color.Transparent;
            this.time.Font = new System.Drawing.Font("Roboto Light", 48.25F);
            this.time.ForeColor = System.Drawing.Color.White;
            this.time.Location = new System.Drawing.Point(-6, 308);
            this.time.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(400, 183);
            this.time.TabIndex = 1;
            this.time.Text = "12:34";
            this.time.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timeTimer
            // 
            this.timeTimer.Enabled = true;
            this.timeTimer.Interval = 1;
            this.timeTimer.Tick += new System.EventHandler(this.timeTimer_Tick);
            // 
            // dataTimer
            // 
            this.dataTimer.Enabled = true;
            this.dataTimer.Interval = 1;
            this.dataTimer.Tick += new System.EventHandler(this.dataTimer_Tick);
            // 
            // ObviouslyTurnUpOnLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjectSnowshoes.Properties.Resources.img104;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(2560, 1385);
            this.Controls.Add(this.backChargePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ObviouslyTurnUpOnLogIn";
            this.Text = "ObviouslyTurnUpOnLogIn";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ObviouslyTurnUpOnLogIn_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TurnDown_KeyDown);
            this.backChargePanel.ResumeLayout(false);
            this.foreChargePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel backChargePanel;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Panel foreChargePanel;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label percentRemain;
        private System.Windows.Forms.Timer timeTimer;
        private System.Windows.Forms.Timer dataTimer;
    }
}