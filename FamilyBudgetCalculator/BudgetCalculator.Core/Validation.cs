using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetCalculator.Core
{
    public static class Validation
    {
        public static void CheckIfStringLengthIsValid(string text, int max, int min = 0, string message = null)
        {
            if (text.Length < min || max < text.Length)
            {
                throw new IndexOutOfRangeException(message);
            }
        }

        public static void CheckIfPositive(decimal number, string message = null)
        {
            if (number < 0)
            {
                throw new IndexOutOfRangeException(message);
            }
        }

        public static void CheckIfNull(object obj, string message = null)
        {
            if(obj == null)
            {
                throw new ArgumentNullException(message);
            }
        }
    }
}
