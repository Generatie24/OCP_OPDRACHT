
public class Reis
{
    private Bus _bus;

    public Reis()
    {
        _bus = new Bus();
    }

    public string StartReis()
    {
        _bus.StuurEmail("klant@voorbeeld.com");
        return $"Start reis met {_bus.ReisUitvoeren()}. Prijs: {_bus.Prijs} Euro.";
    }
}
