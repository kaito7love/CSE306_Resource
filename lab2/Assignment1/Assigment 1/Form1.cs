using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "file txt{.txt}|*.txt| all file{*.*}|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtTextContent.Text = openFileDialog1.FileName;
            }
        }



        private void btnRead_click(object sender, EventArgs e)
        {
            String content;
            UTF8Encoding temp = new UTF8Encoding(true);
            byte[] byteData = File.ReadAllBytes(txtTextContent.Text);
            content = temp.GetString(byteData);
            textBoxContent.Text = content ;

        }

        private void btnSave_click(object sender, EventArgs e)
        {
            UTF8Encoding temp = new UTF8Encoding(true);
            String content = textBoxContent.Text;

            byte[] buffer = temp.GetBytes(content);
            File.WriteAllBytes(txtTextContent.Text, buffer);

        }

    }
}
