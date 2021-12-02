using System;
using System.Collections.Generic;

namespace ClassMetotDemo
{
    class Program
    {
        private static IEnumerable<object> collection;

        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.CustomerName = "Umit";
            customer1.CustomerLastname = "Akbas";
            customer1.CustomerId = 1;


            Customer customer2 = new Customer();
            customer2.CustomerName = "Engin";
            customer2.CustomerLastname = "Demirog";
            customer2.CustomerId = 2;

            CustomerManager customerManager = new CustomerManager();

            customerManager.Add(customer1);
            customerManager.Add(customer2);

            CustomerManager customerManager1 = new CustomerManager();
            Customer[] customers = new Customer[] { customer1, customer2 };

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.CustomerName+ " " +customer.CustomerLastname + " " + customer.CustomerId);
            }




            


        }
    }
}
