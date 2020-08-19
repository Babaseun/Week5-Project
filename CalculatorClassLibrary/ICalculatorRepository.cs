namespace CalculatorLibrary
{

    /// <summary>
    /// An interface for the Calculator repository class
    /// </summary>
    public interface ICalculatorRepository
    {

        double Addition(double firstNumber, double secondNumber);

        double Minus(double firstNumber, double secondNumber);

        double Times(double firstNumber, double secondNumber);

        double Divide(double firstNumber, double secondNumber);

        double Calculate(Calculator calculator);
    }
}