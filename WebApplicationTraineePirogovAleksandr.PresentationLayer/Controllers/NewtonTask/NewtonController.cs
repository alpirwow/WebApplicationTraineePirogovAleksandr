using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationTraineePirogovAleksandr.BusinessLayer.InterfacesAndService.Service;

namespace WebApplicationTraineePirogovAleksandr.PresentationLayer.Controllers.NewtonTask
{
    public class NewtonController : Controller
    {        

        // GET: Newton/Create
        public ActionResult Newton()
        {
            return View();
        }

        // POST: Newton/Create
        [HttpPost]
        public ActionResult Newton(string numberUnderTheRoot, int rootLevel, string epsilon)
        {
            var result = MainService.NewtonMain(numberUnderTheRoot, rootLevel, epsilon);

            ViewData["Head"] = result;

            return View("Newton");
        }
    }
}
