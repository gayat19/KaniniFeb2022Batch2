using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstndingClassApp
{

    //Inside class all members by default are private
    class Pizza
    {
        public static int staticnumber;
        public  int instancenumber;
        public void PrintNumbers()
        {
            Console.WriteLine("Static numebr "+staticnumber);
            Console.WriteLine("Instance numebr " + instancenumber);
        }
        //string name;
        double price;
        //string description;
        //public string Name
        //{
        //    get
        //    {
        //        return name;
        //    }
        //    set
        //    {
        //        name = value;
        //    }
        //}
 
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value+(value*12/100);
            }
        }
        public void PrintPizzzaDetails()
        {
            Console.WriteLine("Pizza Name "+Name);
            Console.WriteLine("Priza Price "+price);
        }
    }
}
