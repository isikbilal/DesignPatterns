using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication15
{
    class Factory
    {
        public static int mssql = 1;
        public static int oracle = 2;
        public static int mysql = 3;
        public Fiyat get(int tür)
        {
            if (tür == mssql)
                return new MsSql();
            else if (tür == oracle)
                return new Oracle();
            else if (tür == mysql)
                return new MySql();
            else
                return null;
        }
    }
}
