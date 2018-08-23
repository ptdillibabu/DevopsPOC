using SampleApplicationForPOC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleApplicationForPOC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Index(AdditionalViewModel model)
        {
            string isMuliplication = System.Configuration.ConfigurationManager.AppSettings["Multiplication"];
            string isAdditional = System.Configuration.ConfigurationManager.AppSettings["Additional"];
            if (isAdditional.ToUpper() == "TRUE")
            {
                ViewBag.Message = model.Value1 + model.Value2;
            }
            
            if (isMuliplication.ToUpper() == "TRUE")
            {
                ViewBag.Message = model.Value1 * model.Value2;
            }
            
            return View(model);
        } 

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}