using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Wheels
    {
        int sayi;
        public Wheels(int sayi) { this.sayi = sayi; }

        public void hareket()
        {
            Console.WriteLine(sayi + " tekerlek harekete başladı.");
        }
    }
}
