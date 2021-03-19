using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Sales_System.Sales_System_V1
{
    class SalesCompany
    {
        Seller[] Sellers = new Seller[10];
        int sellerCount = 0;

        public void AddSeller(Seller newSeller)
        {
            Sellers[sellerCount] = newSeller;
            sellerCount++;
        }


        public float GetTotalAmount()
        {
            float totalAmountP = 0;
            for (int i = 0; i < sellerCount; i++)
            {
                totalAmountP = totalAmountP + Sellers[i].GetTotalProductAmount();
            }
            return totalAmountP;
        }


        public Seller CheapestSalesProduct()
        {
            Seller seller = Sellers[0];
            String productName = Sellers[0].Name;

            for (int i = 0; i < sellerCount; i++)
            {
                if (Sellers[i].CheapestSalesProduct().TotalProductionPrice() < seller.totalProductionPrice())
                {
                    seller = Sellers[i];
                    productName = Sellers[i].Name;
                }
            }
            return seller;
        }

        public float GetTotalUnits()
        {
            float totalUnit = 0;

            for (int i=0; i < sellerCount; i++)
            {
                totalUnit = totalUnit + Sellers[i].GetTotalUnits();

            }
            return totalUnit;
        }

        public Product ExpensiveSalesProduct()
        {
            Product product1 = Sellers[0].ExpensiveSalesProduct();
            String productName1 = Sellers[0].Name;

            for (int i = 0; i < sellerCount; i++)
            {
                if (Sellers[i].ExpensiveSalesProduct().TotalProductionPrice() > product1.TotalProductionPrice())
                {
                    product1 = Sellers[i].ExpensiveSalesProduct();
                    productName1 = Sellers[i].Name;
                }
            }
            return product1;
        }
    }
}
