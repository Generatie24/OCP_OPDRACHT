namespace OCP_OPLOSSING
{
    public interface ITransportmiddel
    {
        decimal Prijs { get; }
        string ReisUitvoeren();
        void StuurEmail(string adres);
    }

}
