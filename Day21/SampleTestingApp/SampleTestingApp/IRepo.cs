using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleTestingApp
{
    public interface IRepo<K,T>
    {
        T Add(T item);
        T Remove(K id);
        ICollection<T> GetAll();
    }
}
