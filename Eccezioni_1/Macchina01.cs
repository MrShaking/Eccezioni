using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eccezioni_1
{
    internal class Macchina01
    {
        public int Potenza { get; set; }
        public Macchina01(int potenza)
        {
            Potenza = potenza;
        }
        public int Tempo(int lavoro)
        {   
            return lavoro/Potenza;
        }


    }
}
