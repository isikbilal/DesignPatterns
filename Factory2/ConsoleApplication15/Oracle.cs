using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication15
{
    class Oracle:Fiyat
    {
        public double tutar;
      

        public double euro(double tutar)
        {
          return  tutar = tutar * (4.1);
        }

        public double tl(double tutar)
        {
           return tutar = tutar * (1);
        }

        public double dolar(double tutar)
        {
            return tutar = tutar * (4.99);
        }

       
    }
}
