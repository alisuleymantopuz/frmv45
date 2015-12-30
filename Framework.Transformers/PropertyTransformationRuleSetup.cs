
using System;
namespace Framework.Transformers
{
    public class PropertyTransformationRuleSetup<T> : IPropertyTransformationRuleSetup<T>
    {
        public PropertyTransformationRule<T> PropertyTransformationRule { get; private set; }
        public IPropertyTransformationRuleExecutor<T> PropertyRuleExecutor { get; private set; }

        public PropertyTransformationRuleSetup(PropertyTransformationRule<T> propertyTransformationRule, IPropertyTransformationRuleExecutor<T> propertyTransformationRuleExecutor)
        {
            this.PropertyRuleExecutor = propertyTransformationRuleExecutor;
            this.PropertyTransformationRule = propertyTransformationRule;
        }
        public void ShouldBeMasked(int howManyEarlyDigistShouldNotToBeMask, int HowManyLastDigistShouldNotToBeMask)
        {
            this.PropertyTransformationRule.PropertyMaskingRule = new PropertyMaskingRule<T>();
            this.PropertyTransformationRule.TargetDelegate = this.PropertyRuleExecutor.MaskPropertyValue;

            this.PropertyTransformationRule.PropertyMaskingRule.HowManyEarlyDigistShouldNotToBeMask = howManyEarlyDigistShouldNotToBeMask;
            this.PropertyTransformationRule.PropertyMaskingRule.HowManyLastDigistShouldNotToBeMask = HowManyLastDigistShouldNotToBeMask;
        }

        public void ShouldBeRemoved()
        {
            this.PropertyTransformationRule.TargetDelegate = this.PropertyRuleExecutor.RemovePropertyValue;
        }

        public void SetCollectionRules(IObjectTransformationRuleExecutor collectionRule)
        {
            this.PropertyTransformationRule.ObjectTransformationRuleExecutor = collectionRule;
            this.PropertyTransformationRule.TargetCollectionRuleDelegate = this.PropertyRuleExecutor.ExecuteCollectionRules;
        }
    }
}
