namespace ProjectSnowshoes
{
    partial class CustomSearchImplementationOne
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
            this.query = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // query
            // 
            this.query.BackColor = System.Drawing.Color.DimGray;
            this.query.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.query.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.query.Font = new System.Drawing.Font("Maven Pro", 14.875F);
            this.query.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.query.Location = new System.Drawing.Point(0, 721);
            this.query.Name = "query";
            this.query.Size = new System.Drawing.Size(1066, 47);
            this.query.TabIndex = 2;
            this.query.KeyDown += new System.Windows.Forms.KeyEventHandler(this.query_KeyDown);
            // 
            // CustomSearchImplementationOne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjectSnowshoes.Properties.Resources.blackBackSearch;
            this.ClientSize = new System.Drawing.Size(1066, 768);
            this.Controls.Add(this.query);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomSearchImplementationOne";
            this.Text = "CustomSearchImplementationOne";
            this.Deactivate += new System.EventHandler(this.CustomSearchImplementationOne_Deactivate);
            this.Load += new System.EventHandler(this.CustomSearchImplementationOne_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox query;
    }
}