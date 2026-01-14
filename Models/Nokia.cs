namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero) : base(numero)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            // TODO: Sobrescrever o método "InstalarAplicativo"
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Nokia.");
        }
    }
}