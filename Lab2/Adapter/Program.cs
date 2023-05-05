using System;

interface IAvion
{
    void Decolare();
}

class AvionCuReactie : IAvion
{
    public void Decolare()
    {
        Console.WriteLine("Avionul cu reactie decoleaza.");
    }
}

class AvionCuElice
{
    public void DecolareCuElice()
    {
        Console.WriteLine("Avionul cu elice decoleaza.");
    }
}

class AdaptorAvionCuElice : IAvion
{
    private AvionCuElice avionCuElice;

    public AdaptorAvionCuElice(AvionCuElice avionCuElice)
    {
        this.avionCuElice = avionCuElice;
    }

    public void Decolare()
    {
        avionCuElice.DecolareCuElice();
    }
}

class Program
{
    static void Main(string[] args)
    {
        IAvion avionCuReactie = new AvionCuReactie();
        IAvion avionCuElice = new AdaptorAvionCuElice(new AvionCuElice());

        Console.WriteLine("Aeroportul porneste procedurile de decolare:");
        avionCuReactie.Decolare();
        avionCuElice.Decolare();
    }
}
