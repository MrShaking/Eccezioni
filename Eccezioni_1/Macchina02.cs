using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eccezioni_1
{
    internal class Macchina02
    {
        public int Potenza { get; set; }
        public Macchina02(int potenza)
        {
            Potenza = potenza;
        }
        public int Tempo(int lavoro, out int errore)//parametro di output
        {
            if (Potenza == 0) { errore = 1; return 0; }
            errore = 0;
            return lavoro / Potenza;
        }
    }
}
