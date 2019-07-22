using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections; // Biz ekliyoruz!

namespace ConsoleSORTEDLIST
{
    class Program
    {
        static void Main(string[] args)
        {
            
            SortedList Liste1 = new SortedList();

            Liste1.Add("03", "ögrenci");
            Liste1.Add("01", 10);
            Liste1.Add("10", true);
            Liste1.Add("06", 20);


            if (Liste1.ContainsValue("false"))
            {
                Console.WriteLine("false ifadesi listede bulunmaktadır!");
            }
            else
            {
                Liste1.Add("08", "false");
            }

            // keys değerlerini collection olarak alıyoruz
            ICollection key = Liste1.Keys;
            
            //foreach döngüsüyle dönüp ekrana yazdırıyoruz
            foreach (DictionaryEntry item in Liste1)
            {
                Console.WriteLine("{0} \t{1}", item.Key, item.Value);

            }
            Console.WriteLine(Liste1.GetKey(4).ToString());
            Console.WriteLine(Liste1.GetByIndex(4).ToString());
            Console.ReadLine();
            

        }
    }
}
