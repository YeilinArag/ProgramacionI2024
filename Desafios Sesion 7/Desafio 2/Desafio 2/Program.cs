interface INotificable
{
    void Notificar();
}

class NotificacionEmail : INotificable
{
    public string DireccionCorreo { get; set; }
    public void Notificar()
    {
        Console.WriteLine($"Enviando notificación por correo electrónico a {DireccionCorreo}");
    }
}

class NotificacionWhatsapp : INotificable
{
    public string NumeroTelefono { get; set; }
    public void Notificar()
    {
        Console.WriteLine($"Enviando notificación por Whatsapp al número {NumeroTelefono}");
    }
}

class NotificacionSMS : INotificable
{
    public string NumeroTelefono { get; set; }
    public void Notificar()
    {
        Console.WriteLine($"Enviando notificación por SMS al número {NumeroTelefono}");
    }
}

    class Program
    {
        static void Main(string[] args)
        {
        NotificacionEmail notificacionEmail = new NotificacionEmail();
        notificacionEmail.DireccionCorreo = "cecyalvarado66@gmail.com";
        notificacionEmail.Notificar();

        NotificacionWhatsapp notificacionWhatsapp = new NotificacionWhatsapp();
        notificacionWhatsapp.NumeroTelefono = "+502 42672937";
        notificacionWhatsapp.Notificar();

       
        NotificacionSMS notificacionSMS = new NotificacionSMS();
        notificacionSMS.NumeroTelefono = "+502 42672937";
        notificacionSMS.Notificar();

        Console.ReadLine();
    }

}

