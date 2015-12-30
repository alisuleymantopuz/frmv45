using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Core.UnitTests.SerializationUnitTests.FakeObjects
{
    [Serializable]
    public class FakeCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
