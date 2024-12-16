using TP_final.Models;

namespace TP_final.Factories
{
    public class SuperHeroeFactory
    {
        public static ISuperheroe CrearSuperHeroe(string tipo, string nombre)
        {
            return tipo.ToLower() switch
            {
                "mago" => new Mago { Nombre = nombre, Fuerza = 10 },
                "guerrero" => new Guerrero { Nombre = nombre, Fuerza = 15 },
                "arquero" => new Arquero { Nombre = nombre, Fuerza = 12 },
                _ => throw new ArgumentException("Tipo de superhéroe no válido.")
            };
        }
    }
}
