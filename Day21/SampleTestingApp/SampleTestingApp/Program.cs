using System;
using System.Collections.Generic;

namespace SampleTestingApp
{
    class Program
    {
        void CustomerManagement()
        {
            IRepo<int, Customer> repo = new CustomerRepo();
            ManageCustomer manage = new ManageCustomer(repo);
            
            manage.AddCustomer(new Customer() { Id = 101, Name = "Tim" });
            PrintCustomers(repo.GetAll());
        }

        private void PrintCustomers(ICollection<Customer> customers)
        {
            foreach (var item in customers)
            {
                Console.WriteLine(item.Id+" "+item.Name);
            }
        }

        static void Main(string[] args)
        {
            new Program().CustomerManagement();
            Console.ReadKey();
        }
    }
}
