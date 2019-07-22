using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject03
{
    class Program
    {
        static void Main(string[] args)
        {
            //int sayi1;
            //int sayi2;
            //int bolum;

            //Giris:
            //Console.Write("Lütfen Birinci Sayıyı Giriniz: ");
            //sayi1 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Lütfen İkinci Sayıyı Giriniz: ");
            //sayi2 = Convert.ToInt32(Console.ReadLine());

            //if (sayi2 == 0)
            //{
            //    Console.WriteLine("Bölüm 0 Olamaz !");
            //    Console.ReadKey();
            //    goto Giris;
            //}

            //else
            //{
            //    bolum = sayi1 / sayi2; //bölüm değişkeni tanımlandı. Bölme işleminin nasıl olacağı gösterildi.

            //    Console.WriteLine("*** BÖLÜM ***");
            //    Console.Write("Bölüm işleminin Sonucu: " + bolum);
            //    Console.Read();
            //}

            Console.WriteLine("Lütfen Bİrinci sayıyı giriniz ( Bölünen )");
            string sayi1 = Console.ReadLine();

            int sayiBolunen;
            try
            {
               sayiBolunen = Convert.ToInt32(sayi1);
                //ya da int sayiBolunen = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("girmiş olduğunuz ilk değer düzgün değil");
                Console.ReadLine();
                return;
            }
            finally
            {
                //Console.WriteLine("Sizi tekrar aramızda görmek isteriz Ali Saraç");
                //Console.ReadLine();
            }

            Console.Write("Lütfen İkinci sayıyı giriniz ( Bölen )");
            string sayi2 = Console.ReadLine();

            int sayiBolen;
            try
            {
              sayiBolen = Convert.ToInt32(sayi2);
                //ya da int sayiBolen = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("girmiş olduğunuz ilk değer düzgün değil");
                Console.ReadLine();
                return;
            }
            finally
            {
                //Console.WriteLine("Sizi tekrar aramızda görmek isteriz Mert Çakmak");
                //Console.ReadLine();
            }

            Console.WriteLine("İki sayının birbirine bölümünün sonucu");

            // int/int sonucu fractional part'ı attığı yani küsüratı kestiği için->
            //Sonuç int olarak hesaplanıyor. Eğer sonucun küsüratlı kısmı varsa ve biz bu görmek istiyorsak Aşağıdaki satırda olduğu gibi ->
            //Explicit conversion yapılabilir. Yani Sayılardan birini açık şekilde double'a cast ettik(dönüştürdük).

            double sonuc;
            try
            {
                sonuc = (double)sayiBolunen / sayiBolen;
            }
            catch (Exception)
            {
                Console.WriteLine("girmiş olduğunuz ilk değer düzgün değil");
                Console.ReadLine();
                return;
            }
            finally
            {
                Console.WriteLine("Sizi tekrar aramızda görmek isteriz Mert Çakmak");
                Console.ReadLine();
            }
            //decimal sonuc = decimal.Divide(sayiBolunen , sayiBolen);

            Console.WriteLine(sonuc);
            Console.ReadLine();

        }
    }
}
