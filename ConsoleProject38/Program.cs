using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject38
{
    class Program
    {
        //Kullanıcı alacağı paraüstünü girsin
        //Para üstü veren makinada sadece 2,5 ve 10'luk banknotlar bulunmaktadır
        // Kullanıcıya en az adet banknot ile paraüstü veren uygulamayı yazınız
        //Eğer kullanıcı para üstü olarak direkt 1 veya 3 yazarsa sistem uyarı mesajı versin
        static void Main(string[] args)
        {
            int onlukAdedi;
            int beslikAdedi;
            int ikilikAdedi;
            int kalan;
            int paraUstu;

            Console.WriteLine("Lütfen para üstü giriniz");
            paraUstu= Convert.ToInt32(Console.ReadLine());

            onlukAdedi = paraUstu / 10;
            paraUstu = paraUstu % 10;

            beslikAdedi = paraUstu / 5;
            paraUstu = paraUstu % 5;

            ikilikAdedi = paraUstu / 2;
            paraUstu = paraUstu % 2;

            kalan = paraUstu;

            if (kalan > 0)
            {
                if (beslikAdedi > 0)
                {
                    int ekIkilikAdedi;
                    beslikAdedi--;
                    ekIkilikAdedi = (5 + kalan) / 2;
                    ikilikAdedi = ikilikAdedi + ekIkilikAdedi;
                    kalan = 0;
                }
                else
                {
                    if (onlukAdedi > 0)
                    {
                        int ekIkilikAdedi;
                        onlukAdedi--;
                        beslikAdedi--;
                        ekIkilikAdedi = (5 + kalan) / 2;
                        ikilikAdedi = ikilikAdedi + ekIkilikAdedi;
                        kalan = 0;
                    }
                    else
                    {
                        Console.WriteLine("Lütfen 1 veya 3 dışında bir para üstü giriniz");
                        Console.ReadLine();
                        return;
                    }
                }
            }
            Console.WriteLine("Onluk adet sayısı =" + onlukAdedi);
            Console.WriteLine("Beslik adet sayısı =" + beslikAdedi);
            Console.WriteLine("İkilik adet sayısı =" + ikilikAdedi);
            Console.WriteLine("kalan =" + kalan);
            Console.ReadLine();
        
        }
    }
}
