using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Specifications
{
    public interface IBusinessSpecificationRule<T>
    {
        BusinessSpecificationResult<T> CheckRules(T instance);
        string Code { get; }
        string Message { get; }
    }
}
