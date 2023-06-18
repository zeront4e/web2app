using System;
using System.IO;
using System.Windows.Forms;

namespace Web2App
{
    public partial class FrmRemoveWebapp : Form
    {
        private string webappsDirectoryPath;
        private string selectedItem = null;

        public FrmRemoveWebapp(string webappsDirectoryPath)
        {
            InitializeComponent();

            this.webappsDirectoryPath = webappsDirectoryPath;

            string[] webappDirectoryPaths = Directory.GetDirectories(webappsDirectoryPath);

            foreach(string tmpDirectoryPath in webappDirectoryPaths)
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(tmpDirectoryPath);
                cmbWebapps.Items.Add(directoryInfo.Name);
            }
        }

        private void btnRemoveWebapp_Click(object sender, EventArgs e)
        {
            DialogResult confirmDialogResult = MessageBox.Show("Do you really want to delete the webapp and all related data?", "Confirm to remove webapp",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);

            if(confirmDialogResult == DialogResult.Yes) {
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
                string desktopShortcutPath = Path.Combine(desktopPath, selectedItem + ".lnk");

                if (File.Exists(desktopShortcutPath))
                {
                    File.Delete(desktopShortcutPath);
                }

                string startMenuPath = Environment.GetFolderPath(Environment.SpecialFolder.StartMenu);
                string web2AppStartMenuPath = startMenuPath + "\\Web2App";
                string menuShortcutPath = Path.Combine(web2AppStartMenuPath, selectedItem + ".lnk");

                if (File.Exists(menuShortcutPath))
                {
                    File.Delete(menuShortcutPath);
                }

                Directory.Delete(webappsDirectoryPath + "\\" + selectedItem, true);

                MessageBox.Show("All webapp data was removed.");

                Close();
            }
        }

        private void cmbWebapps_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbWebapps.SelectedItem != null)
            {
                selectedItem = (string) cmbWebapps.SelectedItem;
                btnRemoveWebapp.Enabled = true;
            }
            else
            {
                btnRemoveWebapp.Enabled = false;
            }
        }
    }
}
