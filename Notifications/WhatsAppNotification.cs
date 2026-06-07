namespace DelegateNotificationOOP
{
    public class WhatsAppNotification:INotification
    {
        public void Send(string title, string message)
        {
            Console.WriteLine($"WhatsApp: {title} - {message}");
        }

    }
}

