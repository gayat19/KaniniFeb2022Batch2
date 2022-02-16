using System;

namespace PizzaStoreModelsLibrary
{
    public class Customer :IComparable
    {
        string phone;
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Phone { 
            get {
                string maskedPhone = "******" + phone.Substring(6, 4);
                return maskedPhone;
                }
            set { phone = value; }
        }

        //public string Phone { get; set; }

        public Customer()
        {

        }

        public Customer(int id, string name, int age, string phone)
        {
            Id = id;
            Name = name;
            Age = age;
            Phone = phone;
        }

        public override string ToString()
        {
            return "Customer ID : " + Id
                + "\nCustomer Name : " + Name
               + "\nCustomer Age : " + Age
               + "\nCustomer Phone : " + Phone;
        }
        public void TakeCustomerDetailsFromConsole()
        {
            Console.WriteLine("Please enter the customer name");
            Name = Console.ReadLine();
            int age = 0;
            Console.WriteLine("Please enter the customer age");
            while (!int.TryParse(Console.ReadLine(), out age))
            {
                Console.WriteLine("Invalid entry for age. Please try again");
            }
            Age = age;
            do
            {
                Console.WriteLine("Please enter the customer phone(10 digit number)");
                Phone = Console.ReadLine();
            } while (Phone.Length != 10);
        }

        public int CompareTo(object obj)
        {
            Customer  c2 = (Customer)obj;//Explicit Type casting
            return this.Age.CompareTo(c2.Age);
        }
    }
}
