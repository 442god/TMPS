abstract class TravelProcess
{
    public void Travel()
    {
        CheckIn();
        SecurityCheck();
        Boarding();
        TakeOff();
        Land();
    }

    protected abstract void CheckIn();
    protected abstract void SecurityCheck();
    protected abstract void Boarding();
    protected abstract void TakeOff();
    protected abstract void Land();
}

class AirportFlight : TravelProcess
{
    protected override void CheckIn()
    {
        Console.WriteLine("Pasagerii fac check-in-ul la ghiseele aeroportului.");
    }

    protected override void SecurityCheck()
    {
        Console.WriteLine("Pasagerii trec prin controlul de securitate.");
    }

    protected override void Boarding()
    {
        Console.WriteLine("Pasagerii isi iau locurile in avion.");
    }

    protected override void TakeOff()
    {
        Console.WriteLine("Avionul decoleaza de pe pista.");
    }

    protected override void Land()
    {
        Console.WriteLine("Avionul aterizeaza pe aeroportul de destinatie.");
    }
}

class HelicopterFlight : TravelProcess
{
    protected override void CheckIn()
    {
        Console.WriteLine("Pasagerii se prezinta la heliport.");
    }

    protected override void SecurityCheck()
    {
        Console.WriteLine("Pasagerii trec prin controlul de securitate.");
    }

    protected override void Boarding()
    {
        Console.WriteLine("Pasagerii urc in elicopter.");
    }

    protected override void TakeOff()
    {
        Console.WriteLine("Elicopterul decoleaza.");
    }

    protected override void Land()
    {
        Console.WriteLine("Elicopterul aterizeaza la destinatie.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Zbor cu avionul:");
        TravelProcess airportFlight = new AirportFlight();
        airportFlight.Travel();

        Console.WriteLine();

        Console.WriteLine("Zbor cu elicopterul:");
        TravelProcess helicopterFlight = new HelicopterFlight();
        helicopterFlight.Travel();

        Console.ReadLine();
    }
}
