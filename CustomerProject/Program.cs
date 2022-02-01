using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.CustomerId = 1;
            customer.Name = "Tuncay";
            customer.LastName = "Bayram";
            customer.EmailAdress = "tuncaybayram@gmail.com";
            customer.UserName = "tuncay.bayram";
            customer.Password = "1";
            Customer.CustomerAdd(customer);

            Customer customer1 = new Customer()
            {
                CustomerId = 2,
                Name = "Kutluhan",
                LastName = "Tarlacı",
                EmailAdress = "kutluhan.tarlacı@gmail.com",
                Password = "2"


            };
            Customer.CustomerAdd(customer1);
            Customer customer2 = new Customer();
            customer2.CustomerId = 1;
            customer2.Name = "Tuncay";
            customer2.LastName = "Bayram";
            customer2.EmailAdress = "tuncaybayram@gmail.com";
            customer2.UserName = "tuncay.bayram";
            customer2.Password = "1";
            Customer.CustomerAdd(customer2);

        }
    }
}
