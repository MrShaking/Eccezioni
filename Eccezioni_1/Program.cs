namespace Eccezioni_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lavoro = 100;
            int pow = 0;
            /*var mac1 = new Macchina01(pow);
            Console.WriteLine($"La mia macchina in { mac1.Tempo(lavoro)} secondi consuma{lavoro} Joule di Energia!");
            */
            /*var mac2 = new Macchina02(pow);
            Console.WriteLine($"La mia macchina in {mac2.Tempo(lavoro, out int errore)} secondi consuma {lavoro} Joule di Energia!");
            if (errore==1)
            {
                Console.WriteLine("La potenza non può esseere zero!");

            }
            */
            /* var mac3 = new Macchina03(pow);
             Console.WriteLine($"La mia macchina in {mac3.Tempo(lavoro)} secondi consuma {lavoro} Joule di Energia!");
            */
            var mac4 = new Macchina04(pow);
            try
            {
                Console.WriteLine($"La mia macchina in {mac4.Tempo(lavoro)} secondi consuma {lavoro} Joule di Energia!");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("La potenza non può esseere zero!");
            }
            catch(ArithmeticException e)
            {
                Console.WriteLine(e.StackTrace);
            }
        } 
    }
}