using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();

            client.oynat("C:\\müzik.mp4", new AdapterMP4());
            client.oynat("C:\\müzik2.mp3", new MP3());
            client.oynat("C:\\müzik3.mp4", new Ogg());

            Console.ReadKey();
        }
    }
}
