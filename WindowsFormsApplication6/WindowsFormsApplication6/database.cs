using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication6
{
    class database
    {
        String[] urunAd;
        int[] fiyat;

     public database()
        {
            urunAd = new String[5];
            fiyat = new int[5];
            urunAd[0] = "elma";
            urunAd[1] = "armut";
            urunAd[2] = "ayva";
            urunAd[3] = "kiraz";
            urunAd[4] = "fişne";
            fiyat[0] = 100;
            fiyat[1] = 140;
            fiyat[2] = 200;
            fiyat[3] = 110;
            fiyat[4] = 90;
        }

        public string getAd(int index)
        {
            return urunAd[index];
        }

        public int getFiyat(int index)
        {
            return fiyat[index];
        }


    }
}
