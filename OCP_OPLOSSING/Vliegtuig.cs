using System;

namespace OCP_OPLOSSING
{
    public class Vliegtuig : ITransportmiddel
    {
        public decimal Prijs => 20.00m;
        public string EmailAdres { get; set; } = "vliegtuig@voorbeeld.com";

        public string ReisUitvoeren()
        {
            return "Reizen met de vliegtuig";
        }

        public void StuurEmail(string adres)
        {
            Console.WriteLine($"E-mail voor reis met de vliegtuig verzonden naar {EmailAdres}: 'reis met de vliegtuig is geboekt!'");
        }
    }
}
