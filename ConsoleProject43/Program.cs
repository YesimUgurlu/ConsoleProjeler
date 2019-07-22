using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject43
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> d = new Dictionary<int, string>();
            d.Add(1, "a");
            d.Add(2, "b");
            d.Add(3, "c");
            d.Add(4, "d");
            Console.WriteLine(d.ElementAt(2));
            Console.ReadLine();

            d.Remove(2);
            Console.WriteLine(d.ElementAt(2));
            Console.ReadLine();

            d.Add(3, "cccc");
            Console.WriteLine(d.ElementAt(2));
            Console.ReadLine();
            return;
        }
    }
}
