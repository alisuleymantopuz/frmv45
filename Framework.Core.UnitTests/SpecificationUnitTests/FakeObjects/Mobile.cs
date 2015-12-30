using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Core.UnitTests.SpecificationUnitTests.FakeObjects
{
    public class Mobile
    {

        public Mobile(MobileBrandName brandName, MobileType type, int cost = 0)
        {
            this.BrandName = brandName;
            this.Type = type;
            this.Cost = cost;
        }

        public string GetDescription()
        {
            return "The mobile is of brand : " + this.BrandName + " and of type : " + this.Type;
        }

        public MobileBrandName BrandName { get; set; }
        public MobileType Type { get; set; }
        public decimal Cost { get; set; }
    }
}
