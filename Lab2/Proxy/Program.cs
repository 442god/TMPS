using System;

public interface IFlightSchedule
{
    void DisplayFlights();
}

public class FlightSchedule : IFlightSchedule
{
    public void DisplayFlights()
    {
        Console.WriteLine("Lista zborurilor de astăzi:");
        Console.WriteLine("Zborul 1: Chisinau - Londra");
        Console.WriteLine("Zborul 2: Paris - Roma");
        Console.WriteLine("Zborul 3: Berlin - Chisinau");
    }
}

public class FlightScheduleProxy : IFlightSchedule
{
    private FlightSchedule flightSchedule;

    public void DisplayFlights()
    {
        if (flightSchedule == null)
        {
            flightSchedule = new FlightSchedule();
        }
        flightSchedule.DisplayFlights();
    }
}

public class AirportClient
{
    private IFlightSchedule flightScheduleProxy;

    public AirportClient()
    {
        flightScheduleProxy = new FlightScheduleProxy();
    }

    public void DisplayFlights()
    {
        flightScheduleProxy.DisplayFlights();
    }
}

public class Program
{
    public static void Main()
    {
        AirportClient client = new AirportClient();
        client.DisplayFlights();
    }
}
