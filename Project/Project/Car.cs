using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Car
    {
        Engine engine;
        Wheels wheels;

        public Car(int güc, int sayi)
        {
            engine = new Engine(güc);
            wheels = new Wheels(sayi);
        }

        public void move()
        {
            engine.start();
            wheels.hareket();
        }
    }
}
