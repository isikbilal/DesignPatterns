using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaPlayer
{
    class Client
    {
        public void oynat(String path, IPlayer oynatici)
        {
            oynatici.Play(path);
        }
    }
}
