using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            txtContent.Clear();
            HttpClient client = new HttpClient();
            Dictionary<string, string> value = new Dictionary<string, string>()
            {
                { txtPara.Text, txtValue.Text },
                //{ "param2_name","param2_value"}
            };
            FormUrlEncodedContent content = new FormUrlEncodedContent(value);
            HttpResponseMessage response = await client.PostAsync(txtURL.Text, content);

            string body = await response.Content.ReadAsStringAsync();

            txtContent.AppendText(body);

        }
    }
}
