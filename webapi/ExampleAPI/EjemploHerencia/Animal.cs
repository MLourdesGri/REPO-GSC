namespace ExampleAPI.EjemploHerencia
{
    public class Animal
    {
        public string Nombre { get; set; }

        public string Raza { get; set; }

        public virtual string Comer()
        {
            return "Esta comiendo";
        }

        public virtual string Dormir()
        {
            return "Esta durmiendo";
        }
    }
}
