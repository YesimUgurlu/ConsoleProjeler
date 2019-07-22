using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bir alt satırdaki a değişkeni tanımlanırsa
            //Birinci ve ikinci scopetaki a değişkenleri yeniden tanımlanamaz. 
            //Ama a değeri olarak tanımlanmadan kullanılabilir.Yani Main Bloğunda tanımlanan a değişkeninin faatliyet alanı açılan diğer
            //bloklarda devam etmektedir.
            //Üst seviyede açılan bloklar alt seviyedeki blokları kapsar.
           //int a = 65;
            {
                //Birinci scope
                int a = 19;
                Console.WriteLine("a nın değeri= " + a);
                Console.ReadLine();
            }
            //Aşağıdaki Kod compile hatası verir. Çünkü, a değişkeni bu scope'ta tanımlı değil.
            // Console.WriteLine(a);
            {
                //İkinci scope
                int a = 22;
                Console.WriteLine("a nın değeri= " + a);
                Console.ReadLine();

            }
        }
    }
}
