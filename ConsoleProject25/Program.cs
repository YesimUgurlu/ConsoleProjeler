using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject25
{
    class Program
    {
        static void Main(string[] args)
        {

            //int sayac = 1;
            //int adet;
            //int sayi;
            //int toplam = 0;
            //for (int i = 1, i<= adet , i++) ;
            //{
            //    Console.Write(i + ".Sayı :");
            //    Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine("Kaç adet sayı toplayacaksınız");
            //Console.ReadLine();
            //while (true)
            //{
            //    Console.WriteLine(" 1.sayıyı giriniz :");
            //    sayi = int.Parse(Console.ReadLine());
            //    sayac++;
            //    Console.ReadLine();
            //}
            //toplam = sayi1 + sayi2;

            //Console.WriteLine("Girilen iki sayının toplamı = {0}", toplam);
            int sayi;
            int adet = 0;
            int toplam = 0;
            int sayac = 1;
             Console.WriteLine("Kaç adet sayı toplayacaksınız");
            adet = Convert.ToInt32(Console.ReadLine());

            //
            Console.ReadLine();

            for (int i = 1; i <= adet; i++)
            {
                Console.Write(i + ". Sayı : ");
                sayi = Convert.ToInt32(Console.ReadLine());
                toplam = toplam + sayi;
            }
            Console.WriteLine("Toplam : " + toplam);
            Console.ReadKey();


           
        }  
    }
}
