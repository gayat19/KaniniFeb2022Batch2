using System;

namespace FirstApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void GetNameFromConsole()
        {
            Console.WriteLine("Please enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("Welcome "+name);
        }
        static void TakeNumebrsFromUser()
        {
            int num1, num2;
            string str1 = "100", str2 = null;
            Console.WriteLine("Plese enter the first number");
            num1 = Convert.ToInt32(Console.ReadLine());
            //num1 = Convert.ToInt32(str2);
            Console.WriteLine("Plese enter the second number");
            //num2 = Int32.Parse(Console.ReadLine());
            num2 = Int32.Parse(str2);
            int sum = num1+ num2;
            Console.WriteLine("The sum is "+sum);
        }

        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Console.WriteLine("Line 2");
            //Console.WriteLine("Line 3: Hello again");
            TakeNumebrsFromUser();
        }
    }
}