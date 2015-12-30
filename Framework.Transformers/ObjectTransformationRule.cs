using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Framework.Transformers
{
    public abstract class ObjectTransformationRule<T> : IObjectTransformationRuleExecutor where T : class
    {
        private readonly List<PropertyTransformationRule<T>> propertyTransformationRuleList = new List<PropertyTransformationRule<T>>();

        private IObjectCopier ObjectCopier = new ObjectCopier();

        protected IPropertyTransformationRuleSetup<T> ValueOf(Expression<Func<T, object>> property)
        {
            PropertyTransformationRule<T> propertyTransformationRule = new PropertyTransformationRule<T>
            {
                PropertyExpression = property
            };
            this.propertyTransformationRuleList.Add(propertyTransformationRule);

            return new PropertyTransformationRuleSetup<T>(propertyTransformationRule, new PropertyTransformationRuleExecutor<T>(new PropertyExpressions<T>()));
        }

        public object ExecuteRules(object instance)
        {
            if (instance == null)
            {
                return instance;
            }
            if (!(instance is T))
            {
                return instance;
            }

            object cloneObject = Activator.CreateInstance(instance.GetType());

            //Clone instance
            this.ObjectCopier.CopyObjectData(instance, cloneObject);

            //ExecuteRules
            foreach (var item in this.propertyTransformationRuleList)
            {
                if (item.TargetDelegate != null)
                    cloneObject = item.TargetDelegate(item, cloneObject);
                if (item.TargetCollectionRuleDelegate != null)
                    cloneObject = item.TargetCollectionRuleDelegate(item, item.ObjectTransformationRuleExecutor, cloneObject);
            }

            return cloneObject;
        }
    }
}
