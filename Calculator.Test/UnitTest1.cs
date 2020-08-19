using CalculatorLibrary;
using System;
using Xunit;

namespace Calculator.Test
{
    public class UnitTest1
    {
        /// <summary>
        /// Test for addition of values
        /// </summary>
        [Fact]
        public void Addition()
        {
            int firstValue = 10;
            int secondValue = 5;

            CalculatorRepository op = new CalculatorRepository();
            var result = op.Addition(firstValue, secondValue);


            Assert.Equal(15, result);


        }

       
        /// <summary>
        /// Test for the multiplication of values
        /// </summary>
        [Fact]
        public void Times()
        {
            int firstValue = 5;
            int secondValue = 5;

            CalculatorRepository op = new CalculatorRepository();
            var result = op.Times(firstValue, secondValue);


            Assert.Equal(25, result);


        }
        /// <summary>
        /// Test for the subtraction of values
        /// </summary>
        [Fact]
        public void Minus()
        {
            int firstValue = 5;
            int secondValue = 5;

            CalculatorRepository op = new CalculatorRepository();
            var result = op.Times(firstValue, secondValue);


            Assert.Equal(25, result);


        }
        /// <summary>
        /// Test for the division of values
        /// </summary>
        [Fact]
        public void Divide()
        {
            int firstValue = 4;
            int secondValue = 2;

            CalculatorRepository op = new CalculatorRepository();
            var result = op.Divide(firstValue, secondValue);


            Assert.Equal(2, result);


        }
        /// <summary>
        /// Making sure an error is thrown when an attempt is made to divide by zero
        /// </summary>
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
