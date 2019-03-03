using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class TV:Media
    {
        string oynatilanKanal;
        List<string> kanallar;
        public bool playing;
        public void kanalBul()
        {
            kanallar = new List<string>();
            kanallar.Add("TRT 1");
            kanallar.Add("TRT 2");
            kanallar.Add("TRT 3");
            kanallar.Add("TRT Haber");
        }

        public void pause()
        {
            Console.WriteLine(oynatilanKanal + " durduruldu.");
        }

        public void play()
        {
            Random rnd = new Random();
            oynatilanKanal = kanallar.ElementAt(rnd.Next(4));
            Console.WriteLine(oynatilanKanal + " izleniyor.");
        }

        public bool isPlaying()
        {
            return playing;
        }

        public void setPlaying(bool value)
        {
            playing = value;
        }
    }
}
