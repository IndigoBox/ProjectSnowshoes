namespace ProjectSnowshoes
{
    partial class AboutSnowshoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutSnowshoes));
            this.projSnow = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.procButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // projSnow
            // 
            this.projSnow.BackColor = System.Drawing.Color.White;
            this.projSnow.Font = new System.Drawing.Font("Roboto Light", 16.75F);
            this.projSnow.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.projSnow.Location = new System.Drawing.Point(-26, 0);
            this.projSnow.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.projSnow.Name = "projSnow";
            this.projSnow.Size = new System.Drawing.Size(962, 99);
            this.projSnow.TabIndex = 5;
            this.projSnow.Text = "Project Snowshoes";
            this.projSnow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Light", 10.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(354, 129);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "made with love by";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjectSnowshoes.Properties.Resources.TheIndigoBlueConsortium;
            this.pictureBox1.Location = new System.Drawing.Point(256, 173);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(397, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Roboto Light", 12.75F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(16, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(879, 99);
            this.label4.TabIndex = 6;
            this.label4.Text = "The Bridge Build\r\n(start: 10/10/2014)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // procButton
            // 
            this.procButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.procButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.procButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.procButton.Font = new System.Drawing.Font("Roboto Light", 10.25F);
            this.procButton.ForeColor = System.Drawing.Color.White;
            this.procButton.Location = new System.Drawing.Point(378, 430);
            this.procButton.Margin = new System.Windows.Forms.Padding(6);
            this.procButton.Name = "procButton";
            this.procButton.Size = new System.Drawing.Size(158, 56);
            this.procButton.TabIndex = 10;
            this.procButton.Text = "Proceed";
            this.procButton.UseVisualStyleBackColor = false;
            this.procButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Roboto Light", 9.25F);
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(0, 306);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(909, 92);
            this.label2.TabIndex = 11;
            this.label2.Text = resources.GetString("label2.Text");
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.procButton);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(909, 520);
            this.panel1.TabIndex = 11;
            // 
            // AboutSnowshoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = global::ProjectSnowshoes.Properties.Resources.the_bridge_4e802407b8b80_1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(909, 614);
            this.Controls.Add(this.projSnow);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AboutSnowshoes";
            this.Text = "AboutSnowshoes";
            this.Load += new System.EventHandler(this.AboutSnowshoes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label projSnow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button procButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
    }
}