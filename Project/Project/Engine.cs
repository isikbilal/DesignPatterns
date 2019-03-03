using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Engine
    {
        int güc;
        public Engine(int güc)
        {
            this.güc = güc;
        }

        public void start()
        {
            Console.WriteLine("Motor " + güc + " gücünde çalıştı.");
        }

    }
}
