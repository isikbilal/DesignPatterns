using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication15
{
    interface Fiyat
    {

        double dolar(double tutar);
        double euro(double tutar);
        double tl(double tutar);
    }
}
