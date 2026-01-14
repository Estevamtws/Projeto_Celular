namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero) : base(numero)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
        // TODO: Sobrescrever o método "InstalarAplicativo"
        Console.WriteLine($"Instalando o aplicativo {nomeApp} no Iphone.");
        }
    }
}