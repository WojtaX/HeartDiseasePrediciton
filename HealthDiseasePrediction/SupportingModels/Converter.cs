using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HealthDiseasePrediction.Models
{
    public static class Converter
    {
        public static  List<SelectListItem> ConvertData()
        {
            List<ChestPainType> P = new List<ChestPainType>();
            using (HeartDiseasePredictionEntities3 db = new HeartDiseasePredictionEntities3())
            {
                var query = db.ChestPainTypes.SqlQuery("Select * from ChestPainTypes;").ToList();
                if (query != null)
                {
                    foreach (var i in query)
                    {
                        P.Add(new ChestPainType(i.IDchestPaintype, i.ChestPainName));
                    }
                }
            }
            List<SelectListItem> item = P.ConvertAll(a =>
            {
                return new SelectListItem()
                {
                    Text = a.ChestPainName,
                    Value = a.IDchestPain + 1.ToString(),
                    Selected = false
                };
            });

            return item;
        }
    }
}