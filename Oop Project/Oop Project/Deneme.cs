using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_Project
{
    class Deneme
    {

        public String mesaj;
        public void setA(String metin)
        {
            metin = metin.ToLower();

            string ilk = metin.Substring(0, 1);
            string kalan = metin.Substring(1);
            ilk = ilk.ToUpper();
            mesaj = ilk + kalan;
        }
    }
}
