using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Musteri Eklendi" +" " + customer.CustomerName +" " + customer.CustomerLastname + " " + customer.CustomerId);

        }
        
        public void Delete(Customer customer)
        {
            Console.WriteLine("Musteri Silndi"+customer.CustomerName + customer.CustomerLastname + customer.CustomerId);

        }

        public void ListCustomer(Customer customer)
        {
            Console.WriteLine("Musteri Bilgileri" + " " + customer.CustomerName + " " + customer.CustomerLastname +" "+  customer.CustomerId);

        }

        
    }
}
