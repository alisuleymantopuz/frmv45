using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;

namespace Framework.Utility.Extensions
{
    public static class StringExtensions
    {
        public static string Truncate(this string input, int length)
        {
            return Truncate(input, length, "...");
        }

        public static string Truncate(this string input, int length, string suffix)
        {
            if (input == null) return "";
            if (input.Length <= length) return input;

            if (suffix == null) suffix = "...";

            return input.Substring(0, length - suffix.Length) + suffix;
        }

        public static string[] ToLineArray(this string input)
        {
            if (input == null) return new string[] { };
            return System.Text.RegularExpressions.Regex.Split(input, "\r\n");
        }

        public static List<string> ToLineList(this string input)
        {
            List<string> output = new List<string>();
            output.AddRange(input.ToLineArray());
            return output;
        }

        public static string ReplaceBreaksWithBR(this string input)
        {
            return string.Join("<br/>", input.ToLineArray());
        }

        public static string DoubleApostrophes(this string input)
        {
            return Regex.Replace(input, "'", "''");
        }

        public static string ToHTMLEncoded(this string input)
        {
            return HttpContext.Current.Server.HtmlEncode(input);
        }

        public static string ToURLEncoded(this string input)
        {
            return HttpContext.Current.Server.UrlEncode(input);
        }

        public static string FromHTMLEncoded(this string input)
        {
            return HttpContext.Current.Server.HtmlDecode(input);
        }

        public static string FromURLEncoded(this string input)
        {
            return HttpContext.Current.Server.UrlDecode(input);
        }

        public static string StripHTML(this string input)
        {
            return Regex.Replace(input, @"<(style|script)[^<>]*>.*?</\1>|</?[a-z][a-z0-9]*[^<>]*>|<!--.*?-->", "");
        }
    }
}
