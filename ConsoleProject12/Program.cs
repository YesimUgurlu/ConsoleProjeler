using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject12
{
    class Program
    {
        static void Main(string[] args)
        {
            int gunler =1;
            do
            {
                try
                {
                    Console.WriteLine();
                    Console.WriteLine("***************");
                    Console.WriteLine("Lütfen 0 ile 7 arasında bir değer girin.");
                    gunler = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();

                    switch (gunler)
                    {
                        case 1: Console.WriteLine("1. Gün PAZARTESİ"); break;
                        case 2: Console.WriteLine("2. Gün SALI"); break;
                        case 3: Console.WriteLine("3 Gün ÇARŞAMBA"); break;
                        case 4: Console.WriteLine("4. Gün PERŞEMBE"); break;
                        case 5: Console.WriteLine("5. Gün CUMA"); break;
                        case 6: Console.WriteLine("6. GÜn CUMARTESİ"); break;
                        case 7: Console.WriteLine("7. Gün PAZAR"); break;
                        default: Console.WriteLine("Lütfen 1-7 arasında bir sayı giriniz."); continue;
                    }

                }
                catch (System.FormatException nesne)
                {
                    Console.WriteLine();
                    Console.WriteLine("Lütfen sadece 1 ve 7 arasında sayı giriniz. " + nesne.Message);
                    continue;
                }
            } while (true);
        }
    }
}