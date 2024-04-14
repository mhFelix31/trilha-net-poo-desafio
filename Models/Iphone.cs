namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("Abrindo App Store.");
            Console.WriteLine($"Buscando {nomeApp}");
            Console.WriteLine("Baixando...");
            Console.WriteLine($"{nomeApp} Foi instalado com Sucesso.");
        }
    }
}