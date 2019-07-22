using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject18
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcının girdiği satır ve sütun sayısı kadar * koyan program yazınız.

            int satir;
            int sutun;
            Console.Write("Satır sayısı giriniz: ");
            satir = Convert.ToInt32(Console.ReadLine());
            Console.Write("Sütun sayısı giriniz: ");
            sutun = Convert.ToInt32(Console.ReadLine());
            for (int x = 0; x < satir; x++)
            {
                for (int i = 0; i < sutun; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
        
    }
}
