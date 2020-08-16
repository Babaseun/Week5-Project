using System.Text.RegularExpressions;
using System;
using System.Linq;
using MarketWomanCalculator;

namespace CalculatorClassLibrary
{
    public class OperatorRepository : IOperatorRepository
    {
        public  double Addition(double firstNumber, double secondNumber)
        {
           var result = firstNumber + secondNumber;
           return result;
        }

        public double Minus(double firstNumber, double secondNumber)
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
            var result = firstNumber / secondNumber;
            return result;
        }

        public double Calculate(string value)
        {
            
            OperatorRepository op = new OperatorRepository();

            var res = Utils.ExtractValues(value);
            var ope = Utils.ExtractOperator(value);
            switch (ope)
            {
                case "+":
                    return op.Addition(double.Parse(res[0]), double.Parse(res[1]));
                   
                case "-":
                    return op.Minus(double.Parse(res[0]), double.Parse(res[1]));


                case "*":
                    return op.Times(double.Parse(res[0]), double.Parse(res[1]));
                case "/":
                    return op.Divide(double.Parse(res[0]), double.Parse(res[1]));


                default:
                    return 0;
            }


        }
    }
}
