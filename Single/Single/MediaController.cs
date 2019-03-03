using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Single
{
    class MediaController
    {
        Player player;
        public MediaController(string song)
        {
            player = Player.getPlayer();
        }

        public void stop()
        {
            player.stop();
        }
    }
}
