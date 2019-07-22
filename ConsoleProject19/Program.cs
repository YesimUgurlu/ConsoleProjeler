using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject19
{
    class Program
    {
        static void Main(string[] args)
        {
            //Belirlenen kullanıcı adı ve şifre doğru girildiğinde 
            //"Giriş başarılı", yanlış girildiğinde "Girdiğiniz kullanıcı adı veya şifre hatalı" mesajı veren Console uyg. yapalım
            //Kullanıcı adı "admin" ve şifre "123456"

            //string user, password;
            //Console.Write("Kullanıcı adınızı giriniz: ");
            //user = Console.ReadLine();

            //Console.Write("Şifrenizi giriniz: ");
            //password = Console.ReadLine();

            //if(user=="admin" && password == "123456")
            //{
            //    Console.WriteLine("Giriş başarılı!");
            //}
            //else
            //{
            //    Console.WriteLine("Girdiğiniz kullanıcı adı veya şifre hatalı!");
            //}
            //Console.ReadLine();
            string user, password;
            while (true)
            {
                Console.Write("Kullanıcı adınızı giriniz: ");
                user = Console.ReadLine();

                if (user != "admin")
                {
                    Console.WriteLine("Kullanıcı adı hatalı!");
                    continue;
                }

                int sayac = 5;
                while ( sayac > 0)
                {
                    
                    Console.Write("Şifrenizi giriniz: ");
                    password = Console.ReadLine();
                    if (password != "123456")
                    {
                        Console.WriteLine("Şifre adı hatalı!");
                        sayac = sayac - 1;
                        Console.WriteLine("Toplam " + sayac + " deneme hakkınız kaldı!");
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                if (sayac==0)
                {
                    Console.WriteLine("Şifre deneme hakkınız bitmiştir.");
                    Console.ReadLine();
                    return;
                }
                Console.WriteLine("Giriş başarılı!");
                Console.ReadLine();
                return;
            }
            
        }
        
        
    }
}
