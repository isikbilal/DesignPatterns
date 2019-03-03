using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Bolgesel:Radio
    {
        string oynatilanKanal;
        public override void kanalBul()
        {
            kanallar = new List<string>();
            kanallar.Add("Alem FM");
            kanallar.Add("Show Radyo");
            kanallar.Add("Fenomen");
            kanallar.Add("Metro FM");
        }

        public override void pause()
        {
            Console.WriteLine(oynatilanKanal + " durduruldu.");
        }

        public override void play()
        {
            Random rnd = new Random();
            oynatilanKanal = kanallar.ElementAt(rnd.Next(4));
            Console.WriteLine(oynatilanKanal + " dinleniyor.");
        }
    }
}
