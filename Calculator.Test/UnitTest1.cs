using CalculatorClassLibrary;
using System;
using Xunit;

namespace Calculator.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Addition()
        {
            int firstValue = 10;
            int secondValue = 5;

            CalculatorRepository op = new CalculatorRepository();
            var result = op.Addition(firstValue, secondValue);


            Assert.Equal(15, result);


        }

        [Fact]
        public void Minus()
        {
            int firstValue = 10;
            int secondValue = 5;

            CalculatorRepository op = new CalculatorRepository();
            var result = op.Minus(firstValue, secondValue);


            Assert.Equal(5, result);


        }
        [Fact]
        public void Times()
        {
            int firstValue = 5;
            int secondValue = 5;

            CalculatorRepository op = new CalculatorRepository();
            var result = op.Times(firstValue, secondValue);


            Assert.Equal(25, result);


        }
    }
}
