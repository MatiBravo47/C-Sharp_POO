namespace Estacionamiento
{
    internal class Auto
    {
        public string Patente { get; set; }
        public string Marca { get; set; }

        public Auto(string patente, string marca)
        {
            Patente = patente.ToUpper();
            Marca = marca.ToUpper();
        }
    }
}
