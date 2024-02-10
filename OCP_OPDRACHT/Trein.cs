using System;

public class Trein
{
    public decimal Prijs => 30.00m;

    public string ReisUitvoeren()
    {
        return "Reizen met de trein";
    }

    public void StuurEmail(string adres)
    {
        Console.WriteLine($"E-mail voor treinreis verzonden naar {adres}: 'Uw treinreis staat gepland!'");
    }
}
