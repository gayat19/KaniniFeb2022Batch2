﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsumeAPIApp.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public float Salary { get; set; }
        public override bool Equals(object obj)
        {
            return (this.Id.Equals(((Employee)obj).Id));
        }
    }
}
