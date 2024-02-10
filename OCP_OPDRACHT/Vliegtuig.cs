using System;

public class Vliegtuig
{
    public decimal Prijs => 100.00m;

    public string ReisUitvoeren()
    {
        return "Reizen met het vliegtuig";
    }

    public void StuurEmail(string adres)
    {
        Console.WriteLine($"E-mail voor vliegreis verzonden naar {adres}: 'Uw vliegticket is bevestigd!'");
    }
}
