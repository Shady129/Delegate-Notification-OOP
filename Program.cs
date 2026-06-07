namespace DelegateNotificationOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Notify myNotify;


            INotification notification = new SmsNotification();
            myNotify = notification.Send;


            notification = new EmailNotification();
            myNotify += notification.Send;



            notification = new PushNotification();
            myNotify += notification.Send;


            notification = new WhatsAppNotification();
            myNotify += notification.Send;



            Order myOrder = new Order(myNotify);

            myOrder.CreateOrder();

        }
    }
}

