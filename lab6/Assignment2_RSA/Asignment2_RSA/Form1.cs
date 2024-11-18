using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asignment2_RSA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private RSAParameters rsaParam;
        public byte[] encryptedData;
        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            UnicodeEncoding ByteConverter = new UnicodeEncoding();

            byte[] dataToEncrypt = ByteConverter.GetBytes(txtPlainText.Text);

            using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
            {

                rsaParam=RSA.ExportParameters(true);

                encryptedData = RSA.Encrypt(dataToEncrypt, false);
                txtEncrypt.AppendText(ByteConverter.GetString(encryptedData));
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            UnicodeEncoding ByteConverter = new UnicodeEncoding();


            byte[] decryptedData;
            //Create a new instance of RSACryptoServiceProvider.
            using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
            {
                RSA.ImportParameters(rsaParam);

                decryptedData = RSA.Decrypt(encryptedData, false);
                txtDecrypt.AppendText(ByteConverter.GetString(decryptedData));
            }

        }
    }
}
