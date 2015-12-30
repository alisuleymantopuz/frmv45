using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Transformers;

namespace Framework.Core.UnitTests.TransformerUnitTests.FakeObjects.Rules
{
    public class NullableTerminalNumberRemovingRule : ObjectTransformationRule<Transaction>
    {
        public NullableTerminalNumberRemovingRule()
        {
            ValueOf(x => x.TerminalNumberNullable).ShouldBeRemoved();
        }
    }
}
