using System;
using System.Linq.Expressions;

namespace Framework.Transformers
{
    public class PropertyTransformationRule<T>
    {
        public Expression<Func<T, object>> PropertyExpression { get; set; }

        public Func<PropertyTransformationRule<T>, object, object> TargetDelegate { get; set; }

        public PropertyMaskingRule<T> PropertyMaskingRule { get; set; }

        public IObjectTransformationRuleExecutor ObjectTransformationRuleExecutor { get; set; }

        public Func<PropertyTransformationRule<T>, IObjectTransformationRuleExecutor, object, object> TargetCollectionRuleDelegate { get; set; }
 
    }
}
