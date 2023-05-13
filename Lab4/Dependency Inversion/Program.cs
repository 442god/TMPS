public interface ISecurityService
{
    void Scan();
}

public class CustomsSecurityService : ISecurityService
{
    public void Scan()
    {
        Console.WriteLine("Scanare bagaje pentru controlul vamal...");
        Console.WriteLine("Scanarea bagajelor pentru controlul vamal a fost finalizată.");
    }
}

public class PassengerSecurityService : ISecurityService
{
    public void Scan()
    {
        Console.WriteLine("Scanare pasageri pentru controlul de securitate...");
        Console.WriteLine("Scanarea pasagerilor pentru controlul de securitate a fost finalizată.");
    }
}

public class AirportSecurity
{
    private ISecurityService securityService;

    public AirportSecurity(ISecurityService securityService)
    {
        this.securityService = securityService;
    }

    public void PerformSecurityScan()
    {
        securityService.Scan();
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        ISecurityService customsSecurityService = new CustomsSecurityService();

        ISecurityService passengerSecurityService = new PassengerSecurityService();

        AirportSecurity customsSecurity = new AirportSecurity(customsSecurityService);
        customsSecurity.PerformSecurityScan();

        Console.WriteLine();

        AirportSecurity passengerSecurity = new AirportSecurity(passengerSecurityService);
        passengerSecurity.PerformSecurityScan();
    }
}
