using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deneme
{
    internal class Bilgiler
    {
        internal void kullanici(string isim , string soyisim)
        {

            Console.WriteLine("Isim: "+isim);
            Console.WriteLine("Soyisim: "+soyisim);
            
        }
        internal string secim()
        {
            Console.WriteLine("1. Toplama");
            Console.WriteLine("2. Cikartma");
            Console.WriteLine("3. Carpma");
            Console.WriteLine("4. Bolme");
            Console.WriteLine("5. Cikis");
            Console.Write("Seciminiz: ");
            return Console.ReadLine();
        }
        internal void toplama(double sayi1 , double sayi2)
        {
            double sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplama isleminin sonucu: {0}+{1} = {2} ",sayi1,sayi2,sonuc);

        }
        internal void cikartma(double sayi1, double sayi2)
        {
            double sonuc = sayi1 - sayi2;
            Console.WriteLine("Cikartma isleminin sonucu: {0}-{1} = {2}",sayi1,sayi2,sonuc);
        }
        internal void carpma(double sayi1, double sayi2)
        {
            double sonuc = sayi1 * sayi2;
            Console.WriteLine("Carpma isleminin sonucu: {0}*{1} = {2}",sayi1,sayi2,sonuc);
        }
        internal void bolme(double sayi1,double sayi2)
        {
            double sonuc = sayi1 / sayi2;
            double sonuc2 = sayi1 % sayi2;
            Console.WriteLine("Bolme isleminin sonucu: {0}/{1} = {2}",sayi1,sayi2,sonuc);
            Console.WriteLine("Kalan: {0}",sonuc2);
        }

        internal void menuler()
        {
        geridon:        
            string secimm = secim();
            
            switch (secimm)
            {
              
                case "1":
                    Console.Clear();
                    Console.WriteLine("-TOPLAMA-");
                    Console.Write("1. Sayi: ");
                    double top1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("2. Sayi: ");
                    double top2 = Convert.ToDouble(Console.ReadLine());
                    toplama(top1, top2);
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("-CIKARTMA-");
                    Console.Write("1. Sayi: ");
                    double cik1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("2. Sayi: ");
                    double cik2 = Convert.ToDouble(Console.ReadLine());
                    cikartma(cik1, cik2);
                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine("-CARPMA-");
                    Console.Write("1. Sayi: ");
                    double carp1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("2. Sayi: ");
                    double carp2 = Convert.ToDouble(Console.ReadLine());
                    carpma(carp1, carp2);
                    break;
                case "4":
                    Console.Clear();
                    Console.WriteLine("-BOLME-");
                    Console.Write("1. Sayi: ");
                    double bol1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("2. Sayi: ");
                    double bol2 = Convert.ToDouble(Console.ReadLine());
                    bolme(bol1, bol2);
                    break;
                case "5":
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("Lutfen gercerli bir tuslama yapiniz.");
                    break;                  
            }
            if(secimm!="5")
            {
                Console.Write("Devam etmek ister misini(E/H): ");
                string Ksecim = Console.ReadLine();
                if (Ksecim.ToUpper() == "E")
                {
                    Console.WriteLine("Islem devam ediyor lutfen bekleyiniz...");
                    System.Threading.Thread.Sleep(2000);
                    Console.Clear();
                    goto geridon;
                }
                else
                {
                    Console.WriteLine("Program kapatiliyor, Lutfen bekleyiniz...");
                    System.Threading.Thread.Sleep(2500);
                    Console.Clear();
                }
            }
            else
            {
                Console.WriteLine("Programi kullandiginiz icin TESEKKURLER.");
                Console.WriteLine("ENTER tusuna basip cikis yapabilirsiniz.");
                Console.ReadLine();
            }
            
        }
        
    }
}
