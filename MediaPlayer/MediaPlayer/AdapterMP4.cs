using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaPlayer
{
    class AdapterMP4 : IPlayer
    {
        MP4 mp4;

        public AdapterMP4()
        {
            mp4 = new MP4();
        }

        public void Play(String path)
        {
            mp4.mp4Cal(path);
            mp4.mp4Goster(path);
        }
    }
}
