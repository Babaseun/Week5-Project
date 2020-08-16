namespace CalculatorClassLibrary

{
    public static class GlobalConfig
    {
        public static IOperatorRepository Iinstance { get; private set; }

        public static void AddInstance()
        {
            OperatorRepository op = new OperatorRepository();
            Iinstance = op;
        }

        public static void RemoveInstance()
        {
            Iinstance = null;
        }
    }
}