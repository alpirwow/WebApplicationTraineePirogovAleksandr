using System.Web.Mvc;
using WebApplicationTraineePirogovAleksandr.BusinessLayer.InterfacesAndService.Service;

namespace WebApplicationTraineePirogovAleksandr.PresentationLayer.Controllers.ConverterTask
{
    public class ConverterController : Controller
    {
        public ActionResult Converter()
        {
            return View();
        }
        /// <summary>
        /// Controller for receiving data from a Converter view
        /// </summary>
        /// <param name="number">Input number for converter</param>
        /// <returns>String</returns>
        [HttpPost]
        public ActionResult Converter(int number)
        {
            var result = MainService.ConverterMain(number);

            ViewData["Head"] = result;

            return View("Converter");
        }
    }
}