using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static Yerel yerel; static Bolgesel bolgesel; static TV tv;
        static void Main(string[] args)
        {
            yerel = new Yerel();
            yerel.kanalBul();
            bolgesel = new Bolgesel();
            bolgesel.kanalBul();
            tv = new TV();
            tv.kanalBul();

            play(yerel);
            play(tv);
            play(yerel);
            play(bolgesel);
            play(bolgesel);

            Console.ReadKey();
        }

        static void play(Media media)
        {
            if (yerel.isPlaying())
            {
                yerel.pause();
                yerel.setPlaying(false);
            }
            if (bolgesel.isPlaying())
            {
                bolgesel.pause();
                bolgesel.setPlaying(false);
            }
            if (tv.isPlaying())
            {
                tv.pause();
                tv.setPlaying(false);
            }
            media.setPlaying(true);
            media.play();
        }
    }
}
