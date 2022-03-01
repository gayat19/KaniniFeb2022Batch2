using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOModelsLibrary
{
    public class Product
    {
        //Id,Name, QuantityPerUnit, UnitPrice, Stock
        public int Id { get; set; }
        public string Name { get; set; }
        public string QuantityPerUni { get; set; }
        public float UnitPrice { get; set; }
        public int Stock { get; set; }

    }
}
