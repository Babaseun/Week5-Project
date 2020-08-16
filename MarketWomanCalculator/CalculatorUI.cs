using CalculatorClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketWomanCalculator
{
    public partial class CalculatorUI : Form
    {
        private IOperatorRepository calc;

        public CalculatorUI(IOperatorRepository calc)
        {
            InitializeComponent();
            this.calc = calc;

        }

       

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            textBox1.Text += button.Text;
        }

        private void Operator_Clicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            textBox1.Text += button.Text;

        }
        private void Clear_Button_Clicked(object sender, EventArgs e)
        {
            textBox1.Text = "";

        }



        private void Calculate_Button_Click(object sender, EventArgs e)
        {
            var res = calc.Calculate(textBox1.Text);
            textBox1.Text = res.ToString();
        }
    }
}
