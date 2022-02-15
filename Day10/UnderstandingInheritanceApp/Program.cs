using System;

namespace UnderstandingInheritanceApp
{
    class Program
    {
        void RunTwoWheeler(Cycle cycle)
        {
            cycle.Name = "ABC";
            cycle.Brand = "AA-AA";
            cycle.Run();
        }
        static void Main(string[] args)
        {
            Cycle cycle = new Cycle();
            new Program().RunTwoWheeler(cycle);
            Console.ReadKey();
            
        }
    }
}
