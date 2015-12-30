using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Utility.Extensions
{
    public static class DecimalExtensions
    {
        public static string ToUIString(this decimal value)
        {
            return value.ToString(CultureInfo.CurrentUICulture);
        }

        public static bool IsEqualMoney(this decimal money1, decimal money2)
        {
            return Math.Abs(money1 - money2) <= 0.01M;
        }

    }
}
