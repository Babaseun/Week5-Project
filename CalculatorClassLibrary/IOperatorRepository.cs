namespace CalculatorClassLibrary
{
    public interface IOperatorRepository
    {
        double Addition(double firstNumber, double secondNumber);

        double Minus(double firstNumber, double secondNumber);

        double Times(double firstNumber, double secondNumber);

        double Divide(double firstNumber, double secondNumber);

        double Calculate(string value);
    }
}