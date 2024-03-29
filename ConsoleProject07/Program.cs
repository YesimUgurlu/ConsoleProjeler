﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject07
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string a = Console.ReadLine();
                string b = Console.ReadLine();
                int toplam = Int32.Parse(a) + Int32.Parse(b);
                Console.WriteLine(toplam);
            }
            catch (FormatException nesne) //Eğer hem bu catch'teki hem 
            {
                Console.WriteLine("Şu hata meydana geldi 0: " + nesne.Message);
            }
            catch (OverflowException nesne)
            {
                Console.WriteLine("Şu hata meydana geldi 1: " + nesne.Message);
            }
            catch
            {
                Console.WriteLine("Şu hata meydana geldi 2: Nesnesiz Catch");
            }

            finally
            {
                Console.ReadLine();
            }
        }
    }
}
