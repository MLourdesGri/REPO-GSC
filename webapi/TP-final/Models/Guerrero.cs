namespace TP_final.Models
{
    public class Guerrero : ISuperheroe
    {
        public string Nombre { get; set; }
        public int Fuerza { get; set; }
        public int Salud { get; set; } = 5;
        public string PoderEspecial => "Espadazo";

        public string Atacar() => $"{Nombre} ataca con {PoderEspecial}.";
        public string Defender() => $"{Nombre} usa su escudo.";
    }
}
