using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;



namespace HealthDiseasePrediction.Models
{
    public class UserModel
    {
        
        //[Display(Name ="Type your Heart pain Type")]
        [Range(1, 4, ErrorMessage = "We don't have this heart pain ")]
        public int IdChestPainType { get; set; }

        [Range(30, 230, ErrorMessage = "Hiroshima xD")]
        [Required(ErrorMessage = "Give a valid heart rate")]
        public float MaxHeartRateAchived { get; set; }

        [Range(30, 230, ErrorMessage = "Hiroshima xD")]
        [Required(ErrorMessage = "Give a valid Oldpeak")]
        public float Oldpeak { get; set; }



        public float predictedValue { get; set; }





    }
}
