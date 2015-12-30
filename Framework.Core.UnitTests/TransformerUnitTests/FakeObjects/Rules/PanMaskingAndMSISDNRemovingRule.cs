using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Transformers;

namespace Framework.Core.UnitTests.TransformerUnitTests.FakeObjects.Rules
{
    public class PanMaskingAndMSISDNRemovingRule : ObjectTransformationRule<Transaction>
    {
        public PanMaskingAndMSISDNRemovingRule()
        {
            ValueOf(x => x.PanInfo.CardHolder.Pan).ShouldBeMasked(4, 4);
            ValueOf(x => x.MSISDN).ShouldBeRemoved();
        }
    }
}
