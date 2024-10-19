using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }
        Thread[] threadArray;
        int numberOfFile;
        int addition;
        String destinationDirectory = "./Images/";
        private void btnUpload_click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files(*.png)|*.png|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string[] filePath = openFileDialog1.FileNames;
                numberOfFile = filePath.Length;
                threadArray = new Thread[numberOfFile];
                for (int i = 0; i < numberOfFile; i++)
                {
                    txtPath.AppendText(filePath[i] + Environment.NewLine);
                    threadArray[i] = new Thread(UploadFile);
                    threadArray[i].Start(filePath[i]);
                }
                Thread t = new Thread(JoinAllThread);
                t.Start();
            }
        }
        void JoinAllThread()
        {
            for (int i = 0; i < numberOfFile; i++)
            {
                threadArray[i].Join();
            }

        }
        void UploadFile(object _filePath)
        {
            string filePath = (string)_filePath;
            string fileName = Path.GetFileName(filePath);

            // Cập nhật đang uploading
            Action _uploading = delegate
            {
                lbUploaded.Items.Add("Uploading " + fileName);
            };
            lbUploaded.Invoke( _uploading );
            
            // Cập nhật Đã uploaded xong
            Action _act = delegate
            {
                lbUploaded.Items.Add("Uploaded " + fileName);
            };
            lbUploaded.Invoke(_act);

        }
    }
}