using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] equation = equationBox.Text.Split(' ');
            int result = 1;
            int num1 = Convert.ToInt32(equation[0]);
            int num2 = Convert.ToInt32(equation[2]);

            if (equation[1] == "+")
            {
                result = num1 + num2;
            }

            if (equation[1] == "-")
            {
                result = num1 - num2;
            }

            if (equation[1] == "*")
            {
                result = num1 * num2;
            }

            if (equation[1] == "^")
            {
                for (int i = 0; i < num2; i++)
                {
                    result = result * num2;
                }
            }

            resultBox.Text = result.ToString();
        }
    }
}
