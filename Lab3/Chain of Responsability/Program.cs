public class Passenger
{
    public bool HasValidTicket { get; set; }
    public bool HasValidBoardingPass { get; set; }
    public bool HasValidSecurityCheck { get; set; }

    public Passenger(bool hasValidTicket, bool hasValidBoardingPass, bool hasValidSecurityCheck)
    {
        HasValidTicket = hasValidTicket;
        HasValidBoardingPass = hasValidBoardingPass;
        HasValidSecurityCheck = hasValidSecurityCheck;
    }
}

public interface IAirportHandler
{
    void HandleRequest(Passenger passenger);
    void SetSuccessor(IAirportHandler successor);
}

public class TicketCheckHandler : IAirportHandler
{
    private IAirportHandler successor;

    public void SetSuccessor(IAirportHandler successor)
    {
        this.successor = successor;
    }

    public void HandleRequest(Passenger passenger)
    {
        if (passenger.HasValidTicket)
        {
            Console.WriteLine("Biletul este valid.");
            successor?.HandleRequest(passenger);
        }
        else
        {
            Console.WriteLine("Biletul este invalid.");
        }
    }
}

public class BoardingPassCheckHandler : IAirportHandler
{
    private IAirportHandler successor;

    public void SetSuccessor(IAirportHandler successor)
    {
        this.successor = successor;
    }

    public void HandleRequest(Passenger passenger)
    {
        if (passenger.HasValidBoardingPass)
        {
            Console.WriteLine("Boarding pass-ul este valid.");
            successor?.HandleRequest(passenger);
        }
        else
        {
            Console.WriteLine("Boarding pass-ul este invalid.");
        }
    }
}

public class SecurityCheckHandler : IAirportHandler
{
    public void SetSuccessor(IAirportHandler successor)
    {
        throw new NotSupportedException("SecurityCheckHandler nu poate avea un succesor.");
    }

    public void HandleRequest(Passenger passenger)
    {
        if (passenger.HasValidSecurityCheck)
        {
            Console.WriteLine("Controlul de securitate a fost trecut cu succes.");
        }
        else
        {
            Console.WriteLine("Controlul de securitate a esuat.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        IAirportHandler ticketCheckHandler = new TicketCheckHandler();
        IAirportHandler boardingPassCheckHandler = new BoardingPassCheckHandler();
        IAirportHandler securityCheckHandler = new SecurityCheckHandler();

        ticketCheckHandler.SetSuccessor(boardingPassCheckHandler);
        boardingPassCheckHandler.SetSuccessor(securityCheckHandler);

        Passenger passenger = new Passenger(hasValidTicket: true, hasValidBoardingPass: true, hasValidSecurityCheck: true);

        ticketCheckHandler.HandleRequest(passenger);
    }
}
