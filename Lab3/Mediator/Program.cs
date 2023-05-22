public interface IAirportMediator
{
    void RegisterAirportParticipant(IAirportParticipant participant);
    void SendMessage(string message, IAirportParticipant sender);
}

public interface IAirportParticipant
{
    void ReceiveMessage(string message);
    void SendMessage(string message);
}

public class AirportMediator : IAirportMediator
{
    private List<IAirportParticipant> participants;

    public AirportMediator()
    {
        participants = new List<IAirportParticipant>();
    }

    public void RegisterAirportParticipant(IAirportParticipant participant)
    {
        participants.Add(participant);
    }

    public void SendMessage(string message, IAirportParticipant sender)
    {
        foreach (var participant in participants)
        {
            if (participant != sender)
                participant.ReceiveMessage(message);
        }
    }
}

public class Airplane : IAirportParticipant
{
    private string name;
    private IAirportMediator mediator;

    public Airplane(string name, IAirportMediator mediator)
    {
        this.name = name;
        this.mediator = mediator;
    }

    public void ReceiveMessage(string message)
    {
        Console.WriteLine($"{name} a primit mesaj: {message}");
    }

    public void SendMessage(string message)
    {
        Console.WriteLine($"{name} trimite mesaj: {message}");
        mediator.SendMessage(message, this);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        var mediator = new AirportMediator();
        var airplane1 = new Airplane("Avionul 1", mediator);
        var airplane2 = new Airplane("Avionul 2", mediator);
        var airplane3 = new Airplane("Avionul 3", mediator);

        mediator.RegisterAirportParticipant(airplane1);
        mediator.RegisterAirportParticipant(airplane2);
        mediator.RegisterAirportParticipant(airplane3);

        airplane1.SendMessage("Salutare tuturor!");

        Console.ReadLine();
    }
}
