using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Text;
using System.Threading;
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
        TcpClient tcpClient;
        private void btnConnect_Client_Click(object sender, EventArgs e)
        {
            // Tcp - Send
            tcpClient = new TcpClient();
            tcpClient.Connect(IPAddress.Parse(txtServerIP.Text), int.Parse(txtPort.Text));
            //MessageBox.Show("Connected!");

            Thread t = new Thread(threadListen);
            t.Start();

        }

        private void btnSend_CLient_Click(object sender, EventArgs e)
        {

            NetworkStream stream = tcpClient.GetStream();

            // chuyen chuoi data thanh byte
            byte[] buffer = Encoding.UTF8.GetBytes(txtTextSend.Text);
            txtContent.AppendText("Client: " + txtTextSend.Text + "\r\n");
            stream.Write(buffer, 0, buffer.Length);
            txtTextSend.Clear();
            //stream.Close();
            //tcpClient.Close();
        }

        private void threadListen()
        {
            while (true)
            {
                //Console.WriteLine("Waiting for connection");

                //Client = tcpListener.AcceptTcpClient();
                //txtContent.Invoke(new Action(() =>
                //{
                //    txtContent.AppendText("Connected...\r\n");
                //}));

                NetworkStream ns = tcpClient.GetStream();

                byte[] buffer = new byte[1024];
                int byteRead = 0;
                while (true)
                {
                    byteRead = ns.Read(buffer, 0, buffer.Length);
                    if (byteRead == 0) break;

                    string receivedMessage = Encoding.UTF8.GetString(buffer, 0, byteRead) + "\r\n";

                    // Safely update the UI (txtContent) from the background thread

                    txtContent.Invoke(new Action(() =>
                    {
                        txtContent.AppendText("Server: " + receivedMessage);
                    }));

                }
                ns.Close();
                tcpClient.Close();

            }
        }
    }
}
