using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    class MyDictionary<K,V>
    {
        TKey[] _keys;
        TValue[] _value;
        public MyDictionary()
        {
            _keys = new K[0];
            _value = new V[0];
        }

        public void MyDictionary.Add(TKey key, TValue value);


    }
}
