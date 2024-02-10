using System;

namespace OCP_OPLOSSING
{
    public class Trein : ITransportmiddel
    {
        public string ReisUitvoeren()
        {
            return "Reizen met de trein";
        }

        public void StuurEmail(string adres)
        {
            Console.WriteLine($"E-mail verzonden naar {adres} over reizen met de trein.");
        }
    }
}
