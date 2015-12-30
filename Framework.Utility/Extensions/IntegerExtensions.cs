using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Framework.Utility.Extensions
{
    public static class IntegerExtensions
    {
        public static bool IsPrime(this int number)
        {
            if ((number % 2) == 0)
            {
                return number == 2;
            }
            int sqrt = (int)Math.Sqrt(number);
            for (int t = 3; t <= sqrt; t = t + 2)
            {
                if (number % t == 0)
                {
                    return false;
                }
            }
            return number != 1;
        }

        public static int TryParse(this string input, int defaultValue)
        {
            int value;
            if (Int32.TryParse(input, out value))
            {
                return value;
            }
            return defaultValue;
        }
         
        public static int KB(this int value)
        {
            return value * 1024;
        }

 
        public static int MB(this int value)
        {
            return value.KB() * 1024;
        }

     
        public static int GB(this int value)
        {
            return value.MB() * 1024;
        }
 
        public static long TB(this int value)
        {
            return (long)value.GB() * (long)1024;
        }

        public static int WordCount(this string input)
        {
            var count = 0;
            try
            {
                // Exclude whitespaces, Tabs and line breaks
                var re = new Regex(@"[^\s]+");
                var matches = re.Matches(input);
                count = matches.Count;
            }
            catch
            {
            }
            return count;
        }

        public static int Squared(this int intToBeSquared)
        {
            return intToBeSquared * intToBeSquared;
        }

        public static Guid ToGuid(this int value)
        {
            byte[] bytes = new byte[16];
            BitConverter.GetBytes(value).CopyTo(bytes, 0);
            return new Guid(bytes);
        }

        public static bool IsInRange(this int target, int start, int end)
        {

            return target >= start && target <= end;

        }

        public static void Times(this int repeatCount, Action<int> action)
        {
            for (int i = 1; i <= repeatCount; i++)
            {
                action(i);
            }
        }

        public static IEnumerable<int> To(this int first, int last)
        {
            return Enumerable.Range(first, last - first + 1);
        }

        public static int[] ToArray(this int number)
        {
            if (number == 0)
            {
                return new int[0];
            }
            else if (number < 0)
            {
                number = -1 * number;
            }

            List<int> list = new List<int>();
            while (number > 0)
            {
                list.Add(number % 10);
                number = number / 10;
            }
            list.Reverse();

            return list.ToArray();
        }

        public static bool In(this int number, params int[] collection)
        {
            bool isIn = false;

            foreach (var i in collection)
            {
                if (number == i)
                {
                    isIn = true;
                    break;
                }
            }

            return isIn;
        }
    }
}
