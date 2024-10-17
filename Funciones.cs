using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema1
{
    public class Funciones
    {
        int p =0, n =0;
        public int negativos() { 
            return n++;
        }
        public int positivos() {
            return p++;
        }
        public void reset()
        {
            n=0;
            p=0;
        }

    }
}
