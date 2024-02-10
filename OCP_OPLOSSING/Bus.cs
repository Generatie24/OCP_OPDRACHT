using System;

namespace OCP_OPLOSSING
{
    public class Bus : ITransportmiddel
    {
        public decimal Prijs => 20.00m;
        public string EmailAdres { get; set; } = "bus@voorbeeld.com";

        public string ReisUitvoeren()
        {
            return "Reizen met de bus";
        }

        public void StuurEmail(string adres)
        {
            Console.WriteLine($"E-mail voor busreis verzonden naar {EmailAdres}: 'Uw reis met de bus is geboekt!'");
        }
    }
}
