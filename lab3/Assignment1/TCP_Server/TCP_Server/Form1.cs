using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCP_Server
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            TcpListener tcpListener = new TcpListener(IPAddress.Parse("127.0.0.1"), 30000);
            //txtContent.AppendText("Waiting");
            tcpListener.Start();
            Thread fileThread = new Thread(ListenFile);
            fileThread.Start(tcpListener);
           
        }

        private void ListenFile(object _server)
        {
            TcpListener server = (TcpListener)_server;
            //Byte[] bytes = new Byte[1024];
            while (true)
            {
                TcpClient client = server.AcceptTcpClient();
                NetworkStream ns = client.GetStream();
                string fileName = @".\" + DateTime.Now.ToString("yyyddMM-HHmmss");
                Stream fileStream = File.OpenWrite(fileName);
                byte[] dataByte = new byte[1024];
                //int blockSize = 1024;
                int thisRead;
                while ((thisRead = ns.Read(dataByte, 0, dataByte.Length)) != 0)
                {
                    fileStream.Write(dataByte, 0, dataByte.Length);
                }
                fileStream.Close();
                txtContent.Invoke(new Action(() =>
                {
                    txtContent.AppendText("\r\nReceived an image: " + DateTime.Now.ToString("yyyddMM-HHmmss"));
                }));
                //client.Close();
            }
        }



    }
}
