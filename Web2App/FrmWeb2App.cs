using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace Web2App
{
    public partial class FrmWeb2App : Form
    {
        private byte[] iconBytes = null;
        private string directoryPath = "";

        public FrmWeb2App()
        {
            InitializeComponent();

            //Set the default profiles path.
            directoryPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\.web2app";
            txtDirectoryPath.Text = directoryPath;

            //Set the initial status.
            UpdateStatus();
        }

        private void ResetVariables()
        {
            iconBytes = null;

            txtAppTitle.Text = "";
            txtWebsiteUrl.Text = "";

            pbIcon.Image = null;

            cbDesktopEntry.Checked = false;
            cbStartMenuEntry.Checked = false;
        }

        private void CreateWebapp()
        {
            string appTitle = txtAppTitle.Text;
            string websiteUrl = txtWebsiteUrl.Text;
            string chromiumBrowserPath = txtChromiumBrowserPath.Text;
            bool createDesktopShortcut = cbDesktopEntry.Checked;
            bool createStartMenuShortcut = cbStartMenuEntry.Checked;

            //Setup start menu directory path.
            string startMenuPath = Environment.GetFolderPath(Environment.SpecialFolder.StartMenu);

            string web2AppStartMenuPath = startMenuPath + "\\Web2App";

            //Setup base directory.
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            //Setup webapp directory.
            string appDirectoryPath = directoryPath + "\\" + appTitle;

            if (Directory.Exists(appDirectoryPath))
            {
                DialogResult dialogResult = MessageBox.Show("A webapp with the provided name does already exist. Do you want to overwrite the webapp?", 
                    "Webapp already exists.", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    Directory.Delete(appDirectoryPath, true);
                }
                else
                {
                    return;
                }
            }

            Directory.CreateDirectory(appDirectoryPath);

            //Setup icon.
            if(iconBytes == null)
            {
                //Try to download a fallback icon.
                try
                {
                    DownloadFavicon();
                }
                catch(Exception exception)
                {
                    MessageBox.Show("Unable to download icon. Cause: " + exception.Message);
                }
            }

            string iconPath = "";

            if (iconBytes != null)
            {
                iconPath = appDirectoryPath + "\\web2app-icon.ico";

                File.WriteAllBytes(iconPath, iconBytes);
            }

            //Create browser profile.
            string chromiumProfilePath = appDirectoryPath + "\\chromium-profile";

            Directory.CreateDirectory(chromiumProfilePath);

            //Setup arguments string.
            string arguments = "--user-data-dir=\"" + chromiumProfilePath + "\" --app=\"" + websiteUrl + "\"";

            //Create actual shortcut.
            string shortcutPath = ShortcutUtil.CreateShortcut(appTitle, appDirectoryPath, chromiumBrowserPath, iconPath, arguments);

            //Create optional shortcuts.
            if(createDesktopShortcut)
            {
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
                string targetShortcutPath = Path.Combine(desktopPath, appTitle + ".lnk");

                if(File.Exists(targetShortcutPath))
                {
                    File.Delete(targetShortcutPath);
                }

                File.Copy(shortcutPath, targetShortcutPath);
            }

            if(createStartMenuShortcut)
            {
                if(!Directory.Exists(web2AppStartMenuPath))
                {
                    Directory.CreateDirectory(web2AppStartMenuPath);
                }

                string targetShortcutPath = Path.Combine(web2AppStartMenuPath, appTitle + ".lnk");
                
                if(File.Exists(targetShortcutPath))
                {
                    File.Delete(targetShortcutPath);
                }

                File.Copy(shortcutPath, targetShortcutPath);
            }

            //Show success message.
            MessageBox.Show("The webapp was created!", "Webapp creation completed.");

            //Reset.
            ResetVariables();
        }

        private void DownloadFavicon()
        {
            if(!txtWebsiteUrl.Text.StartsWith("http://") && !txtWebsiteUrl.Text.StartsWith("https://"))
            {
                MessageBox.Show("Invalid website URL: Please insert a valid URL.");
                
                return;
            }

            string domainUrl = txtWebsiteUrl.Text.Replace("http://", "").Replace("https://", "");

            string tmpIconPath = Path.GetTempPath() + "\\web2app-tmp-icon.ico";
            
            WebClient client = new WebClient();
            client.DownloadFile(@"http://www.google.com/s2/favicons?domain=" + domainUrl + "&sz=256", tmpIconPath);

            Image iconImage = Image.FromFile(tmpIconPath);
            pbIcon.Image = iconImage;

            iconBytes = ImageToIconUtil.ConvertToIcon(iconImage, true);
        }

        private void txtAppTitle_TextChanged(object sender, EventArgs e)
        {
            UpdateStatus();
        }

        private void txtWebsiteUrl_TextChanged(object sender, EventArgs e)
        {
            UpdateStatus();
        }

        private void btnCreateApp_Click(object sender, EventArgs e)
        {
            CreateWebapp();
        }

        private void btnRemoveWebapp_Click(object sender, EventArgs e)
        {
            FrmRemoveWebapp removeWebapp = new FrmRemoveWebapp(directoryPath);
            removeWebapp.ShowDialog();
        }

        private void btnDownloadFavicon_Click(object sender, EventArgs e)
        {
            DownloadFavicon();
        }

        private void btnSelectIconFromFile_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();

            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            dialog.Title = "Please select an icon image file.";
            dialog.Filters.Add(new CommonFileDialogFilter("Image Files", "*.bmp,*.jpg,*.jpeg,*.gif,*.png"));
            dialog.IsFolderPicker = false;
            dialog.Multiselect = false;

            if(dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                string imageFilePath = dialog.FileName;

                Image iconImage = Image.FromFile(imageFilePath);
                pbIcon.Image = iconImage;

                iconBytes = ImageToIconUtil.ConvertToIcon(iconImage, true);
            }
        }

        private void btnSelectDirectory_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();

            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            dialog.Title = "Please select the target directory.";
            dialog.IsFolderPicker = true;
            dialog.Multiselect = false;
            dialog.RestoreDirectory = true;

            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                directoryPath = dialog.FileName;
                txtDirectoryPath.Text = dialog.FileName;
            }
        }

        private void UpdateStatus()
        {
            btnCreateApp.Enabled = false;

            if (String.IsNullOrWhiteSpace(txtAppTitle.Text))
            {
                lblStatus.Text = "Invalid app title: The entered title can't be empty!";
                
                return;
            }
            else if (String.IsNullOrWhiteSpace(txtWebsiteUrl.Text) || 
                !txtWebsiteUrl.Text.StartsWith("http://") && !txtWebsiteUrl.Text.StartsWith("https://"))
            {
                lblStatus.Text = "Invalid app URL: The entered URL is invalid!";

                return;
            }
            else
            {
                lblStatus.Text = "-";
                btnCreateApp.Enabled = true;
            }
        }
    }
}
