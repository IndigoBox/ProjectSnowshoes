namespace ProjectSnowshoes
{
    partial class ThanksScn9A
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
            this.time = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.thanksAgain = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // time
            // 
            this.time.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.time.BackColor = System.Drawing.Color.Transparent;
            this.time.Font = new System.Drawing.Font("Proxima Nova Rg", 24.875F);
            this.time.ForeColor = System.Drawing.Color.White;
            this.time.Location = new System.Drawing.Point(0, 300);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(1366, 119);
            this.time.TabIndex = 0;
            this.time.Text = "10:52 PM";
            this.time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // date
            // 
            this.date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.date.Font = new System.Drawing.Font("Proxima Nova Rg", 14.875F);
            this.date.ForeColor = System.Drawing.Color.Silver;
            this.date.Location = new System.Drawing.Point(0, 419);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(1366, 69);
            this.date.TabIndex = 1;
            this.date.Text = "Sunday, December 21, 2014";
            this.date.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // thanksAgain
            // 
            this.thanksAgain.Enabled = true;
            this.thanksAgain.Interval = 1;
            this.thanksAgain.Tick += new System.EventHandler(this.thanksAgain_Tick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Proxima Nova Rg", 12.875F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1041, 668);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 43);
            this.label1.TabIndex = 2;
            this.label1.Text = "Project Snowshoes";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Proxima Nova Rg", 12.875F);
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(1041, 715);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(313, 43);
            this.label2.TabIndex = 3;
            this.label2.Text = "The Bridge Build";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.Font = new System.Drawing.Font("Proxima Nova Rg", 12.875F);
            this.label3.ForeColor = System.Drawing.Color.DarkGray;
            this.label3.Location = new System.Drawing.Point(6, 619);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(919, 140);
            this.label3.TabIndex = 4;
            this.label3.Text = "Inspired By \"What Colour Is It?\" by SCN9A\r\n\r\nDeveloper Note: To be released in th" +
    "e \"True Colors\" build";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // ThanksScn9A
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(37F, 80F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.date);
            this.Controls.Add(this.time);
            this.Font = new System.Drawing.Font("Proxima Nova Rg", 24.875F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(9);
            this.Name = "ThanksScn9A";
            this.Text = "ThanksScn9A";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Timer thanksAgain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}