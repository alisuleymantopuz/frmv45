using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Utility.Extensions
{
    public static class BaseExtensionMethods
    {
        public static bool IsOfType<T>(this object obj)
        {
            return obj.IsOfType(typeof(T));
        }

        public static bool IsOfType(this object obj, Type type)
        {
            return (obj.GetType() == type);
        }
    }
}
