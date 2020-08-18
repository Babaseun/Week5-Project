using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace MarketWomanCalculator
{
    public static class Utils
    {
        public static List<int> ExtractValues(string value)
        {

            try
            {
                var operators = Regex.Match(value, "[-|+|/|*]");

                var firstValue = value.Substring(0, operators.Index);
                var secondValue = string.Join("", value.Skip(firstValue.Length + 1));

                return new List<int> { int.Parse(firstValue), int.Parse(secondValue) };
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public static int CountValues(string value)
        {

            var values = Regex.Matches(value, "[-|+|/|*]");

            return values.Count;

        }

    }
}

