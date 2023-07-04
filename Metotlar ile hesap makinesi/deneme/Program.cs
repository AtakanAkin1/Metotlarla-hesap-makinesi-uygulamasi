using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deneme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Isim: ");
            string isim = Console.ReadLine();
            Console.Write("Soyisim: ");
            string soyisim = Console.ReadLine();
            Console.Clear();

            Bilgiler B1 = new Bilgiler();
            B1.kullanici(isim, soyisim);
            B1.menuler();
          
        }           
    }
}
