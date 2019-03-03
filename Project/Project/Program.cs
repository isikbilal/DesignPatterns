using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(100, 6);
            car.move();
            Console.ReadKey();
        }
    }
}
