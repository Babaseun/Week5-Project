namespace CalculatorClassLibrary
{
    public class Calculator
    {
        public double FirstValue { get; set; }
        public double SecondValue { get; set; }
        public string Sign { get; set; }
        public string Result { get; set; }
        public Calculator(double firstValue, double secondValue, string sign)
        {
            this.FirstValue = firstValue;
            this.SecondValue = secondValue;
            this.Sign = sign;
        }

    }
}
