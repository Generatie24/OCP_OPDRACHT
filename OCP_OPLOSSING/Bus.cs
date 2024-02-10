using System;

namespace OCP_OPLOSSING
{
    public class Bus : ITransportmiddel
    {
        public string ReisUitvoeren()
        {
            return "Reizen met de bus";
        }

        public void StuurEmail(string adres)
        {
            Console.WriteLine($"E-mail verzonden naar {adres} over reizen met de bus.");
        }
    }
}
