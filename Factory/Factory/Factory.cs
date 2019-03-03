using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Factory
    {
        public static int Kare = 1;
        public static int Dikdortgen = 2;
        public static int Daire = 3;

        public Sekil get(int tur) {
            if (tur == Kare)
            {
                return new Kare();
            }

            else if (tur == Dikdortgen)
            {
                return new Dikdortgen();
            }
            else if (tur == Daire)
            {
                return new Daire();
            }
            else
            {
                return null;
            }
        }

    }
}
