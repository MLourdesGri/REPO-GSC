namespace TP_final.Models
{
    public interface ISuperheroe
    {
        string Nombre { get; set; }
        int Fuerza { get; set; }
        int Salud { get; set; }
        string PoderEspecial { get; }

        string Atacar();
        string Defender();
    }
}
