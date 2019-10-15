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
        public ActionResult Newton()
        {
            return View();
        }
        /// <summary>
        /// Controller for receiving data from a Newton view
        /// </summary>
        /// <param name="numberUnderTheRoot">Number under the root. Type - String.</param>
        /// <param name="rootLevel">Root level. Type - int.</param>
        /// <param name="epsilon">Epsilon. Type - String.</param>
        /// <returns>View("Newton") with ViewData["Head"]. ViewData["Head"] = result. Double result</returns>
        [HttpPost]
        public ActionResult Newton(string numberUnderTheRoot, int rootLevel, string epsilon)
        {
            var result = MainService.NewtonMain(numberUnderTheRoot, rootLevel, epsilon);

            ViewData["Head"] = result;

            return View("Newton");
        }
    }
}
