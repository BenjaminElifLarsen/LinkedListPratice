using LinkedList;
using System;
using System.Linq;
using System.Threading;

namespace Cli
{
    class Program
    {
        static void Main(string[] args)
        {
            FiLo<string> linkedList = new();
            linkedList.Add("1");
            Console.WriteLine("Total");
            Console.WriteLine(linkedList.Count());
            linkedList.Add("7");
            linkedList.Add("3");
            linkedList.Add("4");
            linkedList.Add("5");
            linkedList.Add("5");
            linkedList.Add("5");
            linkedList.Add("5");
            linkedList.Add("24");
            linkedList.Add("15T");
            linkedList.Add("T15");
            linkedList.Add("15");
            Console.WriteLine("Total");
            Console.WriteLine(linkedList.Count());
            linkedList.Remove();
            Console.WriteLine("Total");
            Console.WriteLine(linkedList.Count());

            Console.WriteLine("Printing");
            linkedList.Add("15");
            linkedList.Print(Print);

            linkedList.Sort(Sort);
            Console.WriteLine("Printing sorted");
            linkedList.Print(Print);

            Console.WriteLine("Got first value");
            Console.WriteLine(linkedList.GetValue());
            Console.WriteLine("Printing");
            linkedList.Print(Print);

            HashFiLo<int> l = new();
            l.Add(5);
            l.Add(5);
            l.Add(4);
            l.Add(5);
            l.Add(3);
            l.Add(6);
        }

        static bool Sort(string data, string data2)
        {
            return data.Sum(c => (double)c) > data2.Sum(c => (double)c);
        }

        static void Print<Type>(Type data)
        {
            Console.WriteLine(data);
        }
    }
}
