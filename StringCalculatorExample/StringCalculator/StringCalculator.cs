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
            if(String.IsNullOrEmpty(input))
                return "operator not supported";

            int sum = 0;
            var extractedNumbers = input.Split('+');
            for (int index = 0; index < extractedNumbers.Length; index++)
            {
                int tempValue;
                if (IsValueInteger(extractedNumbers[index], out tempValue))
                    sum += tempValue;
            }
            return sum.ToString();
        }

        private bool IsValueInteger(string value, out int tempValue)
        {
            return Int32.TryParse(value, out tempValue);
        }
    }
}
