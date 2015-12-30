using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Transformers;

namespace Framework.Core.UnitTests.TransformerUnitTests.FakeObjects.Rules
{
    public class CustomDataListRemovingRule : ObjectTransformationRule<Transaction>
    {
        public CustomDataListRemovingRule()
        {
            ValueOf(x => x.CustomDataList).ShouldBeRemoved();
        }
    }
}
