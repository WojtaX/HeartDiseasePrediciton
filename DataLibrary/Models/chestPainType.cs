using DataLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Models
{
    public  class chestPainType
    {
      public int IDchestPain { get; set; }
      public string ChestPainName { get; set; }

        public List<chestPainType> LoadPainType()
        {
            List<chestPainType> ReturnList = new List<chestPainType>();
            foreach(var a in SQLDataAccess.LoadData<chestPainType>("select * from ChestPainType;")  )
            {
                ReturnList.Add(a);
            }

            return ReturnList;
        }

    }
}
