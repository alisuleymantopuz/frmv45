using Framework.Transformers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Core.UnitTests.TransformerUnitTests.FakeObjects.Rules
{
    public class PanInfoMaskingRule : ObjectTransformationRule<PanInfo>
    {
        public PanInfoMaskingRule()
        {
            ValueOf(x => x.CardHolder.Pan).ShouldBeMasked(4, 6);
            ValueOf(x => x.CardHolder.Cvv2).ShouldBeRemoved();
        }
    }
}
