using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject13
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıya kaçıncı ayda olduğunu sorarak hangi mevsimde bulunduğunu gösteren console uygulamasını yazınız.

            string girilenDeger = "";

            do
            {
                try
                {
                    Console.WriteLine();
                    Console.WriteLine("***************");
                    Console.WriteLine("Kaçıncı ayda olduğunuzu giriniz. Çıkış için Q");
                    girilenDeger = Console.ReadLine();

                    int ay = Int32.Parse(girilenDeger);
                    if (girilenDeger == "q" || girilenDeger=="Q")
                    {
                        return;
                    }
                    else
                    {
                        Console.WriteLine();

                        switch (ay)
                        {
                            case 12:
                            case 1:
                            case 2:
                                Console.WriteLine("KIŞ Mevsimi"); break;
                            case 3:
                            case 4:
                            case 5:
                                Console.WriteLine("İlkbahar Mevsimi"); break;
                            case 6:
                            case 7:
                            case 8:
                                Console.WriteLine("YAZ Mevsimi"); break;
                            case 9:
                            case 10:
                            case 11:
                                Console.WriteLine("SONBAHAR Mevsimi"); break;

                            default: Console.WriteLine("Yanlış Ay Girişi Yaptınız"); continue;
                        }

                    }

                }
                catch (System.FormatException nesne)
                {
                    Console.WriteLine();
                    Console.WriteLine("Lütfen sadece 1 ve 7 arasında sayı giriniz. " + nesne.Message);
                    continue;
                }
                catch (Exception nesne)
                {
                    Console.WriteLine();
                    Console.WriteLine("Hata oluştu: " + nesne.Message);
                    continue;
                }
            } while (true);

        }
    }
}
