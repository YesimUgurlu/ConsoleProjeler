using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject16
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                string cikis = "";
                try
                {
                    double not1;
                    double not2;
                    double ort;
                   
                   
                    do
                    {
                        Console.Write("1. yazılı notunuzu giriniz: ");
                        not1 = Convert.ToDouble(Console.ReadLine());
                    } while (not1 > 100 || not1 < 0);
                    {
                        Console.WriteLine(" Yanlış not girildi. Çıkmak için Q harfine basınız.");
                    }
                    do
                    {
                        Console.Write("2. yazılı notunuzu giriniz: ");
                        not2 = Convert.ToDouble(Console.ReadLine());
                    } while (not2 > 100 || not1 < 0);
                    {
                        Console.WriteLine(" Yanlış not girildi. Çıkmak için Q harfine basınız.");
                    }
                    ort = (not1 + not2) / 2;

                    if (ort >= 50)
                    {
                        Console.WriteLine("Sınıfı geçtiniz! Çıkmak için Q harfine basınız.");
                        Console.ReadLine();
                    }
                    else if (ort < 50)
                    {
                        Console.WriteLine("Sınıfta kaldınız! Çıkmak için Q harfine basınız.");
                        Console.ReadLine();
                    }
                }
                catch (FormatException nesne)
                {

                    Console.WriteLine("Lütfen sadece sayı giriniz. " + nesne.Message);
                    Console.ReadLine();
                }
                if (cikis == "Q" || cikis == "q")
                {
                    return;
                }
            } while (true);
            
        }
    }
}
