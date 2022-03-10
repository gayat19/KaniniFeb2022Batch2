using ModelsLibrary;
using MyDALibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBLibrary
{
    public class ProductRepo : IRepo<string, Product>
    {

        List<Product> products;
        public Product Add(Product item)
        {
            throw new NotImplementedException();
        }

        public Product Get(Product item)
        {
            var product = GetAll().SingleOrDefault(p => p.Name == item.Name);
            return product;
        }

        public virtual ICollection<Product> GetAll()
        {
            products = new ProductDAL().GetAllProducts().ToList();
            return products;
        }
    }
}
