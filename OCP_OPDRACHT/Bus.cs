using System;

public class Bus
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
