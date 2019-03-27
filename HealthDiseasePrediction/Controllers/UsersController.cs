using HealthDiseasePrediction.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace HealthDiseasePrediction.Controllers
{
    public class UsersController : Controller
    {
        // GET: Users
          public ActionResult Predict()
        {
            return View();
        }
     [HttpPost]
     [ValidateAntiForgeryToken]
        public ActionResult Predict(UserModel user)
        {
            if (ModelState.IsValid)
            {
                user.prediction = Prediciton.Predict(user);
                return View(user);
            }
            else return View();
            }
    }
}