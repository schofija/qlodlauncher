using System;
using System.Windows.Forms;
using Microsoft.Win32;

namespace qlodlauncher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool IsUserAdministrator()
        {
            return (new System.Security.Principal.WindowsPrincipal(System.Security.Principal.WindowsIdentity.GetCurrent()))
                   .IsInRole(System.Security.Principal.WindowsBuiltInRole.Administrator);
        }

        private string? FindUMDKey()
        {
            string videoKeyPath = @"SYSTEM\CurrentControlSet\Control\Video";

            using (RegistryKey videoKey = Registry.LocalMachine.OpenSubKey(videoKeyPath))
            {
                if (videoKey != null)
                {
                    string[] subKeyNames = videoKey.GetSubKeyNames();

                    foreach (string subKeyName in subKeyNames)
                    {
                        string graphicsCardPath = $@"{videoKeyPath}\{subKeyName}\0000";

                        using (RegistryKey graphicsCardSubKey = Registry.LocalMachine.OpenSubKey(graphicsCardPath))
                        {
                            if (graphicsCardSubKey != null && graphicsCardSubKey.GetSubKeyNames().Contains("UMD"))
                            {
                                return $@"{graphicsCardPath}\UMD";
                            }
                        }
                    }
                }
            }

            return null; // UMD key not found
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (!IsUserAdministrator())
            {
                MessageBox.Show("Please relaunch the application as an administrator.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string? UMDPath = FindUMDKey();

            if (!string.IsNullOrEmpty(UMDPath))
            {
                using (RegistryKey key = Registry.LocalMachine.OpenSubKey(UMDPath, true))
                {
                    if (key != null)
                    {
                        DateTime currentTime = DateTime.Now; // or DateTime.UtcNow if you prefer UTC time
                        string timestamp = currentTime.ToString("yyyy-MM-dd HH:mm:ss");
                        key.SetValue("LodAdj", "15", RegistryValueKind.String);

                        // Display a success message with the patched registry path
                        // Display a success message
                        MessageBox.Show("LOD bias enabled. Restart your game to apply the changes.", "Patch Successful!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBoxDebugOutput.AppendText($"[{timestamp}] LodAdj value set to 15 in registry path:\n\n{UMDPath}\r\n");
                    }
                    else
                    {
                        MessageBox.Show("Registry key not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("UMD key not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!IsUserAdministrator())
            {
                MessageBox.Show("Please relaunch the application as an administrator.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string? UMDPath = FindUMDKey();

            if (!string.IsNullOrEmpty(UMDPath))
            {
                using (RegistryKey key = Registry.LocalMachine.OpenSubKey(UMDPath, true))
                {
                    if (key != null)
                    {
                        DateTime currentTime = DateTime.Now; // or DateTime.UtcNow if you prefer UTC time
                        string timestamp = currentTime.ToString("yyyy-MM-dd HH:mm:ss");
                        key.DeleteValue("LodAdj", false); // The second argument 'false' means not to throw an exception if the value doesn't exist
                        MessageBox.Show("LOD bias disabled. Restart your game to apply the changes.", "Patch Successful!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBoxDebugOutput.AppendText($"[{timestamp}] LodAdj value DELETED in registry path:\n\n{UMDPath}\r\n");
                    }
                    else
                    {
                        MessageBox.Show("Registry key not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("UMD key not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void amdlodtweaker_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}