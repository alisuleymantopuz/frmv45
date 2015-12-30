using System;
using System.Linq.Expressions;
using System.Reflection;

namespace Framework.Transformers
{
    public class PropertyExpressions<T> : IPropertyExpressions<T> where T : class
    {
        public void SetPropertyValue(object instance, Expression<Func<T, object>> memberLamda, object value)
        {
            var memberSelectorExpression = GetExpression(memberLamda);
            if (memberSelectorExpression != null)
            {
                var pi = memberSelectorExpression.Member as PropertyInfo;
                if (pi != null)
                {
                    object target = GetTarget(memberSelectorExpression.Expression, instance);
                    pi.SetValue(target, value, null);
                }
            }
        }

        private MemberExpression GetExpression(Expression<Func<T, object>> memberLamda)
        {
            if (memberLamda.Body is MemberExpression)
            {
                return memberLamda.Body as MemberExpression;
            }
            else if(memberLamda.Body is UnaryExpression)
            {
                UnaryExpression unaryExpression = memberLamda.Body as UnaryExpression;
                return (MemberExpression)unaryExpression.Operand;
            }
            return null;
        }

        public object ReadReadPropertyValue(object instance, Expression<Func<T, object>> memberLamda)
        {
            var memberSelectorExpression = GetExpression(memberLamda);//memberLamda.Body as MemberExpression;
            if (memberSelectorExpression != null)
            {
                object propertyInfo = GetTarget(memberSelectorExpression.Expression, instance);
                if (propertyInfo != null)
                {
                    T objectValue = instance as T;
                    return memberLamda.Compile().Invoke(objectValue);
                }
            }
            return null;
        }
        private object GetTarget(Expression expr, object instance)
        {
            switch (expr.NodeType)
            {
                case ExpressionType.Parameter:
                    return instance;
                case ExpressionType.MemberAccess:
                    MemberExpression mex = (MemberExpression)expr;
                    PropertyInfo pi = mex.Member as PropertyInfo;
                    if (pi == null)
                    {
                        throw new ArgumentException();//throw framework exception
                    }
                    object target = GetTarget(mex.Expression, instance);
                    if (target == null)
                    {
                        return null;
                    }
                    return pi.GetValue(target, null);
                default:
                    throw new InvalidOperationException();//throw framework exception
            }
        }
    }
}
