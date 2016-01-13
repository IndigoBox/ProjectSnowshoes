namespace ProjectSnowshoes
{
    partial class Documents
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
            this.openDocsWinExp = new System.Windows.Forms.Button();
            this.themDocsTho = new System.Windows.Forms.FlowLayoutPanel();
            this.inTheaters = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // openDocsWinExp
            // 
            this.openDocsWinExp.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.openDocsWinExp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.openDocsWinExp.FlatAppearance.BorderSize = 0;
            this.openDocsWinExp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openDocsWinExp.Font = new System.Drawing.Font("Roboto Light", 10.875F);
            this.openDocsWinExp.ForeColor = System.Drawing.Color.White;
            this.openDocsWinExp.Image = global::ProjectSnowshoes.Properties.Resources.IMeanSure;
            this.openDocsWinExp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.openDocsWinExp.Location = new System.Drawing.Point(0, 424);
            this.openDocsWinExp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.openDocsWinExp.Name = "openDocsWinExp";
            this.openDocsWinExp.Size = new System.Drawing.Size(528, 39);
            this.openDocsWinExp.TabIndex = 0;
            this.openDocsWinExp.Text = "           Open in Windows Explorer";
            this.openDocsWinExp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.openDocsWinExp.UseVisualStyleBackColor = false;
            this.openDocsWinExp.Click += new System.EventHandler(this.button1_Click);
            // 
            // themDocsTho
            // 
            this.themDocsTho.AutoScroll = true;
            this.themDocsTho.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.themDocsTho.Location = new System.Drawing.Point(0, 0);
            this.themDocsTho.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.themDocsTho.Name = "themDocsTho";
            this.themDocsTho.Size = new System.Drawing.Size(528, 424);
            this.themDocsTho.TabIndex = 1;
            // 
            // inTheaters
            // 
            this.inTheaters.Enabled = true;
            this.inTheaters.Interval = 1;
            this.inTheaters.Tick += new System.EventHandler(this.inTheaters_Tick);
            // 
            // Documents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(528, 463);
            this.Controls.Add(this.themDocsTho);
            this.Controls.Add(this.openDocsWinExp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Documents";
            this.Text = "Documents";
            this.Load += new System.EventHandler(this.Documents_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openDocsWinExp;
        private System.Windows.Forms.FlowLayoutPanel themDocsTho;
        private System.Windows.Forms.Timer inTheaters;
    }
}