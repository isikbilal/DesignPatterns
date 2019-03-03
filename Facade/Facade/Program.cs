using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            Topla topla = new Topla();
            Cikar cikar = new Cikar();

             double toplaSonuc = topla.hesapla(100, 500);
             double cikarSonuc = cikar.hesapla(1000, 500);

               Console.WriteLine("toplama: "+toplaSonuc);
               Console.WriteLine("çıkarma: " + cikarSonuc);

            HesapMakinesi hesapMakinesi = new HesapMakinesi();

             toplaSonuc = hesapMakinesi.toplaHesapla(100, 500);
             cikarSonuc = hesapMakinesi.cikarHesapla(1000, 500);
            double carpSonuc = hesapMakinesi.carpHesapla(100, 500);
            double bolSonuc = hesapMakinesi.bolHesapla(500, 100);

            Console.WriteLine("\nFacade Tasarım Deseni\n");

            Console.WriteLine("toplama: " + toplaSonuc);
            Console.WriteLine("çıkarma: " + cikarSonuc);
            Console.WriteLine("carpma: "+ carpSonuc);
            Console.WriteLine("bolme: "+ bolSonuc);

            Console.ReadKey();

        }
    }
}
