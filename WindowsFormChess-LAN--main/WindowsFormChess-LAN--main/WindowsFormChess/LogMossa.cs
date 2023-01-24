using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sakk_Alkalmazás_2._0
{
    class LogMossa
    {
        //sul file sarà preIpreJpostIpostJ :file csv 
        public int preI;
        public int preJ;
        public int postI;
        public int postJ;
        public LogMossa(int p1, int p2, int p3, int p4)
        {
            preI = p1; 
            preJ = p2;
            postI = p3;
            postJ = p4;
        }

    }
}
