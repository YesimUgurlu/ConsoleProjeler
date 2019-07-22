using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProjectParaustu
{
    class Program
    {
        static void Main(string[] args)
        {
            int borc;
            int yatırılanpara;
            int paraustu;
            int adet;
            int kalan;

            Console.WriteLine("Lütfen ödemeniz gereken borcu giriniz:");
            borc = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lütfen ödediğiniz tutarı giriniz: ");
            yatırılanpara = Convert.ToInt32(Console.ReadLine());

            paraustu = yatırılanpara - borc;
            Console.WriteLine("Para üzeriniz: " + paraustu);
            Console.ReadLine();

            if (paraustu == 2 || paraustu < 5)
            {
                adet = paraustu / 2;
                Console.WriteLine("Alacağınız paraüstündeki 2 TL adedi:" + adet);
                kalan = paraustu % 2;
                kalan = paraustu;
            }
            else if (paraustu == 5 || paraustu < 10)
            {
                adet = paraustu / 5;
                Console.WriteLine("Alacağınız paraüstündeki 5 TL adedi:" + adet);
                kalan = paraustu % 2;
                kalan = paraustu;

            }
            else if (paraustu == 10 || paraustu > 10)
            {
                adet = paraustu / 10;
                Console.WriteLine("Alacağınız paraüstündeki 10 TL adedi:" + adet);
                kalan = paraustu % 5;
                kalan = paraustu;

            }
            else
            {
                Console.WriteLine("Üzgünüz.. Kalan 1 TL nizi veremiyoruz:");
            }
            Console.ReadLine();



        }
    }
}
