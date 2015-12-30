using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Framework.UI.UnitTests.Web.Models
{
    public class ProductModel
    {
        public ProductModel()
        {
            this.Price = 2;
            this.Description = "Lorem ipsum dolor sit amet. lorem ipsum dolor sit amet. Lorem ipsum dolor sit amet. lorem ipsum dolor sit amet. Lorem ipsum dolor sit amet. lorem ipsum dolor sit amet. ";
        }
        public decimal Price { get; set; }
        public string Description { get; set; }
    }
}