using System;
using System.Collections.Generic;
using System.Linq;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(2, "elma");
            myDictionary.Add(3, "portakal");
            myDictionary.Add(5, "mandalina");
            myDictionary.Add(7, "nar");
            myDictionary.List();
            MyDictionary<int, char> kalemList = new MyDictionary<int, char>();
            kalemList.Add(1, 'a');
            kalemList.Add(2, 'b');
            kalemList.Add(3, 'c');
            kalemList.Add(4, 'd');
            kalemList.List();
            Console.WriteLine(myDictionary.Count);
            foreach (var item in kalemList.OnlyGetKeys)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(kalemList.ContaninsKeys(2));
            Console.WriteLine(kalemList.ContaninsValues('e'));
            kalemList.Remove(3);
            kalemList.List();
            Console.WriteLine();
            kalemList.Clear(1, 1);
            kalemList.List();
            Console.WriteLine(kalemList.Count);
            kalemList.KeysList();
            kalemList.ValuesList();
           bool ValueBul= kalemList.TryGetValue(1,out char c);
            Console.WriteLine(ValueBul);
        }
    }
    }






