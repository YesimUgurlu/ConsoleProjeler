using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject09
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1;
            int sayi2;
            int fark = 0;

            Console.WriteLine("1. Sayıyı Giriniz. ");
            sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2. Sayıyı Giriniz. ");
            sayi2 = Convert.ToInt32(Console.ReadLine());

            if (sayi1 > sayi2)
            {
                Console.WriteLine(fark);
                fark = ((sayi1 * 2) - sayi2);
            }
            else
            {
                Console.WriteLine(fark);
                fark = ((sayi2 * 2) - sayi1);
            }

            Console.ReadLine();
        }
    }
}
