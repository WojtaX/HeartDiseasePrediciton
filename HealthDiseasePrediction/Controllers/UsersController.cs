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
          public ActionResult Index()
        {
            
            return View();
        }
     [HttpPost]
        public ActionResult Savemodel(FormCollection collection)
        {
            UserModel model = new UserModel();
            ViewData["IdChestPainType"] = collection["IdChestPainType"];
            model.IdChestPainType= Convert.ToInt16( collection["IdChestPainType"] );
            model.MaxHeartRateAchived = Convert.ToInt16(collection["MaxHeartRateAchived"]);
            model.Oldpeak = Convert.ToInt16(collection["Oldpeak"]);

            string t=Prediciton.Predict(model);
            model.predictedValue = t;
            return Content(t);
        }
    }
}