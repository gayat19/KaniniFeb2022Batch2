using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingCollectionApplication
{
    class Employee : IComparable<Employee>
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public int CompareTo(Employee other)
        {
            return this.Salary.CompareTo(other.Salary);
        }

        public override string ToString()
        {
            return Id + "\t" + Name + "\t" + Salary;
        }
    }
}
