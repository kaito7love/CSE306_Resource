using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbIP.Items.Clear();
            IPAddress[] ipAddress =Dns.GetHostAddresses(txtDomanName.Text);
            foreach (var item in ipAddress)
            {
                lbIP.Items.Add(item);
            }

        }
    }
}
