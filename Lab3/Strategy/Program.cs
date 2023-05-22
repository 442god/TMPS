public interface IBoardingStrategy
{
    void Executa(string numarZbor);
}

public class StrategieImbarcareEconomica : IBoardingStrategy
{
    public void Executa(string numarZbor)
    {
        Console.WriteLine("Executare strategie de imbarcare economica pentru zborul " + numarZbor);
    }
}

public class StrategieImbarcareBusiness : IBoardingStrategy
{
    public void Executa(string numarZbor)
    {
        Console.WriteLine("Executare strategie de imbarcare business pentru zborul " + numarZbor);
    }
}

public class StrategieImbarcareClasaIntai : IBoardingStrategy
{
    public void Executa(string numarZbor)
    {
        Console.WriteLine("Executare strategie de imbarcare in clasa intâi pentru zborul " + numarZbor);
    }
}

public class ContextImbarcare
{
    private IBoardingStrategy _strategieImbarcare;

    public void SeteazaStrategieImbarcare(IBoardingStrategy strategieImbarcare)
    {
        _strategieImbarcare = strategieImbarcare;
    }

    public void ExecutaStrategieImbarcare(string numarZbor)
    {
        _strategieImbarcare.Executa(numarZbor);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        ContextImbarcare contextImbarcare = new ContextImbarcare();

        contextImbarcare.SeteazaStrategieImbarcare(new StrategieImbarcareEconomica());
        contextImbarcare.ExecutaStrategieImbarcare("ABC123");

        contextImbarcare.SeteazaStrategieImbarcare(new StrategieImbarcareBusiness());
        contextImbarcare.ExecutaStrategieImbarcare("XYZ789");

        contextImbarcare.SeteazaStrategieImbarcare(new StrategieImbarcareClasaIntai());
        contextImbarcare.ExecutaStrategieImbarcare("DEF456");
    }
}
