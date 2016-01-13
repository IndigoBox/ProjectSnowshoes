namespace ProjectSnowshoes
{
    partial class ChangeBackground
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
            this.chooseWiselyWelcome = new System.Windows.Forms.Panel();
            this.greeting = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pathText = new System.Windows.Forms.TextBox();
            this.browsePathButton = new System.Windows.Forms.Button();
            this.finalizeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.spaceImg = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.colorPanel = new System.Windows.Forms.Label();
            this.colorLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.chooseWiselyWelcome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spaceImg)).BeginInit();
            this.SuspendLayout();
            // 
            // chooseWiselyWelcome
            // 
            this.chooseWiselyWelcome.BackColor = System.Drawing.Color.Red;
            this.chooseWiselyWelcome.Controls.Add(this.greeting);
            this.chooseWiselyWelcome.Location = new System.Drawing.Point(0, 0);
            this.chooseWiselyWelcome.Name = "chooseWiselyWelcome";
            this.chooseWiselyWelcome.Size = new System.Drawing.Size(569, 55);
            this.chooseWiselyWelcome.TabIndex = 0;
            // 
            // greeting
            // 
            this.greeting.AutoSize = true;
            this.greeting.Font = new System.Drawing.Font("Roboto Light", 14.25F);
            this.greeting.ForeColor = System.Drawing.Color.White;
            this.greeting.Location = new System.Drawing.Point(12, 15);
            this.greeting.Name = "greeting";
            this.greeting.Size = new System.Drawing.Size(201, 23);
            this.greeting.TabIndex = 1;
            this.greeting.Text = "Choose wisely, person.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Light", 16.25F);
            this.label3.Location = new System.Drawing.Point(130, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 27);
            this.label3.TabIndex = 1;
            this.label3.Text = "Space";
            // 
            // pathText
            // 
            this.pathText.Font = new System.Drawing.Font("Roboto Light", 10.25F);
            this.pathText.Location = new System.Drawing.Point(18, 285);
            this.pathText.Name = "pathText";
            this.pathText.Size = new System.Drawing.Size(217, 24);
            this.pathText.TabIndex = 2;
            this.pathText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // browsePathButton
            // 
            this.browsePathButton.BackColor = System.Drawing.Color.Maroon;
            this.browsePathButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.browsePathButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browsePathButton.Font = new System.Drawing.Font("Roboto Light", 9.25F);
            this.browsePathButton.ForeColor = System.Drawing.Color.White;
            this.browsePathButton.Location = new System.Drawing.Point(241, 283);
            this.browsePathButton.Name = "browsePathButton";
            this.browsePathButton.Size = new System.Drawing.Size(74, 31);
            this.browsePathButton.TabIndex = 3;
            this.browsePathButton.Text = "Browse";
            this.browsePathButton.UseVisualStyleBackColor = false;
            this.browsePathButton.Click += new System.EventHandler(this.browsePathButton_Click);
            // 
            // finalizeButton
            // 
            this.finalizeButton.BackColor = System.Drawing.Color.Maroon;
            this.finalizeButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.finalizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.finalizeButton.Font = new System.Drawing.Font("Roboto Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalizeButton.ForeColor = System.Drawing.Color.White;
            this.finalizeButton.Location = new System.Drawing.Point(-2, 335);
            this.finalizeButton.Name = "finalizeButton";
            this.finalizeButton.Size = new System.Drawing.Size(581, 48);
            this.finalizeButton.TabIndex = 4;
            this.finalizeButton.Text = "Save";
            this.finalizeButton.UseVisualStyleBackColor = false;
            this.finalizeButton.Click += new System.EventHandler(this.finalizeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Light", 10.25F);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(25, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Type the path of the image, or click \"Browse.\"";
            // 
            // spaceImg
            // 
            this.spaceImg.Location = new System.Drawing.Point(68, 90);
            this.spaceImg.Name = "spaceImg";
            this.spaceImg.Size = new System.Drawing.Size(196, 110);
            this.spaceImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.spaceImg.TabIndex = 6;
            this.spaceImg.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Light", 16.25F);
            this.label2.Location = new System.Drawing.Point(440, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 27);
            this.label2.TabIndex = 8;
            this.label2.Text = "Color";
            // 
            // colorPanel
            // 
            this.colorPanel.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorPanel.ForeColor = System.Drawing.Color.White;
            this.colorPanel.Location = new System.Drawing.Point(397, 90);
            this.colorPanel.Name = "colorPanel";
            this.colorPanel.Size = new System.Drawing.Size(145, 110);
            this.colorPanel.TabIndex = 9;
            this.colorPanel.Text = "Color Name Here";
            this.colorPanel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.colorPanel.Click += new System.EventHandler(this.colorPanel_Click);
            // 
            // colorLayoutPanel
            // 
            this.colorLayoutPanel.AutoScroll = true;
            this.colorLayoutPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.colorLayoutPanel.Location = new System.Drawing.Point(569, 0);
            this.colorLayoutPanel.Name = "colorLayoutPanel";
            this.colorLayoutPanel.Size = new System.Drawing.Size(271, 382);
            this.colorLayoutPanel.TabIndex = 10;
            // 
            // ChangeBackground
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(567, 381);
            this.Controls.Add(this.colorLayoutPanel);
            this.Controls.Add(this.colorPanel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.spaceImg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.finalizeButton);
            this.Controls.Add(this.browsePathButton);
            this.Controls.Add(this.pathText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chooseWiselyWelcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ChangeBackground";
            this.Text = "ChangeBackground";
            this.Load += new System.EventHandler(this.ChangeBackground_Load);
            this.chooseWiselyWelcome.ResumeLayout(false);
            this.chooseWiselyWelcome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spaceImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel chooseWiselyWelcome;
        private System.Windows.Forms.Label greeting;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pathText;
        private System.Windows.Forms.Button browsePathButton;
        private System.Windows.Forms.Button finalizeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox spaceImg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label colorPanel;
        private System.Windows.Forms.FlowLayoutPanel colorLayoutPanel;
    }
}