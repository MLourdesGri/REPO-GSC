using ExampleAPI.EjemploInterfaz;

namespace ExampleAPI.EjemploInterfaz
{
    public class Base
    {
        public string Comer(IAnimal animal)
        {
            return animal.Comer();
        }
    }
}
