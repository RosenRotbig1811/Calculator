using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();      
        }

        double first;
        double second;
        double otvet;
        string memory;
        string op;
        int iOp = 0;

        private void Ravno_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb.Text != "")
                {
                    result();
                }
                else
                {
                    tb.Text = "Enter some";
                }
            }
            catch (Exception )
            {
                tb.Text = "Error!";
            }
        }

        public void result()
        {
            if (tb.Text.Contains("+"))
            {
                iOp = tb.Text.IndexOf("+");
            }
            else if (tb.Text.Contains("-"))
            {
                iOp = tb.Text.IndexOf("-");
            }
            else if (tb.Text.Contains("*"))
            {
                iOp = tb.Text.IndexOf("*");
            }
            else if (tb.Text.Contains("/"))
            {
                iOp = tb.Text.IndexOf("/");
            }

            op = tb.Text.Substring(iOp, 1);
            first = Convert.ToDouble(tb.Text.Substring(0, iOp));
            second = Convert.ToDouble(tb.Text.Substring(iOp + 1, tb.Text.Length - iOp - 1));

            string memory = tb.Text;

            if (op == "+")
            {
                otvet = first + second;
                tb.Text = otvet.ToString();
            }
            else if (op == "-")
            {
                otvet = first - second;
                tb.Text = otvet.ToString();
            }
            else if (op == "*")
            {
                otvet = first * second;
                tb.Text = otvet.ToString();
            }
            else if (op == "/")
            {
                otvet = first / second;
                tb.Text = otvet.ToString();
            }
            else
            {
                
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (tb.Text.Length > 0)
            {
                tb.Text = tb.Text.Substring(0, tb.Text.Length - 1);
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            tb.Text = "";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Calculator 0.1\n30.01.2014");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            memory = tb.Text;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (tb.Text == " ")
            {
                tb.Text = memory;
            }
            else
            {
                tb.Text = tb.Text + memory;
            }
        }

        private void BtClick(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (tb.Text != "Error!")
            {      
                tb.Text = tb.Text + b.Text;
            }
            else
            {
                tb.Text = b.Text;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (tb.Text == "")
            {
                tb.Text = "Error!";
            }
            else
            {
                tb.Text = Math.Sqrt(Convert.ToDouble(tb.Text)).ToString();
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (tb.Text == "")
            {
                tb.Text = "Error!";
            }
            else if (tb.Text == "Error!")
            {
                tb.Text = "Error!";
            }
            else
            {
                tb.Text = Math.Sin(Convert.ToDouble(tb.Text)).ToString();
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (tb.Text == "")
            {
                tb.Text = "Error!";
            }
            else if (tb.Text == "Error!")
            {
                tb.Text = "Error!";
            }
            else
            {
                tb.Text = Math.Cos(Convert.ToDouble(tb.Text)).ToString();
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (tb.Text == "")
            {
                tb.Text = "Error!";
            }
            else if (tb.Text == "Error!")
            {
                tb.Text = "Error!";
            }
            else
            {
                tb.Text = Math.Tan(Convert.ToDouble(tb.Text)).ToString();
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (tb.Text == "")
            {
                tb.Text = "Error!";
            }
            else if (tb.Text == "Error!")
            {
                tb.Text = "Error!";
            }
            else
            {
                tb.Text = (1 / (Math.Tan(Convert.ToDouble(tb.Text)))).ToString();
            }
        }
    }
}
