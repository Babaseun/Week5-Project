using System;

namespace CalculatorLibrary
{
    public class CalculatorRepository : ICalculatorRepository
    {
        /// <summary>
        /// Returns the addition of two numbers based on the blue print of class calculator
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <returns>
        /// Return a value type double
        /// </returns>
        public double Addition(double firstNumber, double secondNumber)
        {

            var result = firstNumber + secondNumber;
            return result;


        }

        /// <summary>
        /// Returns the subtraction of two numbers
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <returns></returns>
        public double Minus(double firstNumber, double secondNumber)
        {
            var result = firstNumber - secondNumber;
            return result;
        }

        /// <summary>
        /// Returns the multiplication of two numbers
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <returns>
        /// Returns the result of the multiplication 
        /// </returns>
        public double Times(double firstNumber, double secondNumber)
        {
            return firstNumber * secondNumber;
        }

        /// <summary>
        /// Divides two numbers the firstNumber and secondNumber 
        /// and also checks if division by 0 is passed to the method
        /// in which a DivideByZeroException Error is thrown
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <returns>
        /// Returns the result of the division
        /// </returns>
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

        /// <summary>
        /// These is where the calculation process is executed
        /// it receives a value type calculator
        /// which contains the property of the firstValue,
        /// secondValue and the operator
        /// </summary>
        /// <param name="calculator"></param>
        /// <returns></returns>
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
