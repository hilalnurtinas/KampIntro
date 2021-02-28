using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionaryDemo
{
    class MyDictionary<Tkey, Tvalue>
    {
        Tkey[] keys;
        Tvalue[] values;
        Tkey[] tempKeys;
        Tvalue[] tempValue;

        public MyDictionary()
        {
            keys = new Tkey[0];
            values = new Tvalue[0];
        }
        public void Add(Tkey tkey, Tvalue tvalue)
        {
            tempKeys = keys;
            tempValue = values;
            keys = new Tkey[keys.Length + 1];
            values = new Tvalue[values.Length + 1];
            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
            }
            for (int j = 0; j < tempValue.Length; j++)
            {
                values[j] = tempValue[j];
            }
            keys[keys.Length - 1] = tkey;
            values[values.Length - 1] = tvalue;


        }
        public void List()
        {
            for (int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine("Number: " + keys[i] + "  " + "Name:" + values[i]);
            }
        }


    }
}
