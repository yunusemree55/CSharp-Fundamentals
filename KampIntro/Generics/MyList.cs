using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class MyList<T>
    {
        private List<T> list = new List<T>();

        public void Add(T item)
        {
            list.Add(item);
        }

        public void Delete(int index)
        {
            list.RemoveAt(index);
        }

        public List<T> GetAll() 
        { 
            return list;
        
        }

        public int Length()
        {
            return list.Count;
        }
    }
}
