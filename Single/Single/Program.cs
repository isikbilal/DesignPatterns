using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Single
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = Player.getPlayer();
            MediaController controller = new MediaController("Şarkı 1");

            Thread.Sleep(5000);
            player.play();
            Thread.Sleep(10000);
            controller.stop();

            Console.ReadKey();
        }
    }
}
