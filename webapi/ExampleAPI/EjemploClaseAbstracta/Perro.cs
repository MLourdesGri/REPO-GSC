namespace ExampleAPI.EjemploClaseAbstracta
{
    public class Perro : Animal
    {
        public Perro(string nombre) : base(nombre)
        {
        }


        public override string Comer()
        {
            return "El perro esta comiendo";
        }

        public override string Dormir()
        {
            return "El perro esta durmiendo";
        }

        public string CalcularDistancia()
        {
            return "El perro recorrio 20 km";
        }
    }
}
