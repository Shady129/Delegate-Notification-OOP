namespace DelegateNotificationOOP
{
    public class SmsNotification:INotification
    {

        public void Send(string title, string message)
        {
            Console.WriteLine($"SMS: {title} - {message}");
        }
    }

}

