namespace ExampleAPI.EjemploClaseAbstracta
{
    public abstract class Animal
    {
        public string Nombre { get; set; }

        public Animal(string nombre)
        {
            this.Nombre = nombre;
        }
        public abstract string Comer();

        public abstract string Dormir(); 
    }
}
