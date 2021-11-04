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
            LinkedList<string> linkedList = new();
            linkedList.AddFirst("1");
            Console.WriteLine("Total");
            Console.WriteLine(linkedList.Count());
            linkedList.AddFirst("7");
            linkedList.AddFirst("3");
            linkedList.AddFirst("4");
            linkedList.AddFirst("5");
            linkedList.AddFirst("24");
            linkedList.AddFirst("15");
            Console.WriteLine("Total");
            Console.WriteLine(linkedList.Count());
            linkedList.RemoveFirst();
            Console.WriteLine("Total");
            Console.WriteLine(linkedList.Count());

            Console.WriteLine("Printing");
            linkedList.AddFirst("15");
            linkedList.Print(Print);

            linkedList.Sort(Sort);
            Console.WriteLine("Printing sorted");

            linkedList.Print(Print);

            //linkedList = new();
            //Thread.Sleep(5000);

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
