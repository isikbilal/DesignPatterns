/* 1. Interface' i tanımla
Player Turu bir interface*/

namespace AdapterDesignPatternPlayer
{
    public interface IPlayer
    {
        void Play(string filePath);
    }
}

/*2. Standart Urunleri Hazırla
Interface'i baz alıyoruz
Mp3 Wav 
İstege bagli ogg*/

using System;
 
 
namespace AdapterDesignPatternPlayer
{
    public class Mp3Player : IPlayer
    {
        public void Play(string filePath)
        {
            //mp3 dosyamızı çalıştıracak playerı burda çalıştırdığımızı düşünelim
            Console.WriteLine(filePath + " is playing");
        }
 
    }
}


using System;
 
namespace AdapterDesignPatternPlayer
{
    public class WavPlayer:IPlayer
    {
        public void Play(string filePath)
        {
            //Wav dosyamızı çalıştıracak playerı burda çalıştırdığımızı düşünelim
            Console.WriteLine(filePath + " is playing");
        }
    }
}

/* 3. Mp4 sinifini hazirla*/
using System;
 
 
namespace AdapterDesignPatternMp4Player
{
    public class Mp4Player
    {
        public void Mp4Play(string filePath)
        {
            Soundplay();
            Display();
            Console.WriteLine(filePath + " is playing");
        }
 
        private void Soundplay()
        {
            //ses çalma işlemi yapılıyor
        }
 
        private void Display()
        {
            //görüntü oynatılıyor
        }
    }
}

/*4. Gerekli Adapter*/

/*---Adapteri hazırla*/
using AdapterDesignPatternMp4Player;
 
namespace AdapterDesignPatternPlayer
{
    public class Mp4PlayerAdapter:IPlayer
    {
        private Mp4Player _mp4Player;
        public void Play(string filePath)
        {
            _mp4Player=new Mp4Player();
            _mp4Player.Mp4Play(filePath);
        }
    }
}



/*Mainden cagir*/

using System;
using AdapterDesignPatternPlayer;
 
namespace AdapterDesignPatternClient
{
    class Program
    {
        static void Main(string[] args)
        {
            IPlayer player;
 
            player = new Mp3Player();
            player.Play("/PlayList/muzik1.mp3");
 
            player = new WavPlayer();
            player.Play("/PlayList/muzik2.wav");
 
            player = new Mp4PlayerAdapter();
            player.Play("/PlayList/muzik2.mp4");
 
            Console.ReadLine();
 
        }
    }
}
