using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            SingleObject nesne = SingleObject.getObject();

            nesne.setSayi(20);
            Class1 clas = new Class1();
            clas.draw();

            Console.WriteLine("Sayi: "+nesne.getSayi());

            Console.ReadKey();
        }
    }
}
