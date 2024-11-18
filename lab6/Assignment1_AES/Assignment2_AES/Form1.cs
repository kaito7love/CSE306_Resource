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
using System.IO;


namespace Assignment2_AES
{
    public partial class Form1 : Form
    {
        public byte[] key { get; set; }
        public byte[] iv { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            byte[] encrypted;
            using (AesCryptoServiceProvider aes = new AesCryptoServiceProvider())
            {
                // Create an AesCryptoServiceProvider object
                // with the specified key and IV.
                key = aes.Key;
                iv = aes.IV;
                // Create an encryptor to perform the stream transform.
                using (ICryptoTransform encryptor = aes.CreateEncryptor(key, iv))
                using (MemoryStream ms = new MemoryStream())
                using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                {
                    byte[] toEncrypt = Encoding.Unicode.GetBytes(txtPlainText.Text);
                    cs.Write(toEncrypt, 0, toEncrypt.Length);
                    cs.FlushFinalBlock();
                    encrypted = ms.ToArray();
                }
            }
            txtEncrypt.Text = Encoding.Unicode.GetString(encrypted);
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Padding = PaddingMode.PKCS7;
                // Create a decryptor to perform the stream transform.
                using (ICryptoTransform decryptor = aes.CreateDecryptor(key, iv))
                using (MemoryStream ms = new MemoryStream(Encoding.Unicode.GetBytes(txtEncrypt.Text)))
                using (CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                using (StreamReader sr = new StreamReader(cs, Encoding.Unicode))
                {
                    txtDecrypt.Text = sr.ReadToEnd();
                }
            }
        }
    }
}
