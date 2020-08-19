using CalculatorLibrary;
using System;
using System.Windows.Forms;

namespace MarketWomanCalculator
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            GlobalConfig.AddInstance();
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ICalculatorRepository Calc = GlobalConfig.Instance;
            Application.Run(new CalculatorUI(Calc));
            GlobalConfig.RemoveInstance();

        }
    }
}
