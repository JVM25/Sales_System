using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Sales_System.Sales_System_V1
{
    class Product
    {
        public String Name;
        public float Price;



        public float TotalProductionPrice()
        {
            float totalProductionPrice = Price;

            return totalProductionPrice;
        }

        public float UnitsPrice ()
        {
            float unitsPrice = 0;
            unitsPrice = unitsPrice + 1;
   
            return unitsPrice;
        }


    }
}
