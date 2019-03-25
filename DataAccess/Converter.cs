using HealthDiseasePrediction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public static class Converter
    {
        public List<SelectListItem> R()
        {
            List<ChestPainType> P = new List<ChestPainType>();
            using (HeartDiseasePredictionEntities1 db = new HeartDiseasePredictionEntities1())
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
