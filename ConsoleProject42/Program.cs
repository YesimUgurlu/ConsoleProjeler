using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace ConsoleProject42

{

    class Program

    {

        public enum DersKodlari

        {

            MSWORD = 100,

            MSEXCEL = 111,

            MSPOWERPOINT = 222,

            MSOUTLOOK = 333

        }

        static void Main(string[] args)

        {

            while (true)

            {



                Console.WriteLine("Lütfen W, E, P, O harflerinden birini giriniz.");

                char c = Convert.ToChar(Console.ReadLine().ToUpper());

                int dersSaati = 0;

                int s = HarfeGoreDersBelirle(c);

                if (s == (int)DersKodlari.MSWORD)

                    dersSaati = 10;

                else if (s == 111)

                    dersSaati = 30;

                else if (s == 222)

                    dersSaati = 5;

                else if (s == 333)

                    dersSaati = 15;

                else

                {

                    dersSaati = 0;

                    continue;

                }

                Console.WriteLine(s + " dersinin haftalık ders saati = " + dersSaati);

                Console.ReadLine();

            }

        }

        public static int HarfeGoreDersBelirle(char dersHarfi)

        {

            string dersAdi = "";

            int dersKodu = 0;

            if (dersHarfi == 'W')

            {

                dersAdi = "MSWORD";

                dersKodu = (int)DersKodlari.MSWORD;

            }

            else if (dersHarfi == 'E')

            {

                dersAdi = "MSEXCEL";
                dersKodu = (int)DersKodlari.MSEXCEL;


            }

            else if (dersHarfi == 'P')

            {

                dersAdi = "MSPOWERPOINT";

                dersKodu = (int)DersKodlari.MSPOWERPOINT;

            }

            else if (dersHarfi == 'O')

            {
                dersAdi = "MSOUTLOOK";
                dersKodu = (int)DersKodlari.MSOUTLOOK;
            }
            else
                Console.WriteLine("Geçerli bir harf girmediniz!");
            if (dersAdi != "")
                Console.WriteLine(dersAdi);
            return dersKodu;

        }

    }

}