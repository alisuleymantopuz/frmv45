using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Core.UnitTests.SpecificationUnitTests.FakeObjects
{
    public class FakeProductObject
    {
        public static Product CreateProduct()
        {
            return new Product()
                {
                    Category = new Category() { Id = 1, Name = "Beverages" },
                    Id = 1,
                    Name = string.Empty,
                    Price = -12,
                    Quantity = 2

                };

        }
    }
}
