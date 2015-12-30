using Framework.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Core.UnitTests.SpecificationUnitTests.FakeObjects.Rules
{
    public class CategoryMustBeDefined : IBusinessSpecificationRule<Product>
    {
        public BusinessSpecificationResult<Product> CheckRules(Product instance)
        {
            BusinessSpecificationResult<Product> categoryDefinedBusinessForProduct = new BusinessSpecificationResult<Product>();
            categoryDefinedBusinessForProduct.Instance = instance;

            if (categoryDefinedBusinessForProduct.Instance.Category == null
                || string.IsNullOrEmpty(categoryDefinedBusinessForProduct.Instance.Category.Name))
            {
                categoryDefinedBusinessForProduct.BusinessSpecificationMessage = new BusinessSpecificationMessage();
                categoryDefinedBusinessForProduct.BusinessSpecificationMessage.Code = this.Code;
                categoryDefinedBusinessForProduct.BusinessSpecificationMessage.Message = this.Message;
            }

            return categoryDefinedBusinessForProduct;
        }

        public string Code
        {
            get { return "1211"; }
        }

        public string Message
        {
            get { return "Category must be defined."; }
        }
    }
}
