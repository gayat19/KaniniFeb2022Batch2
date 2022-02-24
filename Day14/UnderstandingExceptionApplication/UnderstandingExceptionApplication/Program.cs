using Calculator;
using System;
using System.Diagnostics;

namespace UnderstandingExceptionApplication
{ 
    class Program
    {
       void MyDivide()
        {
            try
            {
                Calc c = new Calc();
                double res = c.Divide();
                Console.WriteLine($"The result is {res}");
            }
            catch (InValidNumberException ivne)
            {
                Debug.WriteLine(ivne.Message + " " + DateTime.Now.ToLongDateString());
                Debug.WriteLine(ivne.StackTrace);
                Debug.WriteLine("-------------------");
                Console.WriteLine("Numerator cannot be negative");
            }
            catch (DivideByZeroException dbz)
            {
                //Console.WriteLine(dbz.Message);
                //Console.WriteLine(dbz.StackTrace);
                Debug.WriteLine(dbz.Message + " " + DateTime.Now.ToLongDateString());
                Debug.WriteLine(dbz.StackTrace);
                Debug.WriteLine("-------------------");
                Console.WriteLine("Denominator cannot be zero");
            }
            
            catch (FormatException fe)
            {
                Debug.WriteLine(fe.Message + " " + DateTime.Now.ToLongDateString());
                Debug.WriteLine(fe.StackTrace);
                Debug.WriteLine("-------------------");
                //Console.WriteLine(fe.Message);
                Console.WriteLine("Invalid entry for number");
            }
            catch (Exception e)
            {
                Console.WriteLine("oops something went wrong!!!!");
            }
            finally
            {
                Console.WriteLine("Will execute always");
            }
            
        }
        static void Main(string[] args)
        {
           Program program = new Program();
           program.MyDivide();
           Console.ReadKey();
        }
    }
}
