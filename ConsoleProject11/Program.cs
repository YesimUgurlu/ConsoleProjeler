using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject11
{
    class Program
    {
        static void Main(string[] args)
        {
            double sinav1 = 0;
            double sinav2 = 0;
            double ortalama;

            while (sinav1 <= 100 && sinav1 >= 0 && sinav2 <= 100 && sinav2 >= 0)
            {
                Console.WriteLine("************************************");
                Console.WriteLine("Lütfen 1. ve 2. sınav notlarını sırasıyla giriniz.");
                try
                {
                    do
                    {
                        Console.WriteLine("1. yazılı notunu giriniz: ");
                        sinav1 = Convert.ToDouble(Console.ReadLine());

                        if (sinav1 > 100 || sinav1 < 0)
                        {
                            Console.WriteLine("Sınav notu 0 ile 100 arasında olmalıdır.");
                            Console.ReadLine();
                        }

                        Console.WriteLine();

                    } while (sinav1 > 100 || sinav1 < 0);

                    do
                    {
                        Console.WriteLine("2. yazılı notunu giriniz: ");
                        sinav2 = Convert.ToDouble(Console.ReadLine());

                        if (sinav2 > 100 || sinav2 < 0)
                        {
                            Console.WriteLine("Sınav notu 0 ile 100 arasında olmalıdır.");
                            Console.ReadLine();
                        }

                        Console.WriteLine();

                    } while (sinav2 > 100 || sinav2 < 0);

                    ortalama = (sinav1 + sinav2) / 2;
                    Console.WriteLine("Ortalamanız = " + ortalama);

                    if (ortalama < 25)
                    {
                        Console.WriteLine("5'lik sistemde notunuz = 0");
                    }
                    else if (ortalama >= 25 && ortalama < 45)
                    {
                        Console.WriteLine("5'lik sistemde notunuz = 1");
                    }
                    else if (ortalama >= 45 && ortalama < 55)
                    {
                        Console.WriteLine("5'lik sistemde notunuz = 2");
                    }
                    else if (ortalama >= 55 && ortalama < 70)
                    {
                        Console.WriteLine("5'lik sistemde notunuz = 3");
                    }
                    else if (ortalama >= 70 && ortalama < 85)
                    {
                        Console.WriteLine("5'lik sistemde notunuz = 4");
                    }
                    else
                    {
                        Console.WriteLine("5'lik sistemde notunuz = 5");
                    }

                }
                catch (System.FormatException nesne)
                {
                    Console.WriteLine();
                    Console.WriteLine("Lütfen sadece sayı giriniz. " + nesne.Message);
                    continue;
                }

            }

            Console.ReadLine();
        }
    }
}
