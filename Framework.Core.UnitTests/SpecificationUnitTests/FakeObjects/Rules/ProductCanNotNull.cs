using Framework.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Core.UnitTests.SpecificationUnitTests.FakeObjects.Rules
{
    public class ProductCanNotNull : IBusinessSpecificationRule<Product>
    {
        public BusinessSpecificationResult<Product> CheckRules(Product instance)
        {
            BusinessSpecificationResult<Product> productCanNotNullBusiness = new BusinessSpecificationResult<Product>();
            productCanNotNullBusiness.Instance = instance;

            if (productCanNotNullBusiness.Instance == null
                || string.IsNullOrEmpty(productCanNotNullBusiness.Instance.Name))
            {
                productCanNotNullBusiness.BusinessSpecificationMessage = new BusinessSpecificationMessage();
                productCanNotNullBusiness.BusinessSpecificationMessage.Code = this.Code;
                productCanNotNullBusiness.BusinessSpecificationMessage.Message = this.Message;
            }

            return productCanNotNullBusiness;
        }

        public string Code
        {
            get { return "1311"; }
        }

        public string Message
        {
            get { return "Product must have a value."; }
        }
    }
}
