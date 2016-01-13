namespace ProjectSnowshoes
{
    partial class AppsSlidingMenu
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
            this.themAppsTho = new System.Windows.Forms.FlowLayoutPanel();
            this.inTheaters = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // themAppsTho
            // 
            this.themAppsTho.AutoScroll = true;
            this.themAppsTho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.themAppsTho.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.themAppsTho.Location = new System.Drawing.Point(0, 0);
            this.themAppsTho.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.themAppsTho.Name = "themAppsTho";
            this.themAppsTho.Padding = new System.Windows.Forms.Padding(15, 21, 15, 16);
            this.themAppsTho.Size = new System.Drawing.Size(528, 463);
            this.themAppsTho.TabIndex = 2;
            // 
            // inTheaters
            // 
            this.inTheaters.Enabled = true;
            this.inTheaters.Interval = 1;
            this.inTheaters.Tick += new System.EventHandler(this.inTheaters_Tick);
            // 
            // AppsSlidingMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(528, 463);
            this.Controls.Add(this.themAppsTho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AppsSlidingMenu";
            this.Text = " ";
            this.Load += new System.EventHandler(this.AppsSlidingMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel themAppsTho;
        private System.Windows.Forms.Timer inTheaters;
    }
}