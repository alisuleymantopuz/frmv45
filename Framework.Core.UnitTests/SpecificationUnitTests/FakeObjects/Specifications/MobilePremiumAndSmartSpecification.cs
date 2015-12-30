using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Specifications;

namespace Framework.Core.UnitTests.SpecificationUnitTests.FakeObjects.Specifications
{
    public class MobilePremiumAndSmartSpecification : CompositeSpecification<Mobile>
    {
        public override bool IsSatisfiedBy(Mobile o)
        {
            return (o.Cost >= 600 && o.Type == MobileType.Smart);
        }
    }
}
