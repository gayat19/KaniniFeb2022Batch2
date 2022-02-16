using System;

namespace UnderstandingInheritanceApp
{
    class Program
    {
        void ExplainSwitch()
        {
            int choice;
            do
            {
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("It is 1");
                        Comon();
                        break;
                    case 2:
                        Console.WriteLine("Two");
                        Comon();
                        break;
                    case 3:
                        Console.WriteLine("Exit.. Byeeee..");
                        break;
                    default:
                        Console.WriteLine("Invalid");
                        break;
                }
            } while (choice!=3);
        }
        void Comon()
        {
            Console.WriteLine("The common code");
        }
        void RunTwoWheeler(Cycle cycle)
        {
            cycle.Name = "ABC";
            cycle.Brand = "AA-AA";
            cycle.Run();
        }
        static void Main(string[] args)
        {
            Cycle cycle = new Cycle();
            new Program().ExplainSwitch();
            Console.ReadKey();
            
        }
    }
}
