namespace ExampleAPI.EjemploClaseAbstracta
{
    public class Gato : Animal
    {
        public Gato(string nombre) : base(nombre)
        {
        }

        public override string Comer()
        {
            return "El gato esta comiendo";
        }

        public override string Dormir()
        {
            return "El gato esta durmiendo";
        }

        public string CalcularDistancia()
        {
            return "El gato recorrio 20 km";
        }
    }
}
