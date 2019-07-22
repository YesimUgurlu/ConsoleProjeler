using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleProject21
{
    class Program
    {
        static void Main(string[] args)
        {
            //1- Sayma işleminin 1'den başlayarak 100'e kadar birer birer devam ettirilmesi, 5 ve 5'in katlarına gelindiğinde ekrana sayı yerine 
            //BOM yazdırılması (Thread.Sleep(500) kullanabilirsiniz.)

            //2- Kendisine ve katlarına gelindiğinde BOM denilecek olan sayının Console ekrarınından kullanıcı tarafından girilmesinin istenmesi,
            //oyundaki sayma işleminin bu girilen sayıya göre doğru şekilde ekrana yazdırılması

            //3- BOM denilecek sayının aynı şekilde kullanıcı tarafından girilmesinin ardından oyunun bilgisayar tarafından başlatılması, sırayla
            //kullanıcı ve bilgisayar arasında devam ettirilmesi

            //NOT: Aşama 3'te BOM sırası kullanıcıya geldiğinde ekrandan BOM yerine sayı girilirse kullanıcı oyunu kaybeder.
            // Bilgisayar oyunu karar yapılarına dayalı olarak oynayacağından kaybetmesi durumu göz önüne alınmayacaktır. Oyun 100'e kadar devam 
            //ettirilecek olup kullanıcının kaybetmemiş olması durumunda beraberlik durumu geçerli olacaktır ve ekrana " OYUN BERABERE" yazdırılmalıdır.

            //1.Aşama
            //int i;
            //for (i = 1; i <= 100; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine("BOM");
            //        continue;
            //    }
            //    Console.WriteLine(i);
            //    Thread.Sleep(500);
            //}
            //Thread.Sleep(500);
            //Console.ReadLine();

            //2.Aşama
            //int bom;
            //int i;
            //Console.Write("BOM denilecek sayıyı giriniz: ");
            //bom = Convert.ToInt32(Console.ReadLine());
            //for (i = 1; i <= 100; i++)
            //{
            //    Thread.Sleep(500);
            //    if (i % bom == 0)
            //    {
            //        Console.WriteLine("BOM");
            //        continue;
            //    }
            //    Console.WriteLine(i);
            //}
            //Console.ReadLine();

            //3. Aşama
            int katsayiBom;
            int pc =1;
            int kullanici;
            Console.Write("BOM denilecek sayıyı giriniz: ");
            katsayiBom = Convert.ToInt32(Console.ReadLine());
           
            //kullanici = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 100; i++)
            {
                
                Thread.Sleep(500);
                if (pc % katsayiBom == 0)
                {
                    Console.WriteLine("Bilgisayar: BOM");
                }
                else
                {
                    Console.WriteLine("Bilgisayar: " + pc);
                }
                Console.Write("SİZ: ");

                if ((pc + 1) % katsayiBom ==0)
                {
                    string bom = Console.ReadLine().ToUpper();
                    if (bom != "BOM")
                    {
                        Console.WriteLine("HATALI!!");
                    }
                    else
                    {
                        pc= pc +2;
                    }
                }
                else
                {                 
                    kullanici = Convert.ToInt32(Console.ReadLine());
                    if (kullanici != (pc + 1))
                    {
                        Console.WriteLine("HATALI!!");
                        return;
                    }
                    else
                    {
                        pc = pc+ 2;
                    }
                    i++;
                }
                
                
               
            }
            Console.ReadLine();
        }
    }
}
