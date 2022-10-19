namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Aplicativos = new List<string>();
            this.Numero = numero;
            this.Modelo = modelo;
            this.IMEI = imei;
            this.Memoria = memoria;
        }

        public List<string> Aplicativos { get; set; }
        public string Numero { get; set; }
        private string Modelo;
        private string IMEI;
        private int Memoria;

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public bool AdicionarAplicativos(string nomeApp){
            if (this.Aplicativos.Contains(nomeApp)){
                Console.WriteLine("Este aplicativo já esta instalado!");
                return false;
            }
            else{
                Aplicativos.Add(nomeApp);
                return true;
            }
        }

        public bool RemoverAplicativos(string nomeApp){
            if (this.Aplicativos.Contains(nomeApp)){
                Aplicativos.Remove(nomeApp);
                Console.WriteLine($"{nomeApp} desinstalado com sucesso!");
                return true;
            }
            else{
                Console.WriteLine($"O aplicativo {nomeApp} não está instalado");
                return false;
            }
        }

        public void listaraplicativos(){
            Console.WriteLine("Aplicativos Instalados:");
            int contador = 1;
            foreach(string app in Aplicativos){
                Console.WriteLine($"{contador} - {app}");
                contador++;
            }
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}