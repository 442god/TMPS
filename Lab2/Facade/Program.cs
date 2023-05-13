public class AeroportFacade
{
    private readonly CheckInSystem _checkInSystem;
    private readonly SecuritySystem _securitySystem;
    private readonly BoardingSystem _boardingSystem;

    public AeroportFacade()
    {
        _checkInSystem = new CheckInSystem();
        _securitySystem = new SecuritySystem();
        _boardingSystem = new BoardingSystem();
    }

    public void CheckInAndBoardPassenger(string name, string passportNumber, string destination)
    {
        _checkInSystem.CheckIn(name, passportNumber);
        _securitySystem.PerformSecurityCheck(name, passportNumber);
        _boardingSystem.BoardPassenger(name, passportNumber, destination);
    }
}

public class CheckInSystem
{
    public void CheckIn(string name, string passportNumber)
    {
        Console.WriteLine("Efectuati check-in pentru pasagerul cu numele {0} si numarul de pasaport {1}", name, passportNumber);
    }
}

public class SecuritySystem
{
    public void PerformSecurityCheck(string name, string passportNumber)
    {
        Console.WriteLine("Se efectueaza verificarea de securitate pentru pasagerul cu numele {0} si numarul de pasaport {1}", name, passportNumber);
    }
}

public class BoardingSystem
{
    public void BoardPassenger(string name, string passportNumber, string destination)
    {
        Console.WriteLine("Imbarcare pasager {0} cu numarul de pasaport {1} pentru destinatia {2}", name, passportNumber, destination);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        AeroportFacade aeroport = new AeroportFacade();

        aeroport.CheckInAndBoardPassenger("Andrei Josan", "B12345", "Paris");

        Console.ReadKey();
    }
}
