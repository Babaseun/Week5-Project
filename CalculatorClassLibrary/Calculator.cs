namespace CalculatorLibrary
{
    /// <summary>
    /// A Calculator Class an object of this class will contain the property values
    /// </summary>
    public class Calculator
    {
        public double FirstValue { get; set; }
        public double SecondValue { get; set; }
        public string Sign { get; set; }
        public Calculator(double firstValue, double secondValue, string sign)
        {
            this.FirstValue = firstValue;
            this.SecondValue = secondValue;
            this.Sign = sign;
        }

    }
}
