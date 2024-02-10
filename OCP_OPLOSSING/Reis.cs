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
            _transportmiddel.StuurEmail("Reizen@Company.com");
            return _transportmiddel.ReisUitvoeren();
        }
    }
}
