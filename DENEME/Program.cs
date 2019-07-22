using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject10
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                if (Console.ReadKey().Key == ConsoleKey.Q)
                {
                    Console.WriteLine("Çıkış yaptınız Q ya bastınız");
                    Console.ReadLine();
                }
                else if (Console.ReadKey().Key != ConsoleKey.Q)
                {
                    try
                    {
                        Console.WriteLine("Lütfen Bir Sayı Giriniz: ");
                        int ans = Convert.ToInt32(Console.ReadLine());
                        Console.Write("3000 / " + ans + " = ");
                        Console.WriteLine(3000 / ans);
                        Console.WriteLine("İşlem başarılı bir şekilde sonuçlandı !");
                    }
                    catch (DivideByZeroException nesne)
                    {
                        Console.WriteLine("Sayı Sıfıra Bölünemez !" + nesne.Message + "Kaynak: " + nesne.Source);
                    }
                    catch (Exception nesne) //bu blok en sonra olmalı
                    {
                        Console.WriteLine("Hata Var !" + nesne.Message);
                    }
                    finally
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("Programdan çıkmak için 'Q' harfine basınız. Devam etmek için Enter'a basınız.");
                        Console.WriteLine(" ");
                    }
                }
            } while (Console.ReadKey().Key != ConsoleKey.Q);

            Console.ReadLine();
        }
    }
}