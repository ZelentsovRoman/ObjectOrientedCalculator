using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ObjectOrientedCalculator.Operations;

namespace ObjectOrientedCalculatorWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Operation = new SelectListItem[]
            {
                new SelectListItem() { Value = "Mult", Text = "Multiply" },
                new SelectListItem() { Value = "Plus", Text = "Sum" },
                new SelectListItem() { Value = "Minus", Text = "Minus" },
                new SelectListItem() { Value = "Div", Text = "Division" },
                new SelectListItem() { Value = "Exp", Text = "Exponent" },
                new SelectListItem() { Value = "Max", Text = "Maximum" },
            };
            return View();
        }
        [HttpPost]
        public ActionResult Index(
            double firstNumber,
            double secondNumber,
            string operation)
        {
            string[] arr = { "Mult", "Div", "Plus", "Minus" , "Max" };
            double result;
            if (arr.Contains(operation))
            {
                ITwoArgCalculator calculator = TwoArgFactory.CreateObjectOrientedCalculator(operation);
                result = calculator.Calculate(firstNumber, secondNumber);
            }
            else
            {
                IOneArgCalculator calculator = OneArgFactory.CreateObjectOrientedCalculator(operation);
                result = calculator.Calculate(firstNumber);
            }

            ViewBag.Result = result;
            ViewBag.Operation = new SelectListItem[]
             {
                new SelectListItem() { Value = "Mult", Text = "Multiply" },
                new SelectListItem() { Value = "Plus", Text = "Sum" },
                new SelectListItem() { Value = "Minus", Text = "Minus" },
                new SelectListItem() { Value = "Div", Text = "Division" },
                new SelectListItem() { Value = "Exp", Text = "Exponent" },
                new SelectListItem() { Value = "Max", Text = "Maximum" },
             };
            return View();
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