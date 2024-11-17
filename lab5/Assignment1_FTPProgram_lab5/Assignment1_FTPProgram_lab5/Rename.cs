using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Assignment1_FTPProgram_lab5
{
    public partial class Rename : Form
    {
        public string ReturnValue { get; set; }
        public Rename(string name)
        {
            InitializeComponent();
            txtNew.Text = name;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            ReturnValue = txtNew.Text;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
