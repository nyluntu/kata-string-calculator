using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StringCalculator
{
    public class StringCalculator
    {
        public string Add(string input)
        {
            return "operator not supported";
        }

        public List<int> ExtractNumbers(string input)
        {
            List<int> integers = new List<int>();

            var matchCollection = Regex.Matches(input, @"^-?\d+");

            return integers;
        }
    }
}
