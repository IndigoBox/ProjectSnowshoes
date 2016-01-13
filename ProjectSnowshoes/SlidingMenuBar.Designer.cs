namespace ProjectSnowshoes
{
    partial class SlidingMenuBar
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
            this.turnOffLabel = new System.Windows.Forms.Label();
            this.turnOffPanel = new System.Windows.Forms.Panel();
            this.turnOffImage = new System.Windows.Forms.PictureBox();
            this.notifPanel = new System.Windows.Forms.Panel();
            this.thatBridgeTho = new System.Windows.Forms.PictureBox();
            this.notifSubtitle = new System.Windows.Forms.Label();
            this.notifTitle = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Label();
            this.pictures = new System.Windows.Forms.Label();
            this.documents = new System.Windows.Forms.Label();
            this.apps = new System.Windows.Forms.Label();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.userEmail = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.Label();
            this.turnOffPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.turnOffImage)).BeginInit();
            this.notifPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thatBridgeTho)).BeginInit();
            this.infoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // turnOffLabel
            // 
            this.turnOffLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.turnOffLabel.BackColor = System.Drawing.Color.Transparent;
            this.turnOffLabel.Font = new System.Drawing.Font("Roboto Light", 7.875F);
            this.turnOffLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.turnOffLabel.Location = new System.Drawing.Point(135, 0);
            this.turnOffLabel.Name = "turnOffLabel";
            this.turnOffLabel.Size = new System.Drawing.Size(107, 50);
            this.turnOffLabel.TabIndex = 4;
            this.turnOffLabel.Text = "Turn Off";
            this.turnOffLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.turnOffLabel.Click += new System.EventHandler(this.turnOffLabel_Click);
            this.turnOffLabel.MouseLeave += new System.EventHandler(this.turnOffElement_MouseLeave);
            this.turnOffLabel.MouseHover += new System.EventHandler(this.turnOffElement_Hover);
            // 
            // turnOffPanel
            // 
            this.turnOffPanel.Controls.Add(this.turnOffLabel);
            this.turnOffPanel.Controls.Add(this.turnOffImage);
            this.turnOffPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.turnOffPanel.Location = new System.Drawing.Point(0, 0);
            this.turnOffPanel.Name = "turnOffPanel";
            this.turnOffPanel.Size = new System.Drawing.Size(300, 54);
            this.turnOffPanel.TabIndex = 6;
            this.turnOffPanel.Click += new System.EventHandler(this.turnOffLabel_Click);
            this.turnOffPanel.MouseLeave += new System.EventHandler(this.turnOffElement_MouseLeave);
            this.turnOffPanel.MouseHover += new System.EventHandler(this.turnOffElement_Hover);
            // 
            // turnOffImage
            // 
            this.turnOffImage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.turnOffImage.Location = new System.Drawing.Point(59, 0);
            this.turnOffImage.Name = "turnOffImage";
            this.turnOffImage.Size = new System.Drawing.Size(70, 50);
            this.turnOffImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.turnOffImage.TabIndex = 5;
            this.turnOffImage.TabStop = false;
            this.turnOffImage.Click += new System.EventHandler(this.turnOffImage_Click);
            this.turnOffImage.MouseLeave += new System.EventHandler(this.turnOffElement_MouseLeave);
            this.turnOffImage.MouseHover += new System.EventHandler(this.turnOffElement_Hover);
            // 
            // notifPanel
            // 
            this.notifPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.notifPanel.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.notifPanel.BackgroundImage = global::ProjectSnowshoes.Properties.Resources.thatBridgeIsReallyBlurryWow1;
            this.notifPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.notifPanel.Controls.Add(this.thatBridgeTho);
            this.notifPanel.Controls.Add(this.notifSubtitle);
            this.notifPanel.Controls.Add(this.notifTitle);
            this.notifPanel.Location = new System.Drawing.Point(0, 54);
            this.notifPanel.Name = "notifPanel";
            this.notifPanel.Size = new System.Drawing.Size(300, 186);
            this.notifPanel.TabIndex = 2;
            // 
            // thatBridgeTho
            // 
            this.thatBridgeTho.BackColor = System.Drawing.Color.Transparent;
            this.thatBridgeTho.Image = global::ProjectSnowshoes.Properties.Resources.the_bridge_4e802407b8b80_1_;
            this.thatBridgeTho.Location = new System.Drawing.Point(0, 0);
            this.thatBridgeTho.Name = "thatBridgeTho";
            this.thatBridgeTho.Size = new System.Drawing.Size(90, 186);
            this.thatBridgeTho.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.thatBridgeTho.TabIndex = 3;
            this.thatBridgeTho.TabStop = false;
            // 
            // notifSubtitle
            // 
            this.notifSubtitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.notifSubtitle.BackColor = System.Drawing.Color.Transparent;
            this.notifSubtitle.Font = new System.Drawing.Font("Roboto Light", 6.875F);
            this.notifSubtitle.ForeColor = System.Drawing.Color.Silver;
            this.notifSubtitle.Location = new System.Drawing.Point(90, 95);
            this.notifSubtitle.Name = "notifSubtitle";
            this.notifSubtitle.Size = new System.Drawing.Size(210, 30);
            this.notifSubtitle.TabIndex = 2;
            this.notifSubtitle.Text = "The Bridge Build";
            // 
            // notifTitle
            // 
            this.notifTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.notifTitle.BackColor = System.Drawing.Color.Transparent;
            this.notifTitle.Font = new System.Drawing.Font("Roboto Light", 7.875F);
            this.notifTitle.ForeColor = System.Drawing.Color.White;
            this.notifTitle.Location = new System.Drawing.Point(90, 49);
            this.notifTitle.Name = "notifTitle";
            this.notifTitle.Size = new System.Drawing.Size(210, 46);
            this.notifTitle.TabIndex = 1;
            this.notifTitle.Text = "Project Snowshoes";
            // 
            // search
            // 
            this.search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.search.Font = new System.Drawing.Font("Pacifico", 12.875F);
            this.search.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.search.Image = global::ProjectSnowshoes.Properties.Resources.AppsIco;
            this.search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.search.Location = new System.Drawing.Point(0, 243);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(300, 95);
            this.search.TabIndex = 4;
            this.search.Text = "          Search";
            this.search.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.search.Click += new System.EventHandler(this.search_Click);
            this.search.MouseLeave += new System.EventHandler(this.barItem_MouseLeave);
            this.search.MouseHover += new System.EventHandler(this.barItem_Hover);
            // 
            // pictures
            // 
            this.pictures.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictures.Font = new System.Drawing.Font("Pacifico", 12.875F);
            this.pictures.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.pictures.Image = global::ProjectSnowshoes.Properties.Resources.AppsIco;
            this.pictures.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pictures.Location = new System.Drawing.Point(0, 338);
            this.pictures.Name = "pictures";
            this.pictures.Size = new System.Drawing.Size(300, 95);
            this.pictures.TabIndex = 3;
            this.pictures.Text = "          Pictures";
            this.pictures.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pictures.MouseLeave += new System.EventHandler(this.barItem_MouseLeave);
            this.pictures.MouseHover += new System.EventHandler(this.barItem_Hover);
            // 
            // documents
            // 
            this.documents.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.documents.Font = new System.Drawing.Font("Pacifico", 12.875F);
            this.documents.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.documents.Image = global::ProjectSnowshoes.Properties.Resources.AppsIco;
            this.documents.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.documents.Location = new System.Drawing.Point(0, 433);
            this.documents.Name = "documents";
            this.documents.Size = new System.Drawing.Size(300, 95);
            this.documents.TabIndex = 2;
            this.documents.Text = "          Documents";
            this.documents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.documents.MouseLeave += new System.EventHandler(this.barItem_MouseLeave);
            this.documents.MouseHover += new System.EventHandler(this.barItem_Hover);
            // 
            // apps
            // 
            this.apps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.apps.Font = new System.Drawing.Font("Pacifico", 12.875F);
            this.apps.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.apps.Image = global::ProjectSnowshoes.Properties.Resources.AppsIco;
            this.apps.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.apps.Location = new System.Drawing.Point(0, 528);
            this.apps.Name = "apps";
            this.apps.Size = new System.Drawing.Size(300, 95);
            this.apps.TabIndex = 1;
            this.apps.Text = "          Apps";
            this.apps.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.apps.Click += new System.EventHandler(this.label3_Click);
            this.apps.MouseLeave += new System.EventHandler(this.barItem_MouseLeave);
            this.apps.MouseHover += new System.EventHandler(this.barItem_Hover);
            // 
            // infoPanel
            // 
            this.infoPanel.BackgroundImage = global::ProjectSnowshoes.Properties.Resources.img102;
            this.infoPanel.Controls.Add(this.userEmail);
            this.infoPanel.Controls.Add(this.userName);
            this.infoPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.infoPanel.Location = new System.Drawing.Point(0, 624);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(300, 144);
            this.infoPanel.TabIndex = 0;
            // 
            // userEmail
            // 
            this.userEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userEmail.BackColor = System.Drawing.Color.Transparent;
            this.userEmail.Font = new System.Drawing.Font("Roboto Light", 7.875F);
            this.userEmail.ForeColor = System.Drawing.Color.White;
            this.userEmail.Location = new System.Drawing.Point(0, 91);
            this.userEmail.Name = "userEmail";
            this.userEmail.Size = new System.Drawing.Size(300, 50);
            this.userEmail.TabIndex = 1;
            this.userEmail.Text = "rjaltman04@gmail.com";
            this.userEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.userEmail.Click += new System.EventHandler(this.label2_Click);
            // 
            // userName
            // 
            this.userName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userName.BackColor = System.Drawing.Color.Transparent;
            this.userName.Font = new System.Drawing.Font("Pacifico", 18F);
            this.userName.ForeColor = System.Drawing.Color.White;
            this.userName.Location = new System.Drawing.Point(0, 3);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(300, 106);
            this.userName.TabIndex = 0;
            this.userName.Text = "Doge";
            this.userName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SlidingMenuBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(300, 768);
            this.Controls.Add(this.turnOffPanel);
            this.Controls.Add(this.notifPanel);
            this.Controls.Add(this.search);
            this.Controls.Add(this.pictures);
            this.Controls.Add(this.documents);
            this.Controls.Add(this.apps);
            this.Controls.Add(this.infoPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SlidingMenuBar";
            this.Text = "SlidingMenuBar";
            this.Deactivate += new System.EventHandler(this.SlidingMenuBar_Deactivate);
            this.Load += new System.EventHandler(this.SlidingMenuBar_Load);
            this.turnOffPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.turnOffImage)).EndInit();
            this.notifPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.thatBridgeTho)).EndInit();
            this.infoPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Label userEmail;
        private System.Windows.Forms.Label apps;
        private System.Windows.Forms.Label documents;
        private System.Windows.Forms.Label pictures;
        private System.Windows.Forms.Label search;
        private System.Windows.Forms.Panel notifPanel;
        private System.Windows.Forms.PictureBox thatBridgeTho;
        private System.Windows.Forms.Label notifSubtitle;
        private System.Windows.Forms.Label notifTitle;
        private System.Windows.Forms.PictureBox turnOffImage;
        private System.Windows.Forms.Label turnOffLabel;
        private System.Windows.Forms.Panel turnOffPanel;
    }
}