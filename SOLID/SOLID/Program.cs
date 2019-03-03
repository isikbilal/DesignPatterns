using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            Kare kare = new Kare(5);
            Cember cember = new Cember(4);
            Daire daire = new Daire(10);
            cevreHesapla cevre = new cevreHesapla();
            Console.WriteLine(cevre.Hesapla(kare));
            Console.WriteLine(cevre.Hesapla(cember));
            Console.WriteLine(cevre.Hesapla(daire));
            Console.ReadKey();

        }
    }
}
