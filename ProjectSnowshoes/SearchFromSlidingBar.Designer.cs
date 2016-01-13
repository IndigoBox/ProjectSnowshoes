namespace ProjectSnowshoes
{
    partial class SearchFromSlidingBar
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
            this.query = new System.Windows.Forms.TextBox();
            this.searchBrowser = new System.Windows.Forms.WebBrowser();
            this.inTheaters = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // query
            // 
            this.query.BackColor = System.Drawing.Color.WhiteSmoke;
            this.query.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.query.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.query.Font = new System.Drawing.Font("Roboto Light", 14.875F);
            this.query.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.query.Location = new System.Drawing.Point(0, 744);
            this.query.Name = "query";
            this.query.Size = new System.Drawing.Size(1066, 24);
            this.query.TabIndex = 0;
            this.query.KeyDown += new System.Windows.Forms.KeyEventHandler(this.query_KeyDown);
            // 
            // searchBrowser
            // 
            this.searchBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchBrowser.Location = new System.Drawing.Point(0, 0);
            this.searchBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.searchBrowser.Name = "searchBrowser";
            this.searchBrowser.Size = new System.Drawing.Size(1066, 744);
            this.searchBrowser.TabIndex = 1;
            this.searchBrowser.Visible = false;
            // 
            // inTheaters
            // 
            this.inTheaters.Enabled = true;
            this.inTheaters.Interval = 1;
            this.inTheaters.Tick += new System.EventHandler(this.inTheaters_Tick);
            // 
            // SearchFromSlidingBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1066, 768);
            this.Controls.Add(this.searchBrowser);
            this.Controls.Add(this.query);
            this.Font = new System.Drawing.Font("Roboto Light", 7.875F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SearchFromSlidingBar";
            this.Opacity = 0.9D;
            this.Text = "SearchFromSlidingBar";
            this.Load += new System.EventHandler(this.SearchFromSlidingBar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox query;
        private System.Windows.Forms.WebBrowser searchBrowser;
        private System.Windows.Forms.Timer inTheaters;
    }
}