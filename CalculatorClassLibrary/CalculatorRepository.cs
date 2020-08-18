using System.Text.RegularExpressions;
using System;
using System.Linq;
using MarketWomanCalculator;

namespace CalculatorClassLibrary
{
    public class CalculatorRepository : ICalculatorRepository
    {
        public double Addition(int firstNumber, int secondNumber)
        {
            var result = firstNumber + secondNumber;
            return result;
        }

        public double Minus(int firstNumber, int secondNumber)
        {
            var result = firstNumber - secondNumber;
            return result;
        }

        public double Times(int firstNumber, int secondNumber)
        {
            return firstNumber * secondNumber;
        }

        public double Divide(int firstNumber, int secondNumber)
        {
            try
            {
                var result = firstNumber / secondNumber;
                return result;
            }
            catch (DivideByZeroException)
            {
                return 0;
             
            }
            
        }

        public double Calculate(Calculator calculator)
        {

            CalculatorRepository process = new CalculatorRepository();

            switch (calculator.Sign)
            {
                case "+":
                    return process.Addition(calculator.FirstValue, calculator.SecondValue);

                case "-":
                    return process.Minus(calculator.FirstValue, calculator.SecondValue);

                case "*":
                    return process.Times(calculator.FirstValue, calculator.SecondValue);
                case "/":
                    return process.Divide(calculator.FirstValue, calculator.SecondValue);

                default:
                    return -1;
            }


        }
    }
}
