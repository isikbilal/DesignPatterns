using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    class Cember : Sekil
    {
        public int yaricap;
    
        public Cember(int r)
        {
            yaricap = r;
        }

   

        public double cevrehesapla()
        {
            return 2 * Math.PI * yaricap;
        }
    }
    
}
