namespace EjemploEnClase.SinDY
{
    public class UsuarioServiceSinDY
    {
        public EmailServiceSinDY emailServiceSinDY{ get; set; }
        public UsuarioServiceSinDY()
        {
            emailServiceSinDY = new EmailServiceSinDY();
        }

        public bool EnviarNotificacionUsuario(string email)
        {
            emailServiceSinDY.Enviar(email, "Notificacion");
            return true;
        }
    }
}
