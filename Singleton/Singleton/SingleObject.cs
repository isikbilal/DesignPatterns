using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class SingleObject
    {
        private int sayi;

        static SingleObject nesne = new SingleObject();

        private SingleObject() { sayi = 0; }

        public static SingleObject getObject() { return nesne; }
        public int getSayi() { return sayi; }

        public void setSayi(int sayi) { this.sayi= sayi; }

        public void artir(int miktar) { sayi = sayi + miktar; }

    }
}
