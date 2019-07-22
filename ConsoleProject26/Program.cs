using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject26
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 1;
            int adet = 0;
            do
            {
                try
                {
                    Console.WriteLine("Kaç adet Fibonacci sayısı gireceksiniz");
                    adet = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < adet; i++)
                    {
                        int c = a + b;
                        Console.WriteLine(c + " ");
                        Console.Write("Sayıların toplamı: " + (a + b + c));
                        a = b;
                        b = c;
                        continue;
                    }
                }
                catch (FormatException nesne)
                {
                    Console.WriteLine();
                    Console.WriteLine("Lütfen sadece sayı giriniz " + nesne.Message);
                }
            } while (true);
            Console.ReadLine();
        }
    }
}
