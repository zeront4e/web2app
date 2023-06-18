
namespace Web2App
{
    partial class FrmWeb2App
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmWeb2App));
            this.lblWebsiteUrl = new System.Windows.Forms.Label();
            this.txtWebsiteUrl = new System.Windows.Forms.TextBox();
            this.lblIcon = new System.Windows.Forms.Label();
            this.btnSelectIconFromFile = new System.Windows.Forms.Button();
            this.txtDirectoryPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelectDirectory = new System.Windows.Forms.Button();
            this.btnCreateApp = new System.Windows.Forms.Button();
            this.txtAppTitle = new System.Windows.Forms.TextBox();
            this.lblAppTitle = new System.Windows.Forms.Label();
            this.cbStartMenuEntry = new System.Windows.Forms.CheckBox();
            this.cbDesktopEntry = new System.Windows.Forms.CheckBox();
            this.lblOptions = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblStatusText = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtChromiumBrowserPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRemoveWebapp = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbIcon = new System.Windows.Forms.PictureBox();
            this.btnDownloadFavicon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWebsiteUrl
            // 
            this.lblWebsiteUrl.AutoSize = true;
            this.lblWebsiteUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWebsiteUrl.ForeColor = System.Drawing.Color.White;
            this.lblWebsiteUrl.Location = new System.Drawing.Point(12, 177);
            this.lblWebsiteUrl.Name = "lblWebsiteUrl";
            this.lblWebsiteUrl.Size = new System.Drawing.Size(86, 13);
            this.lblWebsiteUrl.TabIndex = 0;
            this.lblWebsiteUrl.Text = "Website URL:";
            this.lblWebsiteUrl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtWebsiteUrl
            // 
            this.txtWebsiteUrl.Location = new System.Drawing.Point(15, 193);
            this.txtWebsiteUrl.Name = "txtWebsiteUrl";
            this.txtWebsiteUrl.Size = new System.Drawing.Size(514, 20);
            this.txtWebsiteUrl.TabIndex = 2;
            this.txtWebsiteUrl.TextChanged += new System.EventHandler(this.txtWebsiteUrl_TextChanged);
            // 
            // lblIcon
            // 
            this.lblIcon.AutoSize = true;
            this.lblIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIcon.ForeColor = System.Drawing.Color.White;
            this.lblIcon.Location = new System.Drawing.Point(12, 222);
            this.lblIcon.Name = "lblIcon";
            this.lblIcon.Size = new System.Drawing.Size(36, 13);
            this.lblIcon.TabIndex = 3;
            this.lblIcon.Text = "Icon:";
            this.lblIcon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSelectIconFromFile
            // 
            this.btnSelectIconFromFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelectIconFromFile.Location = new System.Drawing.Point(112, 238);
            this.btnSelectIconFromFile.Name = "btnSelectIconFromFile";
            this.btnSelectIconFromFile.Size = new System.Drawing.Size(131, 23);
            this.btnSelectIconFromFile.TabIndex = 3;
            this.btnSelectIconFromFile.Text = "Select from file";
            this.btnSelectIconFromFile.UseVisualStyleBackColor = true;
            this.btnSelectIconFromFile.Click += new System.EventHandler(this.btnSelectIconFromFile_Click);
            // 
            // txtDirectoryPath
            // 
            this.txtDirectoryPath.Location = new System.Drawing.Point(15, 402);
            this.txtDirectoryPath.Name = "txtDirectoryPath";
            this.txtDirectoryPath.ReadOnly = true;
            this.txtDirectoryPath.Size = new System.Drawing.Size(514, 20);
            this.txtDirectoryPath.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 386);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Profile directory (target location):";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSelectDirectory
            // 
            this.btnSelectDirectory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelectDirectory.Location = new System.Drawing.Point(15, 428);
            this.btnSelectDirectory.Name = "btnSelectDirectory";
            this.btnSelectDirectory.Size = new System.Drawing.Size(514, 23);
            this.btnSelectDirectory.TabIndex = 7;
            this.btnSelectDirectory.Text = "Select directory";
            this.btnSelectDirectory.UseVisualStyleBackColor = true;
            this.btnSelectDirectory.Click += new System.EventHandler(this.btnSelectDirectory_Click);
            // 
            // btnCreateApp
            // 
            this.btnCreateApp.BackColor = System.Drawing.Color.GreenYellow;
            this.btnCreateApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateApp.Location = new System.Drawing.Point(12, 573);
            this.btnCreateApp.Name = "btnCreateApp";
            this.btnCreateApp.Size = new System.Drawing.Size(517, 23);
            this.btnCreateApp.TabIndex = 10;
            this.btnCreateApp.Text = "Create new webapp";
            this.btnCreateApp.UseVisualStyleBackColor = false;
            this.btnCreateApp.Click += new System.EventHandler(this.btnCreateApp_Click);
            // 
            // txtAppTitle
            // 
            this.txtAppTitle.Location = new System.Drawing.Point(15, 150);
            this.txtAppTitle.Name = "txtAppTitle";
            this.txtAppTitle.Size = new System.Drawing.Size(514, 20);
            this.txtAppTitle.TabIndex = 1;
            this.txtAppTitle.TextChanged += new System.EventHandler(this.txtAppTitle_TextChanged);
            // 
            // lblAppTitle
            // 
            this.lblAppTitle.AutoSize = true;
            this.lblAppTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppTitle.ForeColor = System.Drawing.Color.White;
            this.lblAppTitle.Location = new System.Drawing.Point(12, 134);
            this.lblAppTitle.Name = "lblAppTitle";
            this.lblAppTitle.Size = new System.Drawing.Size(58, 13);
            this.lblAppTitle.TabIndex = 9;
            this.lblAppTitle.Text = "App title:";
            this.lblAppTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbStartMenuEntry
            // 
            this.cbStartMenuEntry.AutoSize = true;
            this.cbStartMenuEntry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbStartMenuEntry.ForeColor = System.Drawing.Color.White;
            this.cbStartMenuEntry.Location = new System.Drawing.Point(15, 479);
            this.cbStartMenuEntry.Name = "cbStartMenuEntry";
            this.cbStartMenuEntry.Size = new System.Drawing.Size(135, 17);
            this.cbStartMenuEntry.TabIndex = 8;
            this.cbStartMenuEntry.Text = "Create start menu entry";
            this.cbStartMenuEntry.UseVisualStyleBackColor = true;
            // 
            // cbDesktopEntry
            // 
            this.cbDesktopEntry.AutoSize = true;
            this.cbDesktopEntry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbDesktopEntry.ForeColor = System.Drawing.Color.White;
            this.cbDesktopEntry.Location = new System.Drawing.Point(15, 499);
            this.cbDesktopEntry.Name = "cbDesktopEntry";
            this.cbDesktopEntry.Size = new System.Drawing.Size(124, 17);
            this.cbDesktopEntry.TabIndex = 9;
            this.cbDesktopEntry.Text = "Create desktop entry";
            this.cbDesktopEntry.UseVisualStyleBackColor = true;
            // 
            // lblOptions
            // 
            this.lblOptions.AutoSize = true;
            this.lblOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOptions.ForeColor = System.Drawing.Color.White;
            this.lblOptions.Location = new System.Drawing.Point(12, 460);
            this.lblOptions.Name = "lblOptions";
            this.lblOptions.Size = new System.Drawing.Size(54, 13);
            this.lblOptions.TabIndex = 13;
            this.lblOptions.Text = "Options:";
            this.lblOptions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(24, 549);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 15;
            // 
            // lblStatusText
            // 
            this.lblStatusText.AutoSize = true;
            this.lblStatusText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusText.ForeColor = System.Drawing.Color.White;
            this.lblStatusText.Location = new System.Drawing.Point(12, 530);
            this.lblStatusText.Name = "lblStatusText";
            this.lblStatusText.Size = new System.Drawing.Size(188, 13);
            this.lblStatusText.TabIndex = 16;
            this.lblStatusText.Text = "Status to create a new webapp:";
            this.lblStatusText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(128, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "Turn any website into an app";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtChromiumBrowserPath
            // 
            this.txtChromiumBrowserPath.Location = new System.Drawing.Point(15, 353);
            this.txtChromiumBrowserPath.Name = "txtChromiumBrowserPath";
            this.txtChromiumBrowserPath.Size = new System.Drawing.Size(514, 20);
            this.txtChromiumBrowserPath.TabIndex = 5;
            this.txtChromiumBrowserPath.Text = "C:\\Program Files (x86)\\Microsoft\\Edge\\Application\\msedge.exe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Chromium browser path:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 599);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(517, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "_________________________________________________________________________________" +
    "____";
            // 
            // btnRemoveWebapp
            // 
            this.btnRemoveWebapp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.btnRemoveWebapp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveWebapp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveWebapp.Location = new System.Drawing.Point(12, 625);
            this.btnRemoveWebapp.Name = "btnRemoveWebapp";
            this.btnRemoveWebapp.Size = new System.Drawing.Size(517, 23);
            this.btnRemoveWebapp.TabIndex = 11;
            this.btnRemoveWebapp.Text = "Remove existing webapp";
            this.btnRemoveWebapp.UseVisualStyleBackColor = false;
            this.btnRemoveWebapp.Click += new System.EventHandler(this.btnRemoveWebapp_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Web2App.Properties.Resources.logo;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(130, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(276, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // pbIcon
            // 
            this.pbIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbIcon.Location = new System.Drawing.Point(15, 238);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.Size = new System.Drawing.Size(90, 90);
            this.pbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbIcon.TabIndex = 2;
            this.pbIcon.TabStop = false;
            // 
            // btnDownloadFavicon
            // 
            this.btnDownloadFavicon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDownloadFavicon.Location = new System.Drawing.Point(112, 267);
            this.btnDownloadFavicon.Name = "btnDownloadFavicon";
            this.btnDownloadFavicon.Size = new System.Drawing.Size(131, 23);
            this.btnDownloadFavicon.TabIndex = 4;
            this.btnDownloadFavicon.Text = "Download favicon";
            this.btnDownloadFavicon.UseVisualStyleBackColor = true;
            this.btnDownloadFavicon.Click += new System.EventHandler(this.btnDownloadFavicon_Click);
            // 
            // FrmWeb2App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(541, 661);
            this.Controls.Add(this.btnDownloadFavicon);
            this.Controls.Add(this.btnRemoveWebapp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtChromiumBrowserPath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblStatusText);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblOptions);
            this.Controls.Add(this.cbDesktopEntry);
            this.Controls.Add(this.cbStartMenuEntry);
            this.Controls.Add(this.txtAppTitle);
            this.Controls.Add(this.lblAppTitle);
            this.Controls.Add(this.btnCreateApp);
            this.Controls.Add(this.btnSelectDirectory);
            this.Controls.Add(this.txtDirectoryPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelectIconFromFile);
            this.Controls.Add(this.lblIcon);
            this.Controls.Add(this.pbIcon);
            this.Controls.Add(this.txtWebsiteUrl);
            this.Controls.Add(this.lblWebsiteUrl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(557, 700);
            this.MinimumSize = new System.Drawing.Size(557, 700);
            this.Name = "FrmWeb2App";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Web2App";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWebsiteUrl;
        private System.Windows.Forms.TextBox txtWebsiteUrl;
        private System.Windows.Forms.PictureBox pbIcon;
        private System.Windows.Forms.Label lblIcon;
        private System.Windows.Forms.Button btnSelectIconFromFile;
        private System.Windows.Forms.TextBox txtDirectoryPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelectDirectory;
        private System.Windows.Forms.Button btnCreateApp;
        private System.Windows.Forms.TextBox txtAppTitle;
        private System.Windows.Forms.Label lblAppTitle;
        private System.Windows.Forms.CheckBox cbStartMenuEntry;
        private System.Windows.Forms.CheckBox cbDesktopEntry;
        private System.Windows.Forms.Label lblOptions;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblStatusText;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtChromiumBrowserPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRemoveWebapp;
        private System.Windows.Forms.Button btnDownloadFavicon;
    }
}

