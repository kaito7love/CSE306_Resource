using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4_Compare_SHA_MD5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Dic files (*.dic)|*.dic|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = openFileDialog1.FileName;

                UTF8Encoding temp = new UTF8Encoding(true);
                byte[] byteData = File.ReadAllBytes(txtFilePath.Text);

                byte[] hashData;
                using (HashAlgorithm algorithm = SHA1.Create())
                {
                    hashData = algorithm.ComputeHash(byteData);
                }
                StringBuilder sbSha1 = new StringBuilder();
                foreach (byte b in hashData)
                    sbSha1.Append(b.ToString("X2"));
                txtSHA1.Text = sbSha1.ToString();
                StringBuilder sbMd5 = new StringBuilder();
                using (MD5 md5 = MD5.Create())
                {

                    byte[] hashBytes = md5.ComputeHash(byteData);

                    
                    for (int i = 0; i < hashBytes.Length; i++)
                    {
                        sbMd5.Append(hashBytes[i].ToString("X2"));
                    }

                }
                txtMD5.Text = sbMd5.ToString();
            }
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            
            if (txtCompare.Text == txtMD5.Text || txtCompare.Text==txtSHA1.Text)
            {
                MessageBox.Show("Hash Match!", "Hash Checkh", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Wrong Hash!", "Hash Check", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
