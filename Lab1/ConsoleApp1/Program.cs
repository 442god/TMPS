namespace Singleton;
class Program
{
    public static void Main(string[] args)
    {
        OrderTrackingSystem trackingSystem = OrderTrackingSystem.Instance;
        trackingSystem.AddOrder(1, "Product A");
        trackingSystem.AddOrder(2, "Product B");
        trackingSystem.AddOrder(2, "Product C");
        trackingSystem.PrintOrdersByCustomer();
    }

}
