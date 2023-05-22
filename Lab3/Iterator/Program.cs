using System;
using System.Collections.Generic;

// Element - Produs
public abstract class Produs
{
    public string Nume { get; set; }
    public double Pret { get; set; }

    public abstract void Accept(IVisitor visitor);
}

// Element concret - Carte
public class Carte : Produs
{
    public string Autor { get; set; }
    public int NumarPagini { get; set; }

    public override void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}

// Element concret - Electronice
public class Electronice : Produs
{
    public string Brand { get; set; }
    public string Model { get; set; }

    public override void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}

// Vizitator - IVisitor
public interface IVisitor
{
    void Visit(Carte carte);
    void Visit(Electronice electronice);
}

// Vizitator concret - VizitatorPret
public class VizitatorPret : IVisitor
{
    public void Visit(Carte carte)
    {
        Console.WriteLine($"Prețul cărții '{carte.Nume}': {carte.Pret} lei");
    }

    public void Visit(Electronice electronice)
    {
        Console.WriteLine($"Prețul produsului electronic '{electronice.Nume}': {electronice.Pret} lei");
    }
}

// Exemplu de utilizare
public class Program
{
    public static void Main(string[] args)
    {
        var produse = new List<Produs>
        {
            new Carte { Nume = "Mândrie și Prejudecată", Autor = "Jane Austen", NumarPagini = 300, Pret = 29.99 },
            new Electronice { Nume = "Telefon", Brand = "Samsung", Model = "Galaxy S21", Pret = 2499.99 }
        };

        var vizitatorPret = new VizitatorPret();

        foreach (var produs in produse)
        {
            produs.Accept(vizitatorPret);
        }

        Console.ReadLine();
    }
}
