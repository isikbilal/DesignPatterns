using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    abstract class Radio : Media
    {
        public List<string> kanallar;
        public bool playing;

        public abstract void pause();
        public abstract void play();

        public abstract void kanalBul();
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
