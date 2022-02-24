using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class InValidNumberException : Exception
    {
        string message;
        public InValidNumberException()
        {
            message = "Invalid entry for number. Number cannot be negative";
        }
        public InValidNumberException(int num)
        {
            message = "Invalid entry for number. Number cannot be negative "+num;
        }
        public InValidNumberException(int num,string msg)
        {
            message = msg+" " + num;
        }
        public override string Message => message;//Lambda Expression
        
    }
}
