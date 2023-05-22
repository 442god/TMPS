public interface ICommand
{
    void Execute();
}

public class Zbor
{
    public string Numar { get; set; }

    public void DeschidePoarta()
    {
        Console.WriteLine($"Poarta pentru zborul {Numar} a fost deschisa.");
    }

    public void InchidePoarta()
    {
        Console.WriteLine($"Poarta pentru zborul {Numar} a fost inchisa.");
    }
}

public class DeschiderePoartaCommand : ICommand
{
    private Zbor zbor;

    public DeschiderePoartaCommand(Zbor zbor)
    {
        this.zbor = zbor;
    }

    public void Execute()
    {
        zbor.DeschidePoarta();
    }
}

public class InchiderePoartaCommand : ICommand
{
    private Zbor zbor;

    public InchiderePoartaCommand(Zbor zbor)
    {
        this.zbor = zbor;
    }

    public void Execute()
    {
        zbor.InchidePoarta();
    }
}

public class ControlZboruri
{
    private List<ICommand> comenzi = new List<ICommand>();

    public void AdaugaComanda(ICommand comanda)
    {
        comenzi.Add(comanda);
    }

    public void ExecutaComenzi()
    {
        foreach (var comanda in comenzi)
        {
            comanda.Execute();
        }

        comenzi.Clear();
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        var zbor1 = new Zbor { Numar = "FL123" };
        var deschiderePoartaCommand1 = new DeschiderePoartaCommand(zbor1);
        var inchiderePoartaCommand1 = new InchiderePoartaCommand(zbor1);

        var zbor2 = new Zbor { Numar = "AZ456" };
        var deschiderePoartaCommand2 = new DeschiderePoartaCommand(zbor2);
        var inchiderePoartaCommand2 = new InchiderePoartaCommand(zbor2);

        var controlZboruri = new ControlZboruri();

        controlZboruri.AdaugaComanda(deschiderePoartaCommand1);
        controlZboruri.AdaugaComanda(inchiderePoartaCommand1);
        controlZboruri.AdaugaComanda(deschiderePoartaCommand2);
        controlZboruri.AdaugaComanda(inchiderePoartaCommand2);

        controlZboruri.ExecutaComenzi();

        Console.ReadLine();
    }
}
