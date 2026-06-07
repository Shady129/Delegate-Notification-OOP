namespace DelegateNotificationOOP
{
    public class Order
    {
        Notify OrderNotifier;


        public Order(Notify myNotify)
        {
            OrderNotifier = myNotify;
        }


        public void CreateOrder()
        {
            OrderNotifier?.Invoke("Order Created", "Your order has been created successfully");
        }
    }
}

