﻿using PizzaStoreModelsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MultipleProjectApplication
{
    class ManageCustomer
    {
        Customer[] customers;
        public ManageCustomer()
        {
            customers = new Customer[2];//created 5 reff
        }
        public virtual void Add5Customers()
        {
            for (int i = 0; i < customers.Length; i++)
            {
                customers[i] = new Customer();//creating object for each reff
                customers[i].Id = 100 + i + 1;
                customers[i].TakeCustomerDetailsFromConsole();
            }
        }
        public virtual Customer GetCustomerById(int id)
        {
            for (int i = 0; i < customers.Length; i++)
            {
                if(customers[i] != null)
                {
                    if (customers[i].Id == id)
                    {
                        return customers[i];
                    }
                }
            }
            return null;
        }
        protected void PrintCustomer(Customer customer)
        {
            Console.WriteLine("--------------------");
            Console.WriteLine(customer);//will invoke the ToString()--remember we have overrided it
            Console.WriteLine("--------------------");
        }
        public virtual void PrintCustomerById()
        {
            int id = TakeCustomerIdFromUser();
            Customer customer = GetCustomerById(id);
            if(customer != null)
            {
                PrintCustomer(customer);
            }
            else
            {
                Console.WriteLine("No such customer");
            }
        }

        protected int TakeCustomerIdFromUser()
        {
            int id = 0;
            Console.WriteLine("Please enter the customer Id");
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("Invalid entry for Id. Please try again");
            }
            return id;
        }

        internal virtual void SortCustomerByAge()
        {
            Array.Sort(customers);
            foreach (var item in customers)
            {
                Console.WriteLine(item);
            }
        }

        public virtual void PrintAllCustomers()
        {
            foreach (var item in customers)
            {
                if(item!=null)
                    PrintCustomer(item);
            }
        }
        public virtual void UpdateCustomerPhone()
        {
            int id = TakeCustomerIdFromUser();
            Customer customer = GetCustomerById(id);
            if(customer != null)
            {
                Console.WriteLine("The customer details are:");
                PrintCustomer(customer);
                string phone;
                do
                {
                    Console.WriteLine("Please enter the customer phone(10 digit number)");
                    phone = Console.ReadLine();
                } while (phone.Length != 10);
                customer.Phone = phone;
                Console.WriteLine("Phone number updated.....");
                Console.WriteLine("Updated customer data");
                PrintCustomer(customer);
            }
            else
            {
                Console.WriteLine("No such customer");
            }
        }
        public virtual void UpdateCustomerAge()
        {
            int id = TakeCustomerIdFromUser();
            Customer customer = GetCustomerById(id);
            if (customer != null)
            {
                Console.WriteLine("The customer details are:");
                PrintCustomer(customer);
                int age;
                Console.WriteLine("Please enter the customer updated age");
                while (!int.TryParse(Console.ReadLine(), out age))
                {
                    Console.WriteLine("Invalid entry for age. Please try again");
                }
                customer.Age = age;
                Console.WriteLine("Customer Age updated.....");
                Console.WriteLine("Updated customer data");
                PrintCustomer(customer);
            }
            else
            {
                Console.WriteLine("No such customer");
            }
        }
        public virtual void RemoveCustomer()
        {
            int id = TakeCustomerIdFromUser();
            int idx = -1;
            for (int i = 0; i < customers.Length; i++)
            {
                if(customers[i].Id == id)
                {
                    idx = i;
                    break;
                }
            }
            if(idx != -1)
            {
                customers[idx] = null;
            }
            else
            {
                Console.WriteLine("No such customer");
            }
        }
    }
}
