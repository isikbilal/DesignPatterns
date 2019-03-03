using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication15
{
    class Program:MySql
    {
        static void Main(string[] args)
        {
            Factory faktor = new Factory();
            Oracle orc = (Oracle)faktor.get(Factory.oracle);
            MsSql msq = (MsSql)faktor.get(Factory.mssql);
            MySql myq = (MySql)faktor.get(Factory.mysql);
            Console.WriteLine("Dolar fiyatı: "+orc.dolar(5)+"$"+"\n"+"Euro Fiyatı: "+orc.euro(5)+"£"+"\n"+"TL fiyatı: "+orc.tl(5)+"tl\n");
            Console.WriteLine("Dolar fiyatı: " + msq.dolar(8) + "$" + "\n" + "Euro Fiyatı: " + msq.euro(8) + "£" + "\n" + "TL fiyatı: " + msq.tl(8) + "tl\n");
            Console.WriteLine("Dolar fiyatı: " + myq.dolar(2) + "$" + "\n" + "Euro Fiyatı: " + myq.euro(2) + "£" + "\n" + "TL fiyatı: " + myq.tl(2) + "tl");

            Console.ReadKey();
        }
    }
}
