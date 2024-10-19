using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asignment3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text {*.txt}|*.txt|All files {*.*}|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(openFileDialog1.FileName);
            }
        }

        private void btnSelectAvatar_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "JPG {*.png}|*.png|All files {*.*}|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBoxAvatar.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text {*.txt}|*.txt|All files {*.*}|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(openFileDialog1.FileName);
            }
        }
    }
}
