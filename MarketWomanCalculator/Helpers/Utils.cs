using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace MarketWomanCalculator
{

    public static class Utils
    {
        /// <summary>
        /// Extract the number values from a string and returns
        /// the extracted values in a list of a generic type double
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static List<double> ExtractValuesFromString(string value)
        {
            // Matches all values till it gets to the operator 
            var operators = Regex.Match(value, "[-|+|/|*]");

            // Slicing out the value to the operator index
            var firstValue = value.Substring(0, operators.Index);

            //Skipping the first slice and joining the remaining slice
            var secondValue = string.Join("", value.Skip(firstValue.Length + 1));

            return new List<double> { double.Parse(firstValue), double.Parse(secondValue) };


        }



    }
}

