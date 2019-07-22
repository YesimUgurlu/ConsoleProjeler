using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject04
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = 350;
            Console.WriteLine("INT gösteriliyor");
            Console.WriteLine(sayi);
            Console.WriteLine("");


            /*Bir alt satırdaki conversion explicit bir conversion'dır. Fakat Uygun Değildir.
            Çünkü büyük veri tipi daha küçük bir veri tipine dönüştürülmek istenmiştir. 
            Bu durum veri kaybına yol açacağı için hata vermiştir.
            Ama bilinçli bir çevirim söz konusu ise bu durum "explicit conversion" ile çözülebilir.*/
            //byte sayiByte = (byte)sayi;
            byte sayiByte = (byte)sayi;
            Console.WriteLine("INT to Byte gösteriliyor");
            Console.WriteLine(sayiByte);
            Console.WriteLine("");

            long sayiLong = sayi;
            Console.WriteLine("INT to Long gösteriliyor");
            Console.WriteLine(sayiLong);
            Console.WriteLine("");

            double x = 1234.7;
            int a1;
            int a2;
            // double to int

            a1 = (int)x; //truncate double (virgülden sonrasını atıyor. Yuvarlamıyor.
            Console.WriteLine("Double to Int gösteriliyor.");
            Console.WriteLine(a1);
            Console.WriteLine("");

            a2 = Convert.ToInt32(x); //Burada yuvarlama yaparak o şekilde int'e çeviriyor.
            Console.WriteLine("Double to Int Conversion gösteriliyor");
            Console.WriteLine(a2);
            Console.WriteLine("");

            Console.Beep(300, 3000);//Sistem 3000 milisaniye boyunca bip sesi çıkardıktan sonra kapanacak.(3 Saniye)
            System.Threading.Thread.Sleep(3000); //3000 milisaniye açık kaldıktan sonra kapanacak.(3 Saniye)
            //Bu durumda sistem toplam 6 saniye sonra kapanır...

            //Console.ReadLine();
        }
    }
}
