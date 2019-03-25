using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HealthDiseasePrediction.Controllers
{
    public class PredictionController : Controller
    {
        // GET: Prediction
        public void Predict()
        {
            using (HeartDiseasePredictionEntities1 db = new HeartDiseasePredictionEntities1())
            {
                var query = db.ChestPainTypes.SqlQuery(" exec Prediction @model='XGBOOST',@IdChestPaintype=20,@Oldpeak=190,@MaxHeartRateAchived=90 ;").ToList();
                if (query != null)
                {
                 
                }
                
            }
          
        }


        public ActionResult Index()
        {
            return View();
        }
    }
}