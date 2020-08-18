namespace CalculatorClassLibrary
{
    public class Calculator
    {
        public int FirstValue { get; set; }
        public int SecondValue { get; set; }
        public string Sign { get; set; }
        public Calculator(int firstValue, int secondValue, string sign)
        {
            this.FirstValue = firstValue;
            this.SecondValue = secondValue;
            this.Sign = sign;
        }

    }
}
