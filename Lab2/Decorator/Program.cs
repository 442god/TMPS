using System;

public interface IPasager
{
    void CheckIn();
}

public class Pasager : IPasager
{
    public void CheckIn()
    {
        Console.WriteLine("Pasagerul a fost înregistrat.");
    }
}

public abstract class Decorator : IPasager
{
    private IPasager _pasager;

    public Decorator(IPasager pasager)
    {
        _pasager = pasager;
    }

    public virtual void CheckIn()
    {
        _pasager.CheckIn();
    }
}

public class PasagerCuBagaj : Decorator
{
    public PasagerCuBagaj(IPasager pasager) : base(pasager)
    {
    }

    public override void CheckIn()
    {
        base.CheckIn();
        Console.WriteLine("Pasagerul a depus bagajul.");
    }
}

public class PasagerVIP : Decorator
{
    public PasagerVIP(IPasager pasager) : base(pasager)
    {
    }

    public override void CheckIn()
    {
        base.CheckIn();
        Console.WriteLine("Pasagerul a fost upgrade-uit la clasa VIP.");
    }
}

public class Program
{
    public static void Main()
    {
        IPasager pasager1 = new Pasager();
        pasager1.CheckIn();
        Console.WriteLine();

        IPasager pasager2 = new PasagerCuBagaj(pasager1);
        pasager2.CheckIn();
        Console.WriteLine();

        IPasager pasager3 = new PasagerVIP(pasager2);
        pasager3.CheckIn();
        Console.WriteLine();

    }
}
