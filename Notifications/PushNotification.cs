namespace DelegateNotificationOOP
{
    public class PushNotification:INotification
    {
        public void Send(string title, string message)
        {
            Console.WriteLine($"Push: {title} - {message}");
        }
    }
}

