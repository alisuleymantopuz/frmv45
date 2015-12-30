using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Transformers;

namespace Framework.Core.UnitTests.TransformerUnitTests.FakeObjects.Rules
{
    public class Cvv2MaskingRule: ObjectTransformationRule<Transaction>
    {
        public Cvv2MaskingRule()
        {
            ValueOf(x => x.PanInfo.CardHolder.Cvv2).ShouldBeMasked(0, 0);
        }
    }
}
