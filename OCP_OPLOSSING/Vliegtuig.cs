using System;

namespace OCP_OPLOSSING
{
    public class Vliegtuig : ITransportmiddel
    {
        public string ReisUitvoeren()
        {
            return "Reizen met het vliegtuig";
        }

        public void StuurEmail(string adres)
        {
            Console.WriteLine($"E-mail verzonden naar {adres} over reizen met het vliegtuig.");
        }
    }
}
