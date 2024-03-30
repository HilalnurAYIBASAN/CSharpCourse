using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.FirstName = "Hilal";
            customer.LastName = "Ay";//set bloğunu çalıştırır
            customer.Id = 1;
            customer.City = "Bursa";

            Customer customer2 = new Customer
            {
                Id = 2, FirstName = "Kübra", LastName = "ak", City = "Ankara"
            };

            Console.WriteLine(customer2.FirstName); //get bloğunu çalıştırır.

            Console.ReadLine();

        }
    }
    
    
}

