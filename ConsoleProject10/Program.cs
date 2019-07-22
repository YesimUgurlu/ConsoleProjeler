using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CSharp.RuntimeBinder;

namespace ConsoleProject10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Deneme 1:
            //do
            //{
            //    try
            //    {
            //        Console.WriteLine("Lütfen Bir Sayı Giriniz: ");
            //        int ans = Convert.ToInt32(Console.ReadLine());
            //        Console.Write("3000 / " + ans + " = ");
            //        Console.WriteLine(3000 / ans);
            //        Console.WriteLine("İşlem başarılı bir şekilde sonuçlandı !");
            //    }
            //    catch (DivideByZeroException nesne)
            //    {
            //        Console.WriteLine("Sayı Sıfıra Bölünemez !" + nesne.Message + "Kaynak: " + nesne.Source);
            //    }
            //    catch (Exception nesne) //bu blok en sonra olmalı
            //    {
            //        Console.WriteLine("Hata Var !" + nesne.Message);
            //    }
            //    finally
            //    {
            //        Console.WriteLine(" ");
            //        Console.WriteLine("Programdan çıkmak için 'Q' harfine basınız. Devam etmek için Enter'a basınız.");
            //        Console.WriteLine(" ");
            //    }

            //} while (Console.ReadKey().Key != ConsoleKey.Q);

            //Console.ReadLine();

            //Deneme 2:
            //while (true)
            //{
            //    try
            //    {
            //        Console.WriteLine();
            //        Console.WriteLine("Lütfen Bir Sayı Giriniz veya çıkmak için \"q\" harfine basınız.");
            //        string girilenDeger = Console.ReadLine();
            //        if (girilenDeger == "Q" || girilenDeger == "q")
            //        {
            //            return;
            //        }
            //        int a = Int32.Parse(girilenDeger);
            //        Console.Write("3000 / " + a + " = ");
            //        Console.WriteLine(3000 / a);
            //        Console.WriteLine("İşlem başarılı bir şekilde sonuçlandı !");
            //    }
            //    catch (DivideByZeroException nesne)
            //    {
            //        Console.WriteLine("Sayı Sıfıra Bölünemez !" + nesne.Message + "Kaynak: " + nesne.Source);
            //    }
            //    catch (Exception nesne) //bu blok en sonra olmalı
            //    {
            //        Console.WriteLine("Hata Var !" + nesne.Message);
            //    }

            //Deneme 3:
            string girilenDeger = "";
            do
            {
                try
                {
                    Console.WriteLine();
                    Console.WriteLine("Lütfen Bir Sayı Giriniz veya çıkmak için \"q\" harfine basınız.");
                    girilenDeger = Console.ReadLine();

                    int a = Int32.Parse(girilenDeger);
                    Console.Write("3000 / " + a + " = ");
                    Console.WriteLine(3000 / a);
                    Console.WriteLine("İşlem başarılı bir şekilde sonuçlandı !");
                }
                catch (DivideByZeroException nesne)
                {
                    Console.WriteLine("Sayı Sıfıra Bölünemez !" + nesne.Message + "Kaynak: " + nesne.Source);
                }
                catch (Exception nesne) //bu blok en sonra olmalı
                {
                    if (girilenDeger != "Q" && girilenDeger != "q")
                    {
                        Console.WriteLine("Hata Var !" + nesne.Message);
                    }
                }
            }
            while (girilenDeger != "Q" && girilenDeger != "q");
            {

            }
        }
    }
}