using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Common.UnitTests.UtilityUnitTests.FakeObjects
{
    public class FakeCategoryCreator
    {
        public static FakeCategory CreateCategory(int id, string name)
        {
            return new FakeCategory() { Id = id, Name = name };
        }
    }
}
