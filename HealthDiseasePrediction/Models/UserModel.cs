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
        [Display(Name ="Type your Heart pain Type")]
        [Range(1, 4, ErrorMessage = "We don't have this heart pain")]
        [Required(ErrorMessage ="ERRR")]
        private int idChestPainType;
    
        public int IdChestPainType
        {
            get { return idChestPainType; }
            set {
                Convert.ToInt16(value);
                idChestPainType = value;
            }
        }
        
        [Range(30, 230, ErrorMessage = "Give a valid Max Heart Rate Achived")]
        [Required(ErrorMessage = "Give a valid heart rate")]
        public float MaxHeartRateAchived { get; set; }

        [Range(30, 230, ErrorMessage = "Give a valid Oldpeak")]
        [Required(ErrorMessage = "Give a valid Oldpeak")]
        public float Oldpeak { get; set; }

        public double prediction { get; set; } = 0;

    }
}
