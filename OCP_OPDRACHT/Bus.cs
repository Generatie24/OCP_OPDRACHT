using System;

public class Bus
{
    public decimal Prijs => 20.00m;

    public string ReisUitvoeren()
    {
        return "Reizen met de bus";
    }

    public void StuurEmail(string adres)
    {
        Console.WriteLine($"E-mail voor busreis verzonden naar {adres}: 'Uw reis met de bus is geboekt!'");
    }
}
