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
        public void Times()
        {
            int firstValue = 5;
            int secondValue = 5;

            CalculatorRepository op = new CalculatorRepository();
            var result = op.Times(firstValue, secondValue);


            Assert.Equal(25, result);


        }
        [Fact]
        public void Minus()
        {
            int firstValue = 5;
            int secondValue = 5;

            CalculatorRepository op = new CalculatorRepository();
            var result = op.Times(firstValue, secondValue);


            Assert.Equal(25, result);


        }
        [Fact]
        public void Divide()
        {
            int firstValue = 4;
            int secondValue = 2;

            CalculatorRepository op = new CalculatorRepository();
            var result = op.Divide(firstValue, secondValue);


            Assert.Equal(2, result);


        }
        [Fact]
        public void DivideByZero()
        {
            int firstValue = 4;
            int secondValue = 0;

            CalculatorRepository op = new CalculatorRepository();
           


            Assert.Throws<DivideByZeroException>(() => op.Divide(firstValue, secondValue));
            


        }
       
    }
}
