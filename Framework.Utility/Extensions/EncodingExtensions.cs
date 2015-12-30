using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Utility.Extensions
{
    public static class EncodingExtensions
    {
        public static string ChangeEncoding(this string input, Encoding encoding)
        {
            var bytes = encoding.GetBytes(input);
            return encoding.GetString(bytes);
        }

        public static string ToStringByEncoding(this string input, Encoding encoding)
        {
            var bytes = encoding.GetBytes(input);
            return encoding.GetString(bytes);
        }
    }
}
