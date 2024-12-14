namespace ExampleAPI.EjemploInterfaz
{
    public interface IAnimal
    {
        string Comer();
        string Dormir();

        public string ObtenerDistanciaRecorrida()
        {
            return "El animal recorrió 20km";
        }
    }
}
