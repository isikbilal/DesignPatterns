using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    class Daire : Sekil,Alan
    {
        public int yaricap;
        public Daire(int value) {
            yaricap = value;
        }

        public double alanHesapla()
        {
            return 2 * Math.PI * yaricap * yaricap;
        }

        public double cevrehesapla()
        {
            return 2 * Math.PI * yaricap;
        }
    }
}
