using Framework.UI.UnitTests.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Framework.UI.UnitTests.Web.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ViewResult Index()
        {
            LogModel logModel =new LogModel();

            return View(logModel);
        }

        [HttpPost]
        public ActionResult Index(LogModel logModel)
        {
            var requestDate = logModel.RequestDate;

            return View(logModel);
        }
    }
}
