using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class HesapMakinesi
    {
        // Facade sınıfımızın alt sınıflardaki tipleri içeriyor olması gerekir.

        Topla topla;
        Cikar cikar;
        Carp carp;
        Bol bol;

        public HesapMakinesi() {
            topla = new Topla();
            cikar = new Cikar();
            carp = new Carp();
            bol = new Bol();
        }

        public double toplaHesapla(double a, double b) { return topla.hesapla(a, b); }
        public double cikarHesapla(double a, double b) { return cikar.hesapla(a, b); }

        public double carpHesapla(double a, double b) { return carp.hesapla(a, b); }

        public double bolHesapla(double a, double b) { return bol.hesapla(a, b); }
    }
}
