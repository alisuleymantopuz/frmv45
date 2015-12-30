using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Framework.Mvc.Utility.Binders
{
    public class DatetimeBinder : IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            var value = bindingContext.ValueProvider.GetValue(bindingContext.ModelName);
            if (value != null)
            {
                var date = DateTime.ParseExact(value.AttemptedValue, "dd.MM.yyyy hh:mm:ss", System.Globalization.CultureInfo.CurrentCulture); 
               
                return date;
            }
            return null;
        }
    }
}
