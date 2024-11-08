﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnGet_Click_ClickAsync(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();

            //lay data kieu GET
            HttpResponseMessage response = await client.GetAsync(txtURL.Text);
            response.EnsureSuccessStatusCode();

            string body = await response.Content.ReadAsStringAsync();

            txtContent.AppendText(body);

        }
    }
}
