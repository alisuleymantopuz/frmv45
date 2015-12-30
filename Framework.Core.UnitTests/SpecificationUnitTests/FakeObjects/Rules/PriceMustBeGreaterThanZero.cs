using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Specifications;

namespace Framework.Core.UnitTests.SpecificationUnitTests.FakeObjects.Rules
{
    public class PriceMustBeGreaterThanZero : IBusinessSpecificationRule<Product>
    {
        public BusinessSpecificationResult<Product> CheckRules(Product instance)
        {
            BusinessSpecificationResult<Product> priceMustBeGreaterThanZeroBusiness = new BusinessSpecificationResult<Product>();
            priceMustBeGreaterThanZeroBusiness.Instance = instance;

            if (priceMustBeGreaterThanZeroBusiness.Instance == null
                || priceMustBeGreaterThanZeroBusiness.Instance.Price <= 0)
            {
                priceMustBeGreaterThanZeroBusiness.BusinessSpecificationMessage = new BusinessSpecificationMessage();
                priceMustBeGreaterThanZeroBusiness.BusinessSpecificationMessage.Code = this.Code;
                priceMustBeGreaterThanZeroBusiness.BusinessSpecificationMessage.Message = this.Message;
            }

            return priceMustBeGreaterThanZeroBusiness;
        }

        public string Code
        {
            get { return "2311"; }
        }

        public string Message
        {
            get { return "Price must be greater than zero"; }
        }
    }
}
