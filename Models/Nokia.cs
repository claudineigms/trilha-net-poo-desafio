namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        { }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp}...");
            if (AdicionarAplicativos(nomeApp))
            {
                Console.WriteLine($"{nomeApp} Instalado com Sucesso!");
            }
            else
            {
                Console.WriteLine("");
            }
        }
    }
}