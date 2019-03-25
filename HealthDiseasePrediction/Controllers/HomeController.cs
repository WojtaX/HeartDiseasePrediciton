using HealthDiseasePrediction.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Web.Mvc;


namespace HealthDiseasePrediction.Controllers
{
   
    public class HomeController : Controller
    {
    
        public ActionResult Index()
        {
            
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(UserModel model)
        {
          

            if (ModelState.IsValid)
            {
                return RedirectToAction("index");
            }
            return View();
        }
      

    }
}