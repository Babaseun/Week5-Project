using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace MarketWomanCalculator
{
    static class Utils
    {
        public static List<string> ExtractValues(string value)
        {
           
            var operators = Regex.Match(value, "[-|+|/|*]");

            var firstValue = value.Substring(0, operators.Index);
            var secondValue = string.Join("", value.Skip(firstValue.Length + 1));

            return new List<string> { firstValue, secondValue };


        }

        public static string ExtractOperator(string value)
        {

            var operators = Regex.Match(value, "[-|+|/|*]");



            return operators.Value;


        }
    }
}
