using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Models
{
        public class UserModel
        {
            public int IdChestPainType { get; set; }
            public float MaxHeartRateAchived { get; set; }
            public float Oldpeak { get; set; }
            public float predictedValue { get; set; }
        }
    
}
