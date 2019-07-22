using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject1
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Birinci Scope (Blok)
            //int a = 20;
            //Console.WriteLine(a);
            ////Console.ReadLine();
            ////Console.ReadKey();
            //Console.Read();

            string isim =  " ";
            string soyIsim = " ";

            Console.WriteLine("Lütfen İsminizi Giriniz. ");
            isim = Console.ReadLine();

            Console.WriteLine("Lütfen Soyisminizi Giriniz. ");
            soyIsim = Console.ReadLine();

            string adSoyad;

            adSoyad = isim + " \\ Merhaba \\ " + soyIsim; // karakterinin metin içinde gözükmesi için \ kullan
            Console.WriteLine(adSoyad);

            adSoyad = isim + " \\" + "Merhaba" +  "\\ " + soyIsim; // karakterinin metin içinde gözükmesi için \ kullan
            Console.WriteLine(adSoyad);

            adSoyad = isim + " " + "(" + soyIsim + ")";
            Console.WriteLine(adSoyad);

            //Console.WriteLine("Hoşgeldin " + isim + " " + soyIsim);
            Console.ReadLine();
        }
    }
    class Program2
    {

    }
}
