using Framework.UI.UnitTests.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Framework.UI.UnitTests.Web.Controllers
{
    public class ProductController : Controller
    {
        //
        // GET: /Home/

        public ViewResult Index()
        {
            ProductModel productModel = new ProductModel();

            return View(productModel);
        }

        [HttpPost]
        public ActionResult Index(ProductModel productModel)
        {
            var requestDate = productModel.Price;

            return View(productModel);
        }

    }
}
