using System;
using System.Collections.Generic;
using System.Collections.Generic;

namespace MyDictionaryTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyOperatingSystems<string> operatingSystems = new MyOperatingSystems<string>();
            operatingSystems.Add("Windows");
            operatingSystems.Add("Linux");
            operatingSystems.Add("Android");
            operatingSystems.Add("MacOs");
            //Console.WriteLine(operatingSystems.Count);
        }
    }

    class MyOperatingSystems<T>
    {
        T[] _array;
        T[] _tempArray;

        public MyOperatingSystems()
        {
            _array = new T[0];
        }

        public void Add(T item)
        {
            _tempArray = _array;
            _array = new T[_array.Length + 1];
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }

            _array[_array.Length - 1] = item;
        }

        public int Count
        {
            get { return _array.Length; }
        }

    }
}