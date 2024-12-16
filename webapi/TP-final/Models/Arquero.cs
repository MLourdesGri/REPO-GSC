namespace TP_final.Models
{
    public class Arquero : ISuperheroe
    {
        public string Nombre { get; set; }
        public int Fuerza { get; set; }
        public int Salud { get; set; } = 5; // Salud inicial máxima
        public string PoderEspecial => "Disparo Preciso";

        public string Atacar() => $"{Nombre} realiza un {PoderEspecial} con su arco.";
        public string Defender() => $"{Nombre} se oculta entre las sombras para defenderse.";
    }

}
