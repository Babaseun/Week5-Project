using System.Text.RegularExpressions;
using System;
using System.Linq;
using MarketWomanCalculator;

namespace CalculatorClassLibrary
{
    public class CalculatorRepository : ICalculatorRepository
    {
        public double Addition(double firstNumber, double secondNumber)
        {
            if (firstNumber < 0 || secondNumber < 0)
            {
                throw new ArgumentException("Please enter valid values");
            }
            else
            {
                var result = firstNumber + secondNumber;
                return result;
            }
           
        }

        public double Minus(double firstNumber , double secondNumber )
        {
            var result = firstNumber - secondNumber;
            return result;
        }

        public double Times(double firstNumber, double secondNumber)
        {
            return firstNumber * secondNumber;
        }

        public double Divide(double firstNumber, double secondNumber)
        {
            if (firstNumber == 0 || secondNumber == 0)
            {
                throw new DivideByZeroException("You cannot divide by zero");
            }
            else if (firstNumber < 0 || secondNumber < 0)
            {
                throw new ArgumentException("Please enter valid values");
            }
            else
            {
                var result = firstNumber / secondNumber;
                return result;
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
