namespace CalculatorLibrary
{
    /// <summary>
    /// A Error message to sent to the UI based
    /// on calculation done dividing by zero
    /// </summary>
    public class Errors
    {
        public static string DivideByZeroExceptionMessage()
        {
            return "Cannot divide by zero please Clear the screen and start all over";
        }
    }
}
