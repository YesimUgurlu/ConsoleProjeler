using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject20
{
    class Program
    {
        static void Main(string[] args)
        {
            //Klavyeden iki ürünün fiyatı ayrı ayrı girildiğinde iki ürünün toplam fiyatı 200 liradan fazla ise ikinci üründen %25 indirim yaparak
            //iki ürün için toplam ödenecek tutarı gösteren uyg yapınız.

            double urunFiyat1, urunFiyat2, toplamFiyat;

            Console.WriteLine("İlk ürünün fiyatını giriniz: ");
            urunFiyat1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("İkinci ürünün fiyatını giriniz: ");
            urunFiyat2 = Convert.ToInt32(Console.ReadLine());

            toplamFiyat = urunFiyat1 + urunFiyat2;

            if(toplamFiyat >= 200)
            {
                Console.WriteLine("Toplam indirim = " + urunFiyat2 * 0.25);
                urunFiyat2 = urunFiyat2 * 0.75;
                toplamFiyat = urunFiyat1 + urunFiyat2;
            }
            else
            {
                Console.WriteLine("Toplam indirim = 0");
            }
            Console.WriteLine("İki ürünün toplam fiyatı = " + toplamFiyat);
            Console.ReadLine();
        }
    }
}
