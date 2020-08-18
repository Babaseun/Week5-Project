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
        private ICalculatorRepository calc;
        public string Sign;
        public string values;

        public CalculatorUI(ICalculatorRepository calc)
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
            values += button.Text;
        }

        private void Operator_Clicked(object sender, EventArgs e)
        {

            Button button = (Button)sender;

            if (textBox1.Text != "0")
            {
                textBox1.Text += button.Text;
                Sign = button.Text;
                values += button.Text;


            }
            if (Utils.CountValues(values) >= 2)
            {
                

                var removeLast = values.Remove(values.Length - 1);
                var data = Utils.ExtractValues(removeLast);

                Calculator calculatorData = new Calculator(data[0], data[1], Sign);

                 
                var result = calc.Calculate(calculatorData);

                textBox2.Text = result.ToString() + Sign;
                
                calculatorData.Result = result.ToString();
                values = result.ToString() + Sign;

            }


        }
        private void Clear_Button_Clicked(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "";
            values = "";

        }



        private void Calculate_Button_Click(object sender, EventArgs e)
        {
            
                var data = Utils.ExtractValues(values);

                Calculator calculatorData = new Calculator(data[0], data[1], Sign);


                var result = calc.Calculate(calculatorData);

                textBox2.Text = result.ToString();
                calculatorData.Result = result.ToString();
                values = result.ToString();
            

        }

        private void CalculatorUI_Load(object sender, EventArgs e)
        {

        }

        private void ClearEntry_Button_Clicked(object sender, EventArgs e)
        {

        }
    }
}
