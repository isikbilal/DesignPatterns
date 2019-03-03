using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Kare kare = new Kare();
            Dikdortgen dktgn = new Dikdortgen();
            Daire daire = new Daire();

            kare.draw();
            daire.draw();
            dktgn.draw();

            Console.WriteLine("\n");

            Kirmizi kirmizi = new Kirmizi();
            Yesil yesil = new Yesil();
            Mavi mavi = new Mavi();

            kirmizi.fill();
            yesil.fill();
            mavi.fill();

            Console.WriteLine("\nFactory tasarım deseni\n");

            Factory factory = new Factory();
            Kare karee =(Kare) factory.get(Factory.Kare);
            Dikdortgen dikdortgenn = (Dikdortgen)factory.get(Factory.Dikdortgen);
            Daire dairee = (Daire)factory.get(Factory.Daire);

            karee.draw();
            dikdortgenn.draw();
            dairee.draw();

            Console.WriteLine("\n");

            FactoryRenk factoryRenk = new FactoryRenk();

            Kirmizi kirmizii = (Kirmizi) factoryRenk.getRenk(FactoryRenk.Kirmizi);
            Yesil yesill = (Yesil) factoryRenk.getRenk(FactoryRenk.Yesil);
            Mavi mavii = (Mavi) factoryRenk.getRenk(FactoryRenk.Mavi);

            kirmizii.fill();
            yesill.fill();
            mavii.fill();

            Console.ReadKey();
        }
    }
}
