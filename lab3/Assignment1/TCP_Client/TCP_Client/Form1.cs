using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCP_Client
{
    public partial class s : Form
    {
        public s()
        {
            InitializeComponent();
        }
        
        private void btnChooseAndSend_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files(*.png,*.jpg)|*.png;*.jpg|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                
                byte[] fileContent = File.ReadAllBytes(openFileDialog1.FileName);

                TcpClient tcpClient = new TcpClient("127.0.0.1",30000);

                NetworkStream ns = tcpClient.GetStream();
                ns.Write(fileContent, 0, fileContent.Length);
                ns.Close();
                //tcpClient.Close();



            }
        }
    }
}
