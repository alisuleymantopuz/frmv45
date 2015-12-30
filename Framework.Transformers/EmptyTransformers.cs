using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Transformers
{
    public class EmptyTransformers : IObjectTransformationRuleExecutor
    {
        public object ExecuteRules(object instance)
        {
            return instance;
        }
    }
}
