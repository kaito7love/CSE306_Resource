using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using static System.Net.Mime.MediaTypeNames;

namespace Assignment3_SHA256
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> hashlist = new List<string>();
        private void btnHash_Click(object sender, EventArgs e)
        {
            byte[] hashData;
            using (HashAlgorithm algorithm = SHA256.Create())
            {
                hashData = algorithm.ComputeHash(Encoding.UTF8.GetBytes(txtPassword.Text));
            }
            StringBuilder sb = new StringBuilder();
            foreach (byte b in hashData)
                sb.Append(b.ToString("X2"));

            sb.ToString();

            if (!hashlist.Contains(sb.ToString()))
            {
                string hashString = sb.ToString();
                hashlist.Add(hashString);
                lbHash.Items.Clear();
                foreach (string hash in hashlist)
                {
                    lbHash.Items.Add(hash);
                }
            }
            txtPassword.Clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            byte[] hashData;
            using (HashAlgorithm algorithm = SHA256.Create())
            {
                hashData = algorithm.ComputeHash(Encoding.UTF8.GetBytes(txtKeyword.Text));
            }
            StringBuilder sb = new StringBuilder();
            foreach (byte b in hashData)
                sb.Append(b.ToString("X2"));

            sb.ToString();

            if (hashlist.Contains(sb.ToString()))
            {
                lbHash.Items.Clear();
                lbHash.Items.Add(sb);
            }
            else
            {
                lbHash.Items.Clear();
                lbHash.Items.Add("Keyword not found");
            }
            txtKeyword.Clear();
        }
    }
}
