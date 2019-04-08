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
            List<ChestPainType> ChestPainTypesList = new List<ChestPainType>();
            using (HeartDiseasePredictionEntities5 db = new HeartDiseasePredictionEntities5())
            {
                var query = db.ChestPainTypes.SqlQuery("Select * from ChestPainTypes;").ToList();
                if (query != null)
                {
                    foreach (var i in query)
                    {
                        ChestPainTypesList.Add(new ChestPainType(i.IDchestPaintype, i.ChestPainName));
                    }
                }
            }
            List<SelectListItem> item = ChestPainTypesList.ConvertAll(PainType =>
            {
                return new SelectListItem()
                {
                    Text = PainType.ChestPainName,
                    Value = (PainType.IDchestPain + 1).ToString(),
                    Selected = false
                };
            });

            return item;
        }
    }
}