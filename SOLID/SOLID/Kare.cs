using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public class Kare : Sekil,Alan
    {
        public int kenar;
        public Kare(int value )
        {
            kenar = value;
        }

        public double alanHesapla()
        {
            return kenar * kenar;
        }

        public double cevrehesapla()
        {
            return kenar + kenar + kenar + kenar;
        }
    }
}
