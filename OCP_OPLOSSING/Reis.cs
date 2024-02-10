namespace OCP_OPLOSSING
{
    public class Reis
    {
        private ITransportmiddel _transportmiddel;

        public Reis(ITransportmiddel transportmiddel)
        {
            _transportmiddel = transportmiddel;
        }

        public string StartReis()
        {
            _transportmiddel.StuurEmail("klant@voorbeeld.com");
            return $"Start reis met {_transportmiddel.ReisUitvoeren()}. Prijs: {_transportmiddel.Prijs} Euro.";
        }
    }
}
