using MyDictionaryDemo;
using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> student = new MyDictionary<int, string>();
            student.Add(20, "Hilal");
            student.Add(35, "İkbal");
            student.Add(11, "Ali");
            student.Add(42, "Hasan");

            student.List();


        }
    }
}

