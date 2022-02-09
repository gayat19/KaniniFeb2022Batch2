using System;

namespace ConsoleApp1
{
    class Program
    {
        /// <summary>
        /// Method takes a integer from user in the console
        /// </summary>
        /// <param name="msg">The msgs is the cardinal order for teh numebr .Id the input is only one number it can be empty</param>
        /// <returns>returns teh number in int datatype</returns>
        static int TakeIntFromConsole(string msg)
        {
            int iNum;
            Console.WriteLine("Please enter the "+msg +" number");
            //iNum = Convert.ToInt32(Console.ReadLine());
            while(Int32.TryParse(Console.ReadLine(), out iNum) == false)
            {
                Console.WriteLine("Invalid entry. " +
                    "Please try again....");
            }
            return iNum;
        }
        static void AddTwoNumbers()
        {
            int iNum1, iNum2;
            iNum1 = TakeIntFromConsole("First");
            iNum2 = TakeIntFromConsole("Second");
            if(iNum1>=0 && iNum2>=0)
            {
                var result = iNum1 + iNum2;
                Console.WriteLine($"The sum of {iNum1} and {iNum2} is {result}");
            }
            else
                Console.WriteLine("Sorry one of the numbers is negative.");
        }
        static void GreatestOfTwo()
        {
            int iNum1, iNum2;
            iNum1 = TakeIntFromConsole("First");
            iNum2 = TakeIntFromConsole("Second");
            //if(iNum1== iNum2)
            //{
            //    Console.WriteLine("The numbers are equal");
            //    return;
            //}
            //if (iNum1 > iNum2)
            //    Console.WriteLine("Num1 is the greatest");
            //else
            //    Console.WriteLine("Num2 is the greatest");
            if (iNum1 == iNum2)
                Console.WriteLine("The numbers are equal");
            else if (iNum1 > iNum2)
                Console.WriteLine("Num1 is the greatest");
            else
                Console.WriteLine("Num2 is the greatest");
        }
        static void PrintNumbers()
        {
            //Init;Cond;Upd
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }
        }

        static void PrintNumberOnCondition()
        {
            int num = 100;
            while (num > 0)
            {
                num = num / 5;
                num = num - (num % 2);
                Console.WriteLine(num);
            }
        }
        static void UnderstandingDoWhile()
        {
            string name;
            do
            {
                Console.WriteLine("Please enter your name");
                name = Console.ReadLine();
            } while (name.Length<=3);
            Console.WriteLine("Hello "+name);
        }
        static void Main(string[] args)
        {
            GreatestOfTwo();
            Console.ReadKey();
        }
    }
}
