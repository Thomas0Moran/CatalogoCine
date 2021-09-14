using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02EntityFrameworkDatabaseFirst
{
    class Program
    {
        static void Main(string[] args)
        {

            NorthwindEntities entities = new NorthwindEntities();

            /*
            Customer costumer = new Customer()
            {
                CustomerID = "EDUIT",
                CompanyName = "EducacionIT",
                Address = "Lavalle",
                City = "CABA",
                ContactName = "contacto@gmail.com",
                ContactTitle = "Mail de contacto",
                Country = "AR",
                Phone = "08001110000",
                PostalCode = "1001",
                Region = "CABA",
            };
            entities.Customers.Add(costumer);
            entities.SaveChanges();
            */
            
            
            var lista = entities.Customers.ToList();
            foreach(var cliente in lista)
            {
                Console.WriteLine(cliente.CompanyName);
            }
            Console.ReadKey();
        }
    }
}
