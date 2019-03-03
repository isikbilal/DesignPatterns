using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vlc
{
    class Program
    {

        public interface IPlayer
        {

            void Play();
        }

        public class Mp3 : IPlayer
        {

            public void Play()
            {

                Console.WriteLine("Mp3 calıyorum");
            }
        }
        public class Mav : IPlayer
        {

            public void Play()
            {

                Console.WriteLine("Mav calıyorum");
            }
        }
        public class Ogg : IPlayer
        {

            public void Play()
            {

                Console.WriteLine("Ogg calıyorum");
            }
        }

        public class Mp4
        {
            public void play()
            {
                Console.WriteLine("mp4 calıyorum");
            }
            public void goruntu()
            {
                Console.WriteLine("goruntumde var");
            }

        }
        public class Mp4adapter : IPlayer
        {

          public  Mp4 mp4;

            public Mp4adapter( Mp4 mp4)
            {
                this.mp4 = mp4;

            }
            public void Play()
            {

                mp4.play();
                mp4.goruntu();
            }

        }

        


        static void Main(string[] args)
        {
            Mp4 mp4 = new Mp4();
            Mp4adapter mp5 = new Mp4adapter(mp4);
            mp5.Play();
            
            Console.ReadKey();

        }
    }

}


