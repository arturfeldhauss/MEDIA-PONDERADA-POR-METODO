using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATIVIDADE09
{
    public class mediaponderada
    {
        public int peco1;
        public int peco2;
        public int nota1;
        public int nota2;

        public double mediap()
        {
            int mediap = (peco1 * nota1 + peco2 * nota2) / (peco2 + peco1);
            return mediap;
        
        }
        


    
    }
}
