namespace ProjectSnowshoes
{
    partial class BattCritical
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.takingChancesAgain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Roboto Light", 20.875F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(260, 377);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(847, 183);
            this.label1.TabIndex = 0;
            this.label1.Text = "No, actually.\r\nYour battery is really low.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Roboto Light", 12.875F);
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(260, 560);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(847, 85);
            this.label2.TabIndex = 1;
            this.label2.Text = "Find an outlet relatively quick, friend. (No pressure)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::ProjectSnowshoes.Properties.Resources.ThisBatterySymbol;
            this.pictureBox1.Location = new System.Drawing.Point(497, 124);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(372, 250);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // takingChancesAgain
            // 
            this.takingChancesAgain.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.takingChancesAgain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.takingChancesAgain.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.takingChancesAgain.FlatAppearance.BorderSize = 0;
            this.takingChancesAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.takingChancesAgain.Font = new System.Drawing.Font("Roboto", 9.875F);
            this.takingChancesAgain.ForeColor = System.Drawing.Color.White;
            this.takingChancesAgain.Location = new System.Drawing.Point(0, 701);
            this.takingChancesAgain.Name = "takingChancesAgain";
            this.takingChancesAgain.Size = new System.Drawing.Size(1366, 67);
            this.takingChancesAgain.TabIndex = 3;
            this.takingChancesAgain.Text = "I\'ll take my chances.";
            this.takingChancesAgain.UseVisualStyleBackColor = false;
            this.takingChancesAgain.Click += new System.EventHandler(this.takingChancesAgain_Click);
            // 
            // BattCritical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.takingChancesAgain);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Roboto Light", 7.875F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BattCritical";
            this.Opacity = 0.9D;
            this.Text = "BattCritical";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BattCritical_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button takingChancesAgain;
    }
}