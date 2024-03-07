using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
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
            customer.City = "Malatya";
            customer.FirstName = "Caner";
            customer.LastName = "Karul";
            customer.Id = 1;

            Customer customer2 = new Customer
            {
                City = "Ankara",
                Id = 2,
                FirstName = "Omar",
                LastName = "Doğan"
            };

            Console.WriteLine(customer2.FirstName);

            Console.ReadLine();
        }
    }

    

    
}
