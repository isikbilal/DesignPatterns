using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Class1
    {
        SingleObject nesne;
        public Class1() { nesne = SingleObject.getObject(); }
        public void draw() { nesne.artir(10); }
    }
}
