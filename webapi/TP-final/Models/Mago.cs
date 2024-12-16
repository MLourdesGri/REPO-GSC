namespace TP_final.Models
{
    public class Mago : ISuperheroe
    {
        public string Nombre { get; set; }
        public int Fuerza { get; set; }
        public int Salud { get; set; } = 5;
        public string PoderEspecial => "Bola de Fuego";

        public string Atacar() => $"{Nombre} lanza una {PoderEspecial}.";
        public string Defender() => $"{Nombre} levanta un escudo mágico.";
    }
}
