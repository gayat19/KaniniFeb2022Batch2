using System;

namespace UnderstandingMoreOnClass
{
    class Program
    {
        void CreatePizza()
        {
            Pizza pizza = new Pizza();
            pizza.Id = 101;
            //pizza.Name = "XYZ";
            pizza.Price = 12.4;
            pizza.Desc = "blahblah blah";
            pizza[0] = "Olives";
            pizza[1] = "Onions";
            pizza[2] = "Cheese";
            //pizza.PrintPizzaDetails();
            //pizza.Bake(12.4);
            Console.WriteLine("The first topping is "+pizza[0]);
            Console.WriteLine($"The topping onnion is in the {pizza["Onions"]} index");
            Pizza pizza2 = new Pizza(102, "Anything", 34, "New Piza");
            pizza2[0] = "Jalapinos";
            Pizza p3 = pizza + pizza2;//????
            p3.PrintPizzaDetails();
            //int num1 = 100, num2 = 90;
            //int sum = num1 + num2;
        }
        static void Main(string[] args)
        {
            //Program program = new Program();
            //program.CreatePizza();
            Menu menu = new Menu();
            menu.PrintMenu();
            Console.ReadKey();
        }
    }
}
