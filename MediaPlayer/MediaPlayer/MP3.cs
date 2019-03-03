using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaPlayer
{
    class MP3 : IPlayer
    {
        public void Play(String path) {
            Console.WriteLine("MP3 Çalınıyor...");
        }
    }
}
