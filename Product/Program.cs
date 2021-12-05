using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    class Program
    {
        static void Main(string[] args)
        {
            Products product1 = new Products();
            product1.ProductName = "Laptop";
            product1.ProductPrice = 2000;
            product1.ProductInStock = 50;
            product1.ProductId = 5;


            Products product2 = new Products();
            product2.ProductName = "Mouse";
            product2.ProductPrice = 100;
            product2.ProductInStock = 50;
            product2.ProductId = 3;

            Products product3 = new Products();
            product3.ProductName ="Klavye";
            product3.ProductPrice = 150;
            product3.ProductInStock = 60;
            product3.ProductId = 7;

            Products[] products = new Products[] { product1, product2 ,product3};

            foreach (var product in products)
            {

                Console.WriteLine(product.ProductName + " " + product.ProductPrice + " " + product.ProductInStock);

            }






        }
    }
}
