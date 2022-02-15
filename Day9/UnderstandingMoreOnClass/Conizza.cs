using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingMoreOnClass
{
    class Conizza :Pizza
    {
        public string Cone { get; set; }

        public override void TakePizzaDetailsFromConsole()
        {
            base.TakePizzaDetailsFromConsole();
            Console.WriteLine("Enter the cone type");
            Cone = Console.ReadLine();
        }
        public override string ToString()
        {
            return base.ToString()+
                "\n Cone "+Cone;
        }
    }
}
