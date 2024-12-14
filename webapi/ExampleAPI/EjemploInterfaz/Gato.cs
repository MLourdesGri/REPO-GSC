namespace ExampleAPI.EjemploInterfaz
{
    public class Gato : IAnimal
    {
        public string Pelaje { get; set; }
        public string Maullar()
        {
            return "Miau";
        }
        public string Comer()
        {
            return "El gato esta comiendo(interfaz)";
        }
        public string Dormir()
        {
            return "El gato esta durmiendo(interfaz)";
        }
    }
}
