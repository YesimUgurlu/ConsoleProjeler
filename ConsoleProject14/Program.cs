using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject14
{
    class Program
    {
        static void Main(string[] args)
        {
            //int toplam = 0;
            //for (int i = 100; i > 0; i--)
            //{
            //    toplam = toplam + i;
            //}
            //Console.WriteLine(toplam);
            //Console.Read();

            int sayiAdedi = 0;
            int toplam = 0;

            for (int i = 0; i <= 1000; i++)
            {
                if (i % 5 == 0 && i % 7 != 0)
                {
                    toplam = toplam + i;
                    sayiAdedi++; //adet=adet+1
                }
            }
            Console.WriteLine(toplam);
            Console.WriteLine(sayiAdedi);

            Console.ReadLine();
        }
    }
}
