using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication15
{
    class MsSql : Fiyat
    {
        public double tutar;



        public double dolar(double tutar)
        {
         return   tutar = tutar * (4.99);
        }

        public double euro(double tutar)
        {
            return tutar = tutar * (4.1);
        }

        public double tl(double tutar)
        {
            return tutar = tutar * (1);
        }

        
    }
    }
