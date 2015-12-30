using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Specifications
{
    public class ExpressionSpecification<T> : CompositeSpecification<T>
    {
        public Func<T, bool> Expression { get; private set; }

        public ExpressionSpecification(Func<T, bool> expression)
        {
            if (expression == null)
                throw new ArgumentNullException();
            else
                this.Expression = expression;
        }

        public override bool IsSatisfiedBy(T o)
        {
            return this.Expression(o);
        }
    }  
}
