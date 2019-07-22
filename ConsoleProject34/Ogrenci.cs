using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject34
{
    class Ogrenci
    {
        public int Yas { get; set; }
        public int Isim { get; set; }
        public int Soyisim { get; set; }
        public int Yaslandir (int eskiYas)
        {
            //int yeniYas = eskiYas + 1;
            //Yas = yeniYas;
            //return yeniYas; 
            // yukarıdaki 3 satırı aşagıdakiyle tek başına tek satırda yazabiliriz
            Yas = eskiYas + 1;
        }
    }
}
