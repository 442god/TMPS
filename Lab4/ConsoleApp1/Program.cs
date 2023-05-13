public interface ITakeOff
{
    void TakeOff();
}

public interface ILand
{
    void Land();
}

public class PassengerFlight : ITakeOff, ILand
{
    public void TakeOff()
    {
        Console.WriteLine("Decolare zbor de pasageri...");
        Console.WriteLine("Zborul de pasageri a decolat.");
    }

    public void Land()
    {
        Console.WriteLine("Aterizare zbor de pasageri...");
        Console.WriteLine("Zborul de pasageri a aterizat.");
    }
}

public class CargoFlight : ITakeOff, ILand
{
    public void TakeOff()
    {
        Console.WriteLine("Decolare zbor de marfă...");
        Console.WriteLine("Zborul de marfă a decolat.");
    }

    public void Land()
    {
        Console.WriteLine("Aterizare zbor de marfă...");
        Console.WriteLine("Zborul de marfă a aterizat.");
    }
}

public class FlightManager
{
    private ITakeOff takeOffFlight;
    private ILand landFlight;

    public FlightManager(ITakeOff takeOffFlight, ILand landFlight)
    {
        this.takeOffFlight = takeOffFlight;
        this.landFlight = landFlight;
    }

    public void PerformTakeOff()
    {
        takeOffFlight.TakeOff();
    }

    public void PerformLand()
    {
        landFlight.Land();
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        ITakeOff passengerFlight = new PassengerFlight();
        ILand passengerFlightLanding = new PassengerFlight();

        ITakeOff cargoFlight = new CargoFlight();
        ILand cargoFlightLanding = new CargoFlight();

        FlightManager passengerFlightManager = new FlightManager(passengerFlight, passengerFlightLanding);
        passengerFlightManager.PerformTakeOff();
        passengerFlightManager.PerformLand();

        Console.WriteLine();

        FlightManager cargoFlightManager = new FlightManager(cargoFlight, cargoFlightLanding);
        cargoFlightManager.PerformTakeOff();
        cargoFlightManager.PerformLand();
    }
}
