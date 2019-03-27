using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Web;

namespace HealthDiseasePrediction.Models
{
    public static class Prediciton
    {
        public static double Predict(UserModel model)
        {
            using (HeartDiseasePredictionEntities3 db = new HeartDiseasePredictionEntities3())
            {
                ObjectParameter @test=new ObjectParameter("test",typeof(float));
                string query = "Select " + model.IdChestPainType.ToString() + ", " + model.MaxHeartRateAchived.ToString() + ", " + model.Oldpeak.ToString();
                var predict = db.Prediction("XGBOOST", query,@test);
                ObjectParameter @object = new ObjectParameter("object", test.Value);
               return Convert.ToDouble(test.Value);
                            }
            
        }

    }
}