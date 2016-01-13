namespace ProjectSnowshoes
{
    partial class BottomBar
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
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.spaceForProcesses = new System.Windows.Forms.FlowLayoutPanel();
            this.dogeAccountImg = new System.Windows.Forms.PictureBox();
            this.name = new System.Windows.Forms.Label();
            this.timeSpaceContinuum = new System.Windows.Forms.Label();
            this.timeTimer = new System.Windows.Forms.Timer(this.components);
            this.bottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dogeAccountImg)).BeginInit();
            this.SuspendLayout();
            // 
            // bottomPanel
            // 
            this.bottomPanel.BackColor = System.Drawing.Color.Transparent;
            this.bottomPanel.Controls.Add(this.spaceForProcesses);
            this.bottomPanel.Controls.Add(this.dogeAccountImg);
            this.bottomPanel.Controls.Add(this.name);
            this.bottomPanel.Controls.Add(this.timeSpaceContinuum);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomPanel.Location = new System.Drawing.Point(0, 0);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(1366, 70);
            this.bottomPanel.TabIndex = 6;
            // 
            // spaceForProcesses
            // 
            this.spaceForProcesses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spaceForProcesses.AutoScroll = true;
            this.spaceForProcesses.BackColor = System.Drawing.Color.Transparent;
            this.spaceForProcesses.Location = new System.Drawing.Point(154, 7);
            this.spaceForProcesses.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.spaceForProcesses.Name = "spaceForProcesses";
            this.spaceForProcesses.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.spaceForProcesses.Size = new System.Drawing.Size(981, 59);
            this.spaceForProcesses.TabIndex = 8;
            // 
            // dogeAccountImg
            // 
            this.dogeAccountImg.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dogeAccountImg.BackColor = System.Drawing.Color.Transparent;
            this.dogeAccountImg.BackgroundImage = global::ProjectSnowshoes.Properties.Resources.Minerva;
            this.dogeAccountImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.dogeAccountImg.Location = new System.Drawing.Point(1142, 8);
            this.dogeAccountImg.Name = "dogeAccountImg";
            this.dogeAccountImg.Size = new System.Drawing.Size(50, 50);
            this.dogeAccountImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dogeAccountImg.TabIndex = 7;
            this.dogeAccountImg.TabStop = false;
            this.dogeAccountImg.Click += new System.EventHandler(this.dogeAccountImg_Click);
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.name.Dock = System.Windows.Forms.DockStyle.Left;
            this.name.Font = new System.Drawing.Font("Roboto Light", 9F);
            this.name.ForeColor = System.Drawing.Color.White;
            this.name.Location = new System.Drawing.Point(0, 0);
            this.name.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(145, 70);
            this.name.TabIndex = 0;
            this.name.Text = "Robert";
            this.name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.name.Click += new System.EventHandler(this.name_Click);
            // 
            // timeSpaceContinuum
            // 
            this.timeSpaceContinuum.BackColor = System.Drawing.Color.Transparent;
            this.timeSpaceContinuum.Dock = System.Windows.Forms.DockStyle.Right;
            this.timeSpaceContinuum.Font = new System.Drawing.Font("Roboto", 10.875F);
            this.timeSpaceContinuum.ForeColor = System.Drawing.Color.Black;
            this.timeSpaceContinuum.Location = new System.Drawing.Point(1198, 0);
            this.timeSpaceContinuum.Name = "timeSpaceContinuum";
            this.timeSpaceContinuum.Size = new System.Drawing.Size(168, 70);
            this.timeSpaceContinuum.TabIndex = 6;
            this.timeSpaceContinuum.Text = "9:26 AM";
            this.timeSpaceContinuum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.timeSpaceContinuum.Click += new System.EventHandler(this.timeSpaceContinuum_Click);
            // 
            // timeTimer
            // 
            this.timeTimer.Enabled = true;
            this.timeTimer.Interval = 1;
            this.timeTimer.Tick += new System.EventHandler(this.timeTimer_Tick);
            // 
            // BottomBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1366, 70);
            this.Controls.Add(this.bottomPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BottomBar";
            this.Text = "BottomBar";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Load += new System.EventHandler(this.BottomBar_Load);
            this.bottomPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dogeAccountImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.FlowLayoutPanel spaceForProcesses;
        private System.Windows.Forms.PictureBox dogeAccountImg;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label timeSpaceContinuum;
        private System.Windows.Forms.Timer timeTimer;
    }
}