namespace PizzaFactoryExample
{
    public interface IPizza
    {
        string GetName();
        double GetCost();
    }

    public class PizzaCascaval : IPizza
    {
        public string GetName()
        {
            return "Pizza Cascaval";
        }

        public double GetCost()
        {
            return 8.99;
        }
    }

    public class PepperoniPizza : IPizza
    {
        public string GetName()
        {
            return "Pepperoni Pizza";
        }

        public double GetCost()
        {
            return 10.99;
        }
    }

    public class VegetarianaPizza : IPizza
    {
        public string GetName()
        {
            return "Pizza Vegetariana";
        }

        public double GetCost()
        {
            return 9.99;
        }
    }

    public static class PizzaFactory
    {
        public static IPizza CreatePizza(string type)
        {
            switch (type.ToLower())
            {
                case "cascaval":
                    return new PizzaCascaval();
                case "pepperoni":
                    return new PepperoniPizza();
                case "vegetariana":
                    return new VegetarianaPizza();
                default:
                    throw new ArgumentException($"Invalid pizza type: {type}");
            }
        }
    }
}
