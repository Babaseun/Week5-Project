using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace MarketWomanCalculator
{
    public static class Utils
    {
        public static List<double> ExtractIntFromString(string value)
        {

                var operators = Regex.Match(value, "[-|+|/|*]");

                var firstValue = value.Substring(0, operators.Index);
                var secondValue = string.Join("", value.Skip(firstValue.Length + 1));

                return new List<double> { double.Parse(firstValue), double.Parse(secondValue) };
               

        }

        public static string Data(string value)
        {
            var index = "";

            var operators = Regex.Matches(value, "[-|+|/|*]");

            foreach (Match item in operators)
            {
                index += item.Index;
            }

            return index;


            

        }

        

    }
}

