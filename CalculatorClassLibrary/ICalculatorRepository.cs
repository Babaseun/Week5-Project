namespace CalculatorClassLibrary
{
    public interface ICalculatorRepository
    {

        double Addition(int firstNumber, int secondNumber);

        double Minus(int firstNumber, int secondNumber);

        double Times(int firstNumber, int secondNumber);

        double Divide(int firstNumber, int secondNumber);

        double Calculate(Calculator calculator);
    }
}