using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Framework.Mvc.Utility.HtmlHelpers
{
    public static class StringHtmlHelpers
    {
        public static MvcHtmlString Truncate(this HtmlHelper helper, string target, string text, int len)
        {
            string truncatedText;

            if (text.Length > len)
            {
                truncatedText = text.Substring(0, len)+"...";
            }
            else
            {
                truncatedText = text;
            }

            return MvcHtmlString.Create(String.Format("<p for='{0}' class='truncated'>{1}</p><input type='hidden' name='{2}' value='{3}' /> ", target, truncatedText, target, text));

        }
    }
}
