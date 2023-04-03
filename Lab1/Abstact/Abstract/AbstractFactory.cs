// Abstract product interface
public interface ICar
{
    void Drive();
}
// Concrete product classes
public class LuxurySportsCar : ICar
{
    public void Drive()
    {
        Console.WriteLine("Driving a luxury sports car...");
    }
}
public class LuxurySUV : ICar
{
    public void Drive()
    {
        Console.WriteLine("Driving a luxury SUV...");
    }
}
public class EconomySportsCar : ICar
{
    public void Drive()
    {
        Console.WriteLine("Driving an economy sports car...");
    }
}
public class EconomySUV : ICar
{
    public void Drive()
    {
        Console.WriteLine("Driving an economy SUV...");
    }
}

// Abstract factory interface
public interface ICarFactory
{
    ICar CreateSportsCar();
    ICar CreateSUV();
}

// Concrete factory classes
public class LuxuryCarFactory : ICarFactory
{
    public ICar CreateSportsCar()
    {
        return new LuxurySportsCar();
    }

    public ICar CreateSUV()
    {
        return new LuxurySUV();
    }
}

public class EconomyCarFactory : ICarFactory
{
    public ICar CreateSportsCar()
    {
        return new EconomySportsCar();
    }

    public ICar CreateSUV()
    {
        return new EconomySUV();
    }
}
