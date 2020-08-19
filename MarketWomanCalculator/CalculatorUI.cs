using CalculatorLibrary;
using System;
using System.Windows.Forms;

namespace MarketWomanCalculator
{
    public partial class CalculatorUI : Form
    {
        private ICalculatorRepository calc;
        public string Sign; // Stores the sign
        public string values; // Operation will be done based on input values added here based on the user input
        public int Count = 0; // Keeps track of the number of times a button is clicked

        public CalculatorUI(ICalculatorRepository calc)
        {
            InitializeComponent();
            this.calc = calc;

        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (textBox1.Text == "0") // When the button is clicked the 0 value should be cleared
            {
                textBox1.Clear();
            }


            textBox1.Text += button.Text;// Updating the first text box based on the button clicked
            values += button.Text;  // Updating the values

        }

        private void Operator_Clicked(object sender, EventArgs e) // When an operator is clicked
        {

            Button button = (Button)sender;


            if (textBox1.Text != "0")
            {
                textBox1.Text += button.Text;
                Sign = button.Text; // Assigning the last operator clicked to the field Name of SIGN

                values += button.Text; // Adding the operator to the values

            }
            Count++; // Incrementing the count as the operator button is been clicked

            if (Count >= 2) // if the operator has been clicked 2 or more times calculation is automatically processed
            {
                try
                {


                    var removeLast = values.Remove(values.Length - 1); // Removes the last Operator Calculation is done based on the two values provided

                    var data = Utils.ExtractValuesFromString(removeLast); // Returns the extracted values from a string as a list of double

                    Calculator calculatorData = new Calculator(data[0], data[1], Sign);// An Object is created of the Calculator class

                    var result = calc.Calculate(calculatorData);  // Calls the calculate method of the CalculatorRepository class and returns the result


                    textBox2.Text = result.ToString(); // Adding the result to the screen

                    values = result.ToString() + Sign; // Updating the values


                }
                catch (Exception) { } // Making sure there are no crashes to the based on exceptions generated


            }


        }
        private void Clear_Button_Clicked(object sender, EventArgs e) //When the clear button is clicked
        {
            textBox1.Text = "0";
            textBox2.Text = "";  // Clears the screen
            values = "";
            Sign = "";

            Count = 0;
        }



        private void Calculate_Button_Click(object sender, EventArgs e) // When the Equal button is clicked
        {

            try
            {
                if (!textBox1.Text.StartsWith("-")) // Checks if first operation is not based on a negative value
                {
                    var data = Utils.ExtractValuesFromString(values); // Extracting the values

                    Calculator calculatorData = new Calculator(data[0], data[1], Sign); // Creating an object of the Calculator class
                    var result = calc.Calculate(calculatorData);


                    textBox2.Text = result.ToString(); // Adding the result to the second text box
                    values = result.ToString(); // Updating the values
                }
                else  // Performs operation if the first value is based on a negative value
                {
                    var data = Utils.ExtractValuesFromString(values); // Extraction of the values

                    Calculator calculatorData = new Calculator(data[0], data[1], "-");
                    var result = calc.Calculate(calculatorData);


                    textBox2.Text = result.ToString();
                    values = result.ToString();

                }

            }
            catch (DivideByZeroException) // Catches an exception when there is an attempt to divide by 0
            {
                textBox2.Text = Errors.DivideByZeroExceptionMessage();

            }
            catch (Exception) { } // Catches all other exceptions

        }

        private void CalculatorUI_Load(object sender, EventArgs e) { }

        private void ClearEntry_Button_Clicked(object sender, EventArgs e) // When the arrow button is clicked
        {
            try
            {
                var text = textBox1.Text;
                textBox1.Text = text.Remove(text.Length - 1); // Removing the last value

                values = values.Remove(values.Length - 1); // Removing the last value
            }
            catch (Exception) { }

        }

        private void P_N_Button_Click(object sender, EventArgs e) // When the plus or minus button is clicked
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            textBox1.Text = "-" + textBox1.Text; // Adds the negative operator to the screen

        }
    }
}
