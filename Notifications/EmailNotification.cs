namespace DelegateNotificationOOP
{
    public class EmailNotification: INotification
    {

        public void Send(string title, string message)
        {
            Console.WriteLine($"Email: {title} - {message}");
        }

    }
}

