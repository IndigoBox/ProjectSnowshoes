namespace ProjectSnowshoes
{
    partial class BottomBar_Concept124
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
            this.name = new System.Windows.Forms.Label();
            this.spaceForProcesses = new System.Windows.Forms.FlowLayoutPanel();
            this.timeSpaceContinuum = new System.Windows.Forms.Label();
            this.timeTimer = new System.Windows.Forms.Timer(this.components);
            this.dogeAccountImg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dogeAccountImg)).BeginInit();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.Color.Orange;
            this.name.Dock = System.Windows.Forms.DockStyle.Left;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.Color.White;
            this.name.Location = new System.Drawing.Point(0, 0);
            this.name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(102, 36);
            this.name.TabIndex = 0;
            this.name.Text = "Mitter";
            this.name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.name.Click += new System.EventHandler(this.name_Click);
            // 
            // spaceForProcesses
            // 
            this.spaceForProcesses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spaceForProcesses.AutoScroll = true;
            this.spaceForProcesses.BackColor = System.Drawing.Color.Transparent;
            this.spaceForProcesses.Location = new System.Drawing.Point(106, 3);
            this.spaceForProcesses.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.spaceForProcesses.Name = "spaceForProcesses";
            this.spaceForProcesses.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.spaceForProcesses.Size = new System.Drawing.Size(490, 31);
            this.spaceForProcesses.TabIndex = 9;
            // 
            // timeSpaceContinuum
            // 
            this.timeSpaceContinuum.Dock = System.Windows.Forms.DockStyle.Right;
            this.timeSpaceContinuum.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.874999F);
            this.timeSpaceContinuum.ForeColor = System.Drawing.Color.Black;
            this.timeSpaceContinuum.Location = new System.Drawing.Point(620, 0);
            this.timeSpaceContinuum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timeSpaceContinuum.Name = "timeSpaceContinuum";
            this.timeSpaceContinuum.Size = new System.Drawing.Size(63, 36);
            this.timeSpaceContinuum.TabIndex = 10;
            this.timeSpaceContinuum.Text = "12:04 PM";
            this.timeSpaceContinuum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.timeSpaceContinuum.Click += new System.EventHandler(this.timeSpaceContinuum_Click);
            // 
            // timeTimer
            // 
            this.timeTimer.Enabled = true;
            this.timeTimer.Interval = 1;
            this.timeTimer.Tick += new System.EventHandler(this.timeTimer_Tick);
            // 
            // dogeAccountImg
            // 
            this.dogeAccountImg.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dogeAccountImg.BackColor = System.Drawing.Color.Transparent;
            this.dogeAccountImg.BackgroundImage = global::ProjectSnowshoes.Properties.Resources.Minerva820_Silver;
            this.dogeAccountImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.dogeAccountImg.Location = new System.Drawing.Point(598, 10);
            this.dogeAccountImg.Margin = new System.Windows.Forms.Padding(2);
            this.dogeAccountImg.Name = "dogeAccountImg";
            this.dogeAccountImg.Size = new System.Drawing.Size(20, 17);
            this.dogeAccountImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dogeAccountImg.TabIndex = 11;
            this.dogeAccountImg.TabStop = false;
            this.dogeAccountImg.Click += new System.EventHandler(this.dogeAccountImg_Click);
            // 
            // BottomBar_Concept124
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(683, 36);
            this.Controls.Add(this.dogeAccountImg);
            this.Controls.Add(this.timeSpaceContinuum);
            this.Controls.Add(this.spaceForProcesses);
            this.Controls.Add(this.name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BottomBar_Concept124";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Load += new System.EventHandler(this.BottomBar_Concept124_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dogeAccountImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.FlowLayoutPanel spaceForProcesses;
        private System.Windows.Forms.Label timeSpaceContinuum;
        private System.Windows.Forms.Timer timeTimer;
        private System.Windows.Forms.PictureBox dogeAccountImg;
    }
}