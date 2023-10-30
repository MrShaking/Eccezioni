using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eccezioni_1
{
    internal class Macchina04
    {

        public int Potenza { get; set; }
        public Macchina04(int potenza)
        {
            Potenza = potenza;
        }
        public int Tempo(int lavoro)
        {
            return lavoro / Potenza;
        }
    }
}
