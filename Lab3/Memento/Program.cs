using System;

// Originator - StareZbor
public class StareZbor
{
    private string locatie;
    private DateTime dataPlecare;

    public StareZbor(string locatie, DateTime dataPlecare)
    {
        this.locatie = locatie;
        this.dataPlecare = dataPlecare;
    }

    public void SetLocatie(string locatie)
    {
        this.locatie = locatie;
    }

    public void SetDataPlecare(DateTime dataPlecare)
    {
        this.dataPlecare = dataPlecare;
    }

    public Memento CreazaMemento()
    {
        return new Memento(locatie, dataPlecare);
    }

    public void RestaureazaMemento(Memento memento)
    {
        locatie = memento.Locatie;
        dataPlecare = memento.DataPlecare;
    }

    public void AfiseazaStare()
    {
        Console.WriteLine($"Zborul cu destinația {locatie} pleacă pe data de {dataPlecare}");
    }
}

// Memento - MementoZbor
public class Memento
{
    public string Locatie { get; private set; }
    public DateTime DataPlecare { get; private set; }

    public Memento(string locatie, DateTime dataPlecare)
    {
        Locatie = locatie;
        DataPlecare = dataPlecare;
    }
}

// Caretaker - ManagerStari
public class ManagerStari
{
    private Memento memento;

    public void SetMemento(Memento memento)
    {
        this.memento = memento;
    }

    public Memento GetMemento()
    {
        return memento;
    }
}

// Exemplu de utilizare
public class Program
{
    public static void Main(string[] args)
    {
        // Crearea stării inițiale a zborului
        var stareZbor = new StareZbor("Paris", new DateTime(2023, 10, 15));

        // Salvarea stării zborului
        var managerStari = new ManagerStari();
        managerStari.SetMemento(stareZbor.CreazaMemento());

        // Modificarea stării zborului
        stareZbor.SetLocatie("Londra");
        stareZbor.SetDataPlecare(new DateTime(2023, 11, 20));

        // Afisarea starii zborului
        stareZbor.AfiseazaStare();

        // Restaurarea stării anterioare a zborului
        stareZbor.RestaureazaMemento(managerStari.GetMemento());

        // Afisarea starii zborului dupa restaurare
        stareZbor.AfiseazaStare();

        Console.ReadLine();
    }
}
