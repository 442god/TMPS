public abstract class Ticket
{
    public abstract void PrintTicket();
}

public class ETicket : Ticket
{
    public override void PrintTicket()
    {
        Console.WriteLine("Tipărire bilet electronic...");
        Console.WriteLine("Biletul electronic a fost tipărit.");
    }
}

public class PhysicalTicket : Ticket
{
    public override void PrintTicket()
    {
        Console.WriteLine("Tipărire bilet fizic...");
        Console.WriteLine("Biletul fizic a fost tipărit.");
    }
}

public class TicketManager
{
    private List<Ticket> tickets;

    public TicketManager()
    {
        tickets = new List<Ticket>();
    }

    public void AddTicket(Ticket ticket)
    {
        tickets.Add(ticket);
    }

    public void PrintAllTickets()
    {
        foreach (var ticket in tickets)
        {
            ticket.PrintTicket();
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Ticket eTicket = new ETicket();
        Ticket physicalTicket = new PhysicalTicket();

        TicketManager ticketManager = new TicketManager();
        ticketManager.AddTicket(eTicket);
        ticketManager.AddTicket(physicalTicket);

        ticketManager.PrintAllTickets();
    }
}
