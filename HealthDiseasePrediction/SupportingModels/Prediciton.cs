using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HealthDiseasePrediction.Models
{
    public static class Prediciton
    {
        public static string Predict(UserModel model)
        {
            using (HeartDiseasePredictionEntities3 db = new HeartDiseasePredictionEntities3())
            {
                string query = "Select " + model.IdChestPainType.ToString() + ", " + model.MaxHeartRateAchived.ToString() + ", " + model.Oldpeak.ToString();
                var predict = db.Prediction("XGBOOST", query);
               return predict.ToString();
                
            }
            
        }

    }
}