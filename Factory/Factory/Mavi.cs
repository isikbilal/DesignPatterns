using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Mavi:Renk
    {
        public void fill()
        {
            Console.WriteLine("Maviye boyandı");
        }
    }
}
