namespace CalculatorLibrary

{

    /// <summary>
    /// A global configuration file that performs the addition AND the removal of Instance of the calculatorRepository Class
    /// </summary>
    public static class GlobalConfig
    {
        public static ICalculatorRepository Instance { get; private set; }

        public static void AddInstance()
        {
            CalculatorRepository op = new CalculatorRepository();
            Instance = op;
        }

        public static void RemoveInstance()
        {
            Instance = null;
        }
    }
}