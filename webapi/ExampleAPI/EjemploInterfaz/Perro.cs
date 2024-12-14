namespace ExampleAPI.EjemploInterfaz
{
    public class Perro : IAnimal
    {
        public string Tamanio { get; set; }
        public string Ladrar()
        {
            return "Guau";
        }
        public string Comer()
        {
            return "El perro esta comiendo(interfaz)";
        }
        public string Dormir()
        {
            return "El perro esta durmiendo(interfaz)";
        }
    }
}
