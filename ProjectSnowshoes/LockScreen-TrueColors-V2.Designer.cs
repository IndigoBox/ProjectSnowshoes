namespace ProjectSnowshoes
{
    partial class LockScreen_TrueColors_V2
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
            this.dataTimer = new System.Windows.Forms.Timer(this.components);
            this.timeTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.backChargePanel = new System.Windows.Forms.Panel();
            this.foreChargePanel = new System.Windows.Forms.Panel();
            this.percentRemain = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.backChargePanel.SuspendLayout();
            this.foreChargePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataTimer
            // 
            this.dataTimer.Enabled = true;
            this.dataTimer.Interval = 1;
            this.dataTimer.Tick += new System.EventHandler(this.dataTimer_Tick);
            // 
            // timeTimer
            // 
            this.timeTimer.Enabled = true;
            this.timeTimer.Interval = 1;
            this.timeTimer.Tick += new System.EventHandler(this.timeTimer_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::ProjectSnowshoes.Properties.Resources.BlGrayGradientWithDots1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.backChargePanel);
            this.panel1.Controls.Add(this.dateLabel);
            this.panel1.Controls.Add(this.timeLabel);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1366, 768);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Proxima Nova Lt", 9.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(967, 6);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(393, 73);
            this.label4.TabIndex = 4;
            this.label4.Text = "The Bridge Build\r\n(Designed for True Colors Build)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Proxima Nova Lt", 9.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(6, 6);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(393, 44);
            this.label3.TabIndex = 2;
            this.label3.Text = "Project Snowshoes";
            // 
            // backChargePanel
            // 
            this.backChargePanel.BackColor = System.Drawing.Color.Transparent;
            this.backChargePanel.BackgroundImage = global::ProjectSnowshoes.Properties.Resources._50pertrans_gray;
            this.backChargePanel.Controls.Add(this.foreChargePanel);
            this.backChargePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.backChargePanel.Location = new System.Drawing.Point(0, 721);
            this.backChargePanel.Margin = new System.Windows.Forms.Padding(6);
            this.backChargePanel.Name = "backChargePanel";
            this.backChargePanel.Size = new System.Drawing.Size(1366, 47);
            this.backChargePanel.TabIndex = 3;
            // 
            // foreChargePanel
            // 
            this.foreChargePanel.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.foreChargePanel.Controls.Add(this.percentRemain);
            this.foreChargePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.foreChargePanel.Location = new System.Drawing.Point(0, 0);
            this.foreChargePanel.Margin = new System.Windows.Forms.Padding(6);
            this.foreChargePanel.Name = "foreChargePanel";
            this.foreChargePanel.Size = new System.Drawing.Size(1284, 47);
            this.foreChargePanel.TabIndex = 2;
            this.foreChargePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.foreChargePanel_Paint);
            // 
            // percentRemain
            // 
            this.percentRemain.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.percentRemain.BackColor = System.Drawing.Color.Transparent;
            this.percentRemain.Font = new System.Drawing.Font("Proxima Nova Rg", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percentRemain.ForeColor = System.Drawing.Color.White;
            this.percentRemain.Location = new System.Drawing.Point(15, 0);
            this.percentRemain.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.percentRemain.Name = "percentRemain";
            this.percentRemain.Size = new System.Drawing.Size(376, 44);
            this.percentRemain.TabIndex = 1;
            this.percentRemain.Text = "9 4 %  r e m a i n i n g";
            this.percentRemain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateLabel
            // 
            this.dateLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateLabel.Font = new System.Drawing.Font("Proxima Nova Lt", 14F);
            this.dateLabel.ForeColor = System.Drawing.Color.Silver;
            this.dateLabel.Location = new System.Drawing.Point(487, 400);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(393, 50);
            this.dateLabel.TabIndex = 2;
            this.dateLabel.Text = "Tuesday, April 21, 2015";
            this.dateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timeLabel
            // 
            this.timeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.timeLabel.Font = new System.Drawing.Font("Proxima Nova Rg", 29.875F, System.Drawing.FontStyle.Bold);
            this.timeLabel.ForeColor = System.Drawing.Color.White;
            this.timeLabel.Location = new System.Drawing.Point(486, 316);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(394, 84);
            this.timeLabel.TabIndex = 1;
            this.timeLabel.Text = "3:52";
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::ProjectSnowshoes.Properties.Resources.marchMadness;
            this.pictureBox1.Location = new System.Drawing.Point(457, 263);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(452, 243);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // LockScreen_TrueColors_V2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Proxima Nova Rg", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LockScreen_TrueColors_V2";
            this.Text = "LockScreen_TrueColors_V2";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LockScreen_TrueColors_V2_Load);
            this.panel1.ResumeLayout(false);
            this.backChargePanel.ResumeLayout(false);
            this.foreChargePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Panel backChargePanel;
        private System.Windows.Forms.Panel foreChargePanel;
        private System.Windows.Forms.Label percentRemain;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer dataTimer;
        private System.Windows.Forms.Timer timeTimer;
    }
}