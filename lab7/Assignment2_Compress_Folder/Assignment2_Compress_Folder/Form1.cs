using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2_Compress_Folder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnZip_Click(object sender, EventArgs e)
        {
            try
            {
                string startPath = txtPathCom.Text;
                string path = Path.GetDirectoryName(startPath);
                string fileName = Path.GetFileName(startPath);
                string zipPath = Path.Combine(path, fileName + ".zip");

                // Create a zip file from the specified directory
                ZipFile.CreateFromDirectory(startPath, zipPath);
                MessageBox.Show("Directory zipped successfully.");

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void btnSelectFolderCom_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtPathCom.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnExtract_Click(object sender, EventArgs e)
        {
            try
            {
                string startPath = txtPathExtract.Text;

                string path = Path.GetDirectoryName(startPath);
                string fileName = Path.GetFileNameWithoutExtension(startPath);  // Gets "demo" from "demo.zip"

                // Create the full path for the zip file and the extraction folder
                string zipPath = Path.Combine(path, fileName + ".zip");
                string extractPath = Path.Combine(path, fileName + ".extract");

                MessageBox.Show(extractPath);
                // Extract the contents of the zip file
                ZipFile.ExtractToDirectory(zipPath, extractPath);
                MessageBox.Show("Zip file extracted successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }



        }

        private void btnSelectFolderExtract_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtPathExtract.Text = openFileDialog1.FileName;
            }
        }
    }
}
