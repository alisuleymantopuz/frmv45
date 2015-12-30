
using System;

namespace Framework.Transformers
{
    public class PropertyTransformationRuleExecutor<T> : IPropertyTransformationRuleExecutor<T> where T : class
    {
        public IPropertyExpressions<T> PropertyExpressions { get; private set; }

        public PropertyTransformationRuleExecutor(IPropertyExpressions<T> propertyExpressions)
        {
            this.PropertyExpressions = propertyExpressions;
        }

        public object MaskPropertyValue(PropertyTransformationRule<T> propertyTransformationRule, object instance)
        {
            object propertyValue = this.PropertyExpressions.ReadReadPropertyValue(instance, propertyTransformationRule.PropertyExpression);
            if (propertyValue != null)
            {
                string maskedPropertyValue = MaskPropertyValue(propertyTransformationRule.PropertyMaskingRule.HowManyEarlyDigistShouldNotToBeMask, propertyTransformationRule.PropertyMaskingRule.HowManyLastDigistShouldNotToBeMask, propertyValue.ToString());
                this.PropertyExpressions.SetPropertyValue(instance, propertyTransformationRule.PropertyExpression, maskedPropertyValue);
            }
            return instance;
        }

        public object RemovePropertyValue(PropertyTransformationRule<T> propertyTransformationRule, object instance)
        {
            object propertyValue = this.PropertyExpressions.ReadReadPropertyValue(instance, propertyTransformationRule.PropertyExpression);
            if (propertyValue != null)
            {
                this.PropertyExpressions.SetPropertyValue(instance, propertyTransformationRule.PropertyExpression, null);
            }
            return instance;
        }

        private string MaskPropertyValue(int howManyEarlyDigistShouldNotToBeMask, int howManyLastDigistShouldNotToBeMask, string propertyValue)
        {
            if (propertyValue.Length > howManyEarlyDigistShouldNotToBeMask + howManyEarlyDigistShouldNotToBeMask)
            {
                var first = propertyValue.Substring(0, howManyEarlyDigistShouldNotToBeMask);
                var last = propertyValue.Substring(propertyValue.Length - howManyLastDigistShouldNotToBeMask, howManyLastDigistShouldNotToBeMask);

                string mask = new string('*', propertyValue.Length - howManyEarlyDigistShouldNotToBeMask - howManyLastDigistShouldNotToBeMask);

                return first + mask + last;
            }
            return propertyValue;
        }

        public object ExecuteCollectionRules(PropertyTransformationRule<T> propertyTransformationRule, IObjectTransformationRuleExecutor customRules, object instance)
        {
            dynamic propertyValue = this.PropertyExpressions.ReadReadPropertyValue(instance, propertyTransformationRule.PropertyExpression);
            if (propertyValue != null)
            {
                dynamic temporyList = Activator.CreateInstance(propertyValue.GetType());
                foreach (var item in propertyValue)
                {
                    var propertyWithRule = customRules.ExecuteRules(item);
                    temporyList.Add(propertyWithRule);
                }
                this.PropertyExpressions.SetPropertyValue(instance, propertyTransformationRule.PropertyExpression, temporyList);
            }
            return instance;
        }
    }
}
