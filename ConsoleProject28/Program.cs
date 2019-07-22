using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject28
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int sayi = 0;
            int carpim = 1;
            do
            {
                try
                {
                    Console.WriteLine("Faktoriyeli hesaplanacak sayıyı giriniz");
                    sayi = Convert.ToInt32(Console.ReadLine());
                    if (sayi == 0)
                    {
                        Console.Write("0 sayısının faktöriyeli 1 ' dir.");
                    }
                    for (i = 1; i <= sayi; i++)
                    {
                        Console.WriteLine("{0} sayısının faktoriyeli {1}", sayi, carpim);
                    }
                    
                    Console.ReadLine();
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
