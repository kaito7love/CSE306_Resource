using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDownload_click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtURL.Text))
            {
                MessageBox.Show("Please enter a valid URL.");
                return;
            }
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {

                using (var client = new WebClient())
                {
                    client.DownloadFile(txtURL.Text, folderBrowserDialog1.SelectedPath + "\\test.jpg");
                }
                MessageBox.Show("File downloaded successfully.");
            }
            

           
        }
    }
}
