using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Transformers; 

namespace Framework.Core.UnitTests.TransformerUnitTests.FakeObjects.Rules
{
    public class MSISDNRemovingRule : ObjectTransformationRule<Transaction>
    {
        public MSISDNRemovingRule()
        {
            ValueOf(x => x.MSISDN).ShouldBeRemoved();
        }
    }
}
