using PizzaFactoryExample;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bine ati venit la Cassa de la Pizza!");
        Console.Write("Ce fel de pizza doriti sa comandati? (cascaval/pepperoni/vegetariana): ");
        string type = Console.ReadLine();

        IPizza pizza = PizzaFactory.CreatePizza(type);

        Console.WriteLine($"Comanda dvs. include {pizza.GetName()} pentru ${pizza.GetCost()}.");

        Console.WriteLine("Multumim pentru comanda!");
        Console.ReadLine();
    }
}
