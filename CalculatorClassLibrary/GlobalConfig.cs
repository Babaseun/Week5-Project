namespace CalculatorClassLibrary

{
    public static class GlobalConfig
    {
        public static ICalculatorRepository Iinstance { get; private set; }

        public static void AddInstance()
        {
            CalculatorRepository op = new CalculatorRepository();
            Iinstance = op;
        }

        public static void RemoveInstance()
        {
            Iinstance = null;
        }
    }
}