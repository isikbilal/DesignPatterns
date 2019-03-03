using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class FactoryRenk
    {

        public static int Kirmizi = 4;
        public static int Yesil = 5;
        public static int Mavi = 6;

        public Renk getRenk(int renkTuru)
        {
            if (renkTuru == Kirmizi)
            {
                return new Kirmizi();
            }

            else if (renkTuru == Yesil)
            {
                return new Yesil();
            }
            else if (renkTuru == Mavi)
            {
                return new Mavi();
            }
            else
            {
                return null;
            }
        }
    }
}
