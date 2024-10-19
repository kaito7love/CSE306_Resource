using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asignment4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtDisplay.AppendText("0");
        }
        double value1 = 0;
        String logicOperation;

        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!txtDisplay.Text.Contains("."))
                    txtDisplay.Text += button.Text;
            }
            else
            {
                if (txtDisplay.Text.Contains("0") && txtDisplay.Text.Length == 1)
                {
                    txtDisplay.Clear();
                }
                txtDisplay.Text += button.Text;
            }
        }

        private void operation_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            
            switch (logicOperation)
            {
                case "+":
                    value1 = value1 + double.Parse(txtDisplay.Text);
                    logicOperation = button.Text;
                    break;
                case "-":
                    value1 = value1 - double.Parse(txtDisplay.Text);
                    logicOperation = button.Text;
                    break;
                case "X":
                    value1 = value1 * double.Parse(txtDisplay.Text);
                    logicOperation = button.Text;
                    break;
                case ":":
                    value1 = value1 / double.Parse(txtDisplay.Text);
                    logicOperation = button.Text;
                    break;
                default:
                    value1 += double.Parse(txtDisplay.Text);
                    logicOperation = button.Text;
                    break;
            }
            txtDisplay.Clear();
            txtDisplay.AppendText("0");
        }

        private void result_Click(object sender, EventArgs e)
        {
            switch (logicOperation)
            {
                case "+":
                    value1 = value1 + double.Parse(txtDisplay.Text);
                    txtDisplay.Text = value1.ToString();
                    value1 = 0;
                    logicOperation = "";
                    break;
                case "-":
                    value1 = value1 - double.Parse(txtDisplay.Text);
                    txtDisplay.Text = value1.ToString();
                    value1 = 0;
                    logicOperation = "";
                    break;
                case "X":
                    value1 = value1 * double.Parse(txtDisplay.Text);
                    txtDisplay.Text = value1.ToString();
                    value1 = 0;
                    logicOperation = "";
                    break;
                case ":":
                    value1 = value1 / double.Parse(txtDisplay.Text);
                    txtDisplay.Text = value1.ToString();
                    value1 = 0;
                    logicOperation = "";
                    break;
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
            txtDisplay.AppendText("0");
            value1 = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
            {
                // Xóa ký tự cuối cùng trong TextBox
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);
            }

            if (txtDisplay.Text == "")
            {
                txtDisplay.Text = "0";
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            value1 = -1 * double.Parse(txtDisplay.Text);
            txtDisplay.Text = value1.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            value1 = double.Parse(txtDisplay.Text) / (double)100;
            txtDisplay.Text = value1.ToString();
        }
    }
}
