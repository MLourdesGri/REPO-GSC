namespace ExampleAPI.EjemploHerencia
{
    public class Perro : Animal
    {
        public string Tamanio { get; set; }

        public string Ladrar()
        {
            return "Guau";
        }

        public override string Comer()
        {
            return "El perro esta comiendo";
        }

        public override string Dormir()
        {
            return "El perro esta durmiendo";
        }

    }
}
