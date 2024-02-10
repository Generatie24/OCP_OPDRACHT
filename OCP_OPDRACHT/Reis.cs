
// Definieer soortgelijke klassen voor Trein en Vliegtuig

public class Reis
{
    private Bus _bus;

    public Reis()
    {
        _bus = new Bus();
    }

    public string StartReis()
    {
        _bus.StuurEmail("voorbeeld@example.com");
        return _bus.ReisUitvoeren();
    }
}
