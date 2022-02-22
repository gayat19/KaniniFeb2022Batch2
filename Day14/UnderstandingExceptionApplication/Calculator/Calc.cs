using System;
using System.Diagnostics;

namespace Calculator
{
    public class Calc
    {
        public double Divide()
        {
            int num1, num2;
            double result = 0;
            Console.WriteLine("Please enter the first number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the second number");
            num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 < 0)
                throw new InValidNumberException(num1, "Negative numebr not allowed");
            result = num1 / num2;
            return result;
            
        }
    }
}
