namespace Singleton
{
    public sealed class OrderTrackingSystem
    {
        private static OrderTrackingSystem instance = null;
        private static readonly object padlock = new object();

        private Dictionary<int, List<string>> ordersByCustomerId = new Dictionary<int, List<string>>();

        private OrderTrackingSystem() { }

        public static OrderTrackingSystem Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new OrderTrackingSystem();
                    }
                    return instance;
                }
            }
        }

        public void AddOrder(int customerId, string order)
        {
            if (!ordersByCustomerId.ContainsKey(customerId))
            {
                ordersByCustomerId[customerId] = new List<string>();
            }
            ordersByCustomerId[customerId].Add(order);
            Console.WriteLine("Added order {0} for customer {1}", order, customerId);
        }

        public void PrintOrdersByCustomer()
        {
            foreach (int customerId in ordersByCustomerId.Keys)
            {
                Console.WriteLine("Orders for customer {0}:", customerId);
                foreach (string order in ordersByCustomerId[customerId])
                {
                    Console.WriteLine("- {0}", order);
                }
            }
        }
    }

}
