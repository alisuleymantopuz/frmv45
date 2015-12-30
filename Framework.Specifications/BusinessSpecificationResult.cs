using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Specifications
{
    public class BusinessSpecificationResult<T>
    {
        public T Instance { get; set; }
        public BusinessSpecificationMessage BusinessSpecificationMessage { get; set; }
    }
}
