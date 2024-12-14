namespace ExampleAPI.EjemploHerencia
{
    public class Gato : Animal
    {

        public string Pelaje { get; set; }
        public string Maullar()
        {
            return "Miau";
        }

        public override string Comer()
        {
            return "El gato esta comiendo";
        }

        public override string Dormir()
        {
            return "El gato esta durmiendo";
        }

    }
}
