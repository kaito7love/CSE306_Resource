using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Assignment2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            NetworkCredential myCredential = new NetworkCredential(txtUsername.Text, txtPassword.Text);

            SmtpClient client = new SmtpClient();

            client.Host = txtSmtpGmail.Text;
            client.Port = int.Parse(txtSmtpPort.Text);
            client.EnableSsl = true;
            client.UseDefaultCredentials = false;
            client.Credentials = myCredential;

            string[] emailAddresses = File.ReadAllLines(txtEmailTo.Text);

            foreach (var email in emailAddresses)
            {
                MailAddress from = new MailAddress(txtEmailFrom.Text, txtTittle.Text);

                MailAddress to = new MailAddress(email);
                MailMessage message = new MailMessage(from, to);
                if (txtFileAttached.Text!="")
                {
                    message.Attachments.Add(new Attachment(txtFileAttached.Text));
                }
                
                message.Subject = txtTittle.Text;
                message.Body = txtMessage.Text;

                client.Send(message);
                message.Dispose();
                Console.WriteLine("Done");
            }

        }

        private void btnChooseListEmail_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text Files (*.txt)|*.txt|CSV Files (*.csv)|*.csv|All Files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtEmailTo.Text = openFileDialog1.FileName;
                //string filePath = txtEmailTo.Text;

                ////Read byte[] from file
                //using (FileStream fs = File.OpenRead(filePath))
                //{
                //    UTF8Encoding temp = new UTF8Encoding(true);
                //    int length = 0;

                //    byte[] readData = new byte[1024];
                //    while ((length = fs.Read(readData, 0, readData.Length)) > 0)
                //    {
                //        Console.WriteLine(temp.GetString(readData));
                //    }
                //}
            }
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|All Files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFileAttached.Text = openFileDialog1.FileName;
            }
        }
    }
}
