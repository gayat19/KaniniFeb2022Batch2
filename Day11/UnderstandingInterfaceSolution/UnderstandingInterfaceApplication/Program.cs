using System;

namespace UnderstandingInterfaceApplication
{
    class Program
    {
        void FlightShow(IFlying flying)//by passing the bird obj to flying object only 3 methods are exposed
        {
            Console.WriteLine("Air show");
            Console.WriteLine("-----------------");
            flying.TakeOff();
            flying.Fly();
            flying.Land();
            Console.WriteLine("-----------------");

        }
        void ForestLife(ILiving living)
        {
            Console.WriteLine("Forest Life");
            Console.WriteLine("-----------------");
            living.Eat();
            living.Breathe();
            Console.WriteLine("-----------------");
        }
        static void Main(string[] args)
        {
            //Bird bird = new Bird();
            //Program program = new Program();
            //program.FlightShow(bird);//Showing whatever is needed- abstraction
            //program.ForestLife(bird);
            //int[] numbers = { 12, 67, 33, 86, 34, 67, 90, 14 };
            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("After sort");
            //Array.Sort(numbers);
            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}

            //int num1 = 10;
            //float num2 = 12.6f;
            ////num2 = num1;//allowed-no loss of data - implicit casting
            ////num1 = num2;//Not allowed
            //num1 = (int)num2;//Explicit casting- acknowledge the loss of data
            ////Console.WriteLine(Math.Round(num2, 0));
            //Console.WriteLine(num1);
            string str1 = "";
            int num1 = 100;
            str1 = num1.ToString();//Boxing- Converting value type to reff type
            str1 = str1 + "10";
            Console.WriteLine(str1);
            num1 = Convert.ToInt32(str1);//Unboxing- converting ref type to value type
            num1++;
            Console.WriteLine(num1);
            Console.ReadKey();
            
        }
    }
}
