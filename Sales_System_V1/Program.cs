using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Sales_System.Sales_System_V1
{
    class Program
    {
        public static void Main(String[] args)
        {

            Product sportTennisProduct = new Product();
            sportTennisProduct.Name = "SportTennis";
            sportTennisProduct.Price = 250000;

            Seller jeison = new Seller();
            jeison.Name = "Jeison";
            jeison.Age = 24;
            jeison.AddProduct(sportTennisProduct);


            Product converseProduct = new Product();
            converseProduct.Name = "Converse";
            converseProduct.Price = 150000;

            Seller mariana = new Seller();
            mariana.Name = "Mariana";
            mariana.Age = 30;
            mariana.AddProduct(converseProduct);


            Product tshirtProduct = new Product();
            tshirtProduct.Name = "Tshirt";
            tshirtProduct.Price = 100000;

            Seller rosa = new Seller();
            rosa.Name = "Rosa";
            rosa.Age = 35;
            rosa.AddProduct(tshirtProduct);


            Product jeanProduct = new Product();
            jeanProduct.Name = "Jean";
            jeanProduct.Price = 85000;

            Seller nohelia = new Seller();
            nohelia.Name = "Nohelia";
            nohelia.Age = 49;
            nohelia.AddProduct(jeanProduct);


            Product leatherJacketProduct = new Product();
            leatherJacketProduct.Name = "Leather Jacket";
            leatherJacketProduct.Price = 500000;

            Seller leonardo = new Seller();
            leonardo.Name = "Leonardo";
            leonardo.Age = 39;
            leonardo.AddProduct(leatherJacketProduct);


            Product dressProduct = new Product();
            dressProduct.Name = "Dress";
            dressProduct.Price = 120000;

            Seller valentina = new Seller();
            valentina.Name = "Valentina";
            valentina.Age = 18;
            valentina.AddProduct(dressProduct);
            

            SalesCompany salesCompany = new SalesCompany();
            salesCompany.AddSeller(jeison);
            salesCompany.AddSeller(mariana);
            salesCompany.AddSeller(rosa);
            salesCompany.AddSeller(nohelia);
            salesCompany.AddSeller(leonardo);
            salesCompany.AddSeller(valentina);


            float totalAmount = salesCompany.GetTotalAmount();
            Seller CheapestSalesProduct = salesCompany.CheapestSalesProduct();
            float totalPriceAverage = salesCompany.GetTotalUnits();
            Product ExpensiveSalesProduct = salesCompany.ExpensiveSalesProduct();


            Console.WriteLine("The sales total amount is: " + totalAmount);

            Console.WriteLine("The seller who has sold the cheapest product is: " + CheapestSalesProduct.Name);

            Console.WriteLine("The products price average is: " + (totalAmount / totalPriceAverage));

            Console.WriteLine("The most expensive product is: " + ExpensiveSalesProduct.Name);
            Console.WriteLine("Its price is: " + ExpensiveSalesProduct.Price);
        }
    }
}
