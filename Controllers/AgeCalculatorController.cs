using AgeCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AgeCalculator.Controllers
{
    public class AgeCalculatorController : Controller
    {
        // GET: AgeCalculator
        public ActionResult Index()
        {
            //get datapicker
            AgeModel model = new AgeModel();
            model.DOB = DateTime.Now;
            return View(model);
        }


        public ActionResult Div()
        {
            ViewBag.Message = "Centriranje div elementra";

            return View();
        }
    }
}