using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HealthDiseasePrediction.Models
{
    public class ChestPainType
    {
        public    int IDchestPain { get; set; }
        public string ChestPainName { get; set; }
        public ChestPainType()
        {

        }
        public ChestPainType(int IDchestPain, string ChestPainName)
        {
            this.IDchestPain = IDchestPain;
            this.ChestPainName = ChestPainName;
        }

    

    }
}