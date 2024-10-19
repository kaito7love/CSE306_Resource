using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Asignment2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "file txt{.txt}|*.txt| all file{*.*}|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = openFileDialog1.FileName;
            }
        }

        private void btnReadFromFile(object sender, EventArgs e)
        {

            String content;
            using (FileStream fs = File.OpenRead(txtFilePath.Text))
            {
                int length = 0;
                if (rbtn_UTF8.Checked)
                {
                    UTF8Encoding temp = new UTF8Encoding(true);
                    byte[] readData = new byte[1024];
                    //fs.Read(readData, 0, readData.Length);
                    //txtContent.Text = temp.GetString(readData);
                    while ((length = fs.Read(readData, 0, readData.Length)) > 0)
                    {
                        txtContent.Text = temp.GetString(readData);
                    }
                }
                else
                {
                    UnicodeEncoding temp = new UnicodeEncoding();
                    byte[] readData = new byte[1024];
                    while ((length = fs.Read(readData, 0, readData.Length)) > 0)
                    {
                        txtContent.Text = temp.GetString(readData);
                    }
                }
            };
        }

        private void btnWriteToFile(object sender, EventArgs e)
        {
            String content = txtContent.Text;
            if (rbtn_UTF8.Checked)
            {
                UTF8Encoding temp = new UTF8Encoding(true);
                // Write and replace content
                using (FileStream fs = File.OpenWrite(txtFilePath.Text))
                {
                    byte[] buffer = temp.GetBytes(content);
                    fs.Write(buffer, 0, buffer.Length);
                };
                //write and append content
                //using (FileStream fs = new FileStream(txtFilePath.Text, FileMode.Append))
                //{
                //    byte[] buffer = temp.GetBytes(content);
                //    fs.Write(buffer, 0, buffer.Length);
                //};
            }
            else
            {
                UnicodeEncoding temp = new UnicodeEncoding();
                // Write and replace content
                using (FileStream fs = File.OpenWrite(txtFilePath.Text))
                {
                    byte[] buffer = temp.GetBytes(content);
                    fs.Write(buffer, 0, buffer.Length);
                };
                //write and append content
                //using (FileStream fs = new FileStream(txtFilePath.Text, FileMode.Append))
                //{
                //    byte[] buffer = temp.GetBytes(content);
                //    fs.Write(buffer, 0, buffer.Length);
                //};

            }
        }
    }
}
