using System;
using System.Net.WebSockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;

namespace Assignment1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        WebSocket socket;
        private async void btnListen_Server_Click(object sender, EventArgs e)
        {
            HttpListener listener = new HttpListener();
            listener.Prefixes.Add($"http://{txtServerIP.Text}:{txtPort.Text}/");
            listener.Start();

            txtContent.AppendText("Server started. Waiting for connections..." + "\r\n");

            while (true)
            {
                HttpListenerContext context = await listener.GetContextAsync();
                if (context.Request.IsWebSocketRequest)
                {
                    HttpListenerWebSocketContext webSocketContext = await context.AcceptWebSocketAsync(null);
                    socket = webSocketContext.WebSocket;

                    // Handle incoming messages
                    byte[] buffer = new byte[1024];
                    while (socket.State == WebSocketState.Open)
                    {
                        WebSocketReceiveResult result = await socket.ReceiveAsync(new ArraySegment<byte>(buffer), CancellationToken.None);
                        if (result.MessageType == WebSocketMessageType.Text)
                        {
                            string receivedMessage = System.Text.Encoding.UTF8.GetString(buffer, 0, result.Count);
                            txtContent.AppendText($"Received message: {receivedMessage}" + "\r\n");

                            //// Echo back the received message
                            //byte[] data = Encoding.UTF8.GetBytes("Im server");
                            //await socket.SendAsync(new ArraySegment<byte>(data, 0, data.Length), WebSocketMessageType.Text, true, CancellationToken.None);
                        }
                        else if (result.MessageType == WebSocketMessageType.Close)
                        {
                            await socket.CloseAsync(WebSocketCloseStatus.NormalClosure, "", CancellationToken.None);
                        }
                    }
                }
                else
                {
                    context.Response.StatusCode = 400;
                    context.Response.Close();
                }
            }
            Console.ReadKey();
        }

        private async void btnSend_Server_Click(object sender, EventArgs e)
        {
            string sendMessage = txtMessage.Text;
            txtContent.AppendText($"Send message: {sendMessage}" + "\r\n");

            // Echo back the received message
            byte[] data = Encoding.UTF8.GetBytes(sendMessage);
            await socket.SendAsync(new ArraySegment<byte>(data, 0, data.Length), WebSocketMessageType.Text, true, CancellationToken.None);
        }
    }
}
