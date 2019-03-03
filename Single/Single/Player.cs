using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Single
{
    class Player
    {

        private static Player player = new Player();
        bool ready;
        Thread thread;
       
        private Player()
        {
            thread = new Thread(new ThreadStart(run));
            ready = false;
            
        }
        public void run()
        {
            while(ready)
            {
                Thread.Sleep(1000);
                Console.WriteLine( " Dinleniyor...");
            }
        }

        public void play()
        {
            ready = true;
            thread.Start();
        }

        public void stop()
        {
            ready = false;
        }
        public static Player getPlayer() {

            return player;
        }
        
    }
}
