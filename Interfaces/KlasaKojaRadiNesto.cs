namespace practice.Interfaces
{
    public class KlasaKojaRadiNesto
    {
        private readonly IInterfejs danilo;
        public KlasaKojaRadiNesto(IInterfejs danilo)
        {
            this.danilo = danilo;

        }

        public void radimnesto()
        {
            danilo.PrintajNesto("neki tekst");
        }
    }
}