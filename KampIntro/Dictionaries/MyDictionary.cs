using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
    public class MyDictionary<TKey,TValue>
    {

       private Dictionary<TKey, TValue> myDictionary;

        public MyDictionary()
        {
            this.myDictionary = new Dictionary<TKey, TValue>();
        }


        public void Add(TKey key, TValue value)
        {
            this.myDictionary.Add(key, value);
        }


        public Dictionary<TKey, TValue> GetAll() { 
        
        return this.myDictionary;
        }

    }
}
