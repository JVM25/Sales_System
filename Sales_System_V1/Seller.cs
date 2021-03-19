using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Sales_System.Sales_System_V1
{
    class Seller
    {
        public String Name;
        public int Age;


        Product[] Products = new Product[25];
        int productCount = 0;

        public void AddProduct(Product newProduct)
        {
            Products[productCount] = newProduct;
            productCount++;
        }


        public float GetTotalProductAmount()
        {
            float totalAmount = 0;
            for (int i = 0; i < productCount; i++)
            {
                float totalProductAmount = Products[i].TotalProductionPrice();
                totalAmount = totalAmount + totalProductAmount;

            }
            return totalAmount;
        }


        public float totalProductionPrice()
        {
            float totalSales = 0;
            {
                for (int i = 0; i < productCount; i++)
                {
                    float totalPsale = Products[i].TotalProductionPrice();
                    totalSales = totalSales + totalPsale;
                }
            }
            return totalSales;
        }
 
    
        public Product CheapestSalesProduct()
        {
            Product seller = Products[0];
            for (int i = 0; i < productCount; i++)
            {
                seller = Products[i];
            }
            return seller;
        }


        public float GetTotalUnits()
        {
            float totalUnits = 0;
            for (int i = 0; i < productCount; i++)
            {
                totalUnits = totalUnits + 1;
      
                Console.WriteLine("The product is:" + Products[i].Name + ", and its total units is: " + totalUnits);
            }
            return totalUnits;
        }


        public Product ExpensiveSalesProduct()
        {
            Product product1 = Products[0];

            for (int i = 0; i < productCount; i++)
            {
                product1 = Products[i];
            }
            return product1;
        }
    }
}
