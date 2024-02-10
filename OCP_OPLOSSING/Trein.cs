using System;

namespace OCP_OPLOSSING
{
    public class Trein : ITransportmiddel
    {
        public decimal Prijs => 20.00m;
        public string EmailAdres { get; set; } = "trein@voorbeeld.com";

        public string ReisUitvoeren()
        {
            return "Reizen met de bus";
        }

        public void StuurEmail(string adres)
        {
            Console.WriteLine($"E-mail voor treinreis verzonden naar {EmailAdres}: 'Uw reis met de trein is geboekt!'");
        }
    }
}
