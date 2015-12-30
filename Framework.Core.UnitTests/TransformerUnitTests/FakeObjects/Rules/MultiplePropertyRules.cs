using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Transformers;

namespace Framework.Core.UnitTests.TransformerUnitTests.FakeObjects.Rules
{
    public class MultiplePropertyRules : ObjectTransformationRule<Transaction>
    {
        public MultiplePropertyRules()
        {
            ValueOf(x => x.PanInfo.CardHolder.Pan).ShouldBeMasked(4, 4);
            ValueOf(x => x.PanInfo.CardHolder.Cvv2).ShouldBeMasked(0, 0);
            ValueOf(x => x.MSISDN).ShouldBeRemoved();
            ValueOf(x => x.CustomDataList).ShouldBeRemoved();
            ValueOf(x => x.TerminalInfo.TerminalNumber).ShouldBeRemoved();
            ValueOf(x => x.TerminalNumberNullable).ShouldBeRemoved();
        }
    }
}
