using System;

namespace Products
{
    class Program
    {
        static void Main(string[] args)
        {


            ProductManager product1 = new ProductManager();
            product1.ProductName = "Laptop";
            product1.ProductPrice = 2000;
            product1.ProductInStock = 50;
            product1.ProductId = 5;


            ProductManager product2 = new ProductManager();
            product2.ProductName = "Mouse";
            product2.ProductPrice = 100;
            product2.ProductInStock = 50;
            product2.ProductId = 3;

            ProductManager product3 = new ProductManager();
            product3.ProductName = "Klavye";
            product3.ProductPrice = 150;
            product3.ProductInStock = 60;
            product3.ProductId = 7;

            ProductManager[] products = new ProductManager[] { product1, product2, product3 };

            foreach (var product in products)
            {
                Console.WriteLine("Urun Adı" + product.ProductName + " " + "Urun Fiyati" + product.ProductPrice + " " + " Stok Adedi" + product.ProductInStock);

            }

            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine("Urun Adi" + products[i].ProductName);
                Console.WriteLine("Urun Fiyati " + products[i].ProductPrice);
                Console.WriteLine("Stok Adedi " + products[i].ProductInStock);
                Console.WriteLine(" Urun Kodu" + products[i].ProductId);
            }


            int x = 0;
            while (x < 3)
            {
                Console.WriteLine("Urun Adi " + products[x].ProductName);
                Console.WriteLine("Urun Fiyati " + products[x].ProductPrice);
                Console.WriteLine("Stok Adedi " + products[x].ProductInStock);
                Console.WriteLine("Urun Kodu " + products[x].ProductId);
            }


        }
    }
}
