using System;
using System.Collections;
using System.Collections.Generic;

namespace UnderstandingCollectionApplication
{
    class Program
    {
        void understandingSimpleCollection()
        {
            //int[] numbers = new int[3];
            //numbers[3] = 100;
            ArrayList numbers = new ArrayList();
            numbers.Add(10);
            numbers.Add(67.85f);
            numbers.Add(1045);
            numbers.Add("Hello");
            numbers.Add(new { Id=101,Name="Tim" });//Anon type
            numbers.Add(45.6);
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------------------");
            Console.WriteLine(numbers[2]);
            int sum = 0;
            foreach (var item in numbers)
            {
                sum += Convert.ToInt32(item);
            }
            Console.WriteLine(sum);

        }

        void UnderstandingList()
        {
            List<int> numbers = new List<int>();
            numbers.Add(10);
            numbers.Add(1232);
            numbers.Add(347);
            numbers.Add(90);
            numbers.Add(56);
            numbers.Add(324);
            int sum = 0;
            foreach (var item in numbers)
            {
                sum += Convert.ToInt32(item);
            }
            numbers[2] = 101234;
            Console.WriteLine(sum);

        }
        void UnderstandingSet()
        {
            HashSet<int> numbers = new HashSet<int>();
            numbers.Add(10);
            numbers.Add(1232);
            numbers.Add(347);
            numbers.Add(90);
            numbers.Add(56);
            numbers.Add(324);
            numbers.Add(10);
            numbers.Add(10);
            int sum = 0;
            numbers.Remove(347);
            foreach (var item in numbers)
            {
                sum += Convert.ToInt32(item);
            }
            Console.WriteLine(sum);
        }
        void MakingEmployeeList()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee() { Id = "E001", Name = "Tim", Salary = 12345.54 });
            employees.Add(new Employee() { Id = "E002", Name = "Jim", Salary = 65745643 });
            employees.Add(new Employee() { Id = "E003", Name = "Lim", Salary = 345453.65 });
            employees.Sort();
            for (int i = 0; i < employees.Count; i++)
            {
                Console.WriteLine(employees[i]);
            }
        }
        void UnderstandingDictionary()
        {
            Dictionary<string, Employee> employees = new Dictionary<string, Employee>();
            employees.Add("E001", new Employee() { Id = "E001", Name = "Tim", Salary = 12345.54 });
            employees.Add("E002", new Employee() { Id = "E002", Name = "Jim", Salary = 12345.54 });
            employees.Add("E003", new Employee() { Id = "E003", Name = "Kim", Salary = 12345.54 });
            if(employees.ContainsKey("E003"))
                Console.WriteLine("Already pesent");
            else
                employees.Add("E003", new Employee() { Id = "E004", Name = "Pim", Salary = 445645 });
            foreach (var item in employees.Keys)
            {
                Console.WriteLine(employees[item]);
            }
        }

        static void Main(string[] args)
        {
            Program program = new Program();
            program.UnderstandingDictionary();
            Console.ReadKey();
        }
    }
}
