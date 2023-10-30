using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eccezioni_1
{
    internal class Macchina03
    {
        public int Potenza { get; set; }
        public Macchina03(int potenza)
        {
            Potenza = potenza;
        }

        public int Tempo(int lavoro)
        {
            try
            {
                return lavoro / Potenza;

            }
            catch (DivideByZeroException e)
            {

                Console.WriteLine("la potenza non può essere zero");
                return -1;//questo NON ci piace. ma siamo obbligati a metterlo
            }
            finally//serve a rilasciare le risorse
            {
                Console.WriteLine("Dal \"finally\" ci passo comunque!");
            }
        }
    }
}
