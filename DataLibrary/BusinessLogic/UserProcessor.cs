using DataLibrary.DataAccess;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.BusinessLogic
{
    public static class UserProcessor
    {
        public static int CreateUser(int IdChestPainType, float MaxHeartRateAchived, float Oldpeak, float predictedValue)
        {
            UserModel data = new UserModel
            {
                IdChestPainType = IdChestPainType,
                MaxHeartRateAchived = MaxHeartRateAchived,
                Oldpeak = Oldpeak
            };
            string sql = @"insert into TAB() values ";
            return SQLDataAccess.SaveData(sql, data);

        }
  
    }
}
