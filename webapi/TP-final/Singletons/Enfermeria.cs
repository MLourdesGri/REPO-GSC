namespace TP_final.Singletons
{
    public class Enfermeria
    {
        private static Enfermeria _instance;
        private static readonly object _lock = new object();
        public int VisitasDisponibles { get; private set; } = 5;

        private Enfermeria() { }

        public static Enfermeria Instance
        {
            get
            {
                lock (_lock)
                {
                    return _instance ??= new Enfermeria();
                }
            }
        }

        public bool Atender()
        {
            if (VisitasDisponibles > 0)
            {
                VisitasDisponibles--;
                return true;
            }
            return false;
        }
    }
}
