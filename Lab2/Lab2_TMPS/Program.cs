public interface IBagajComponent
{
    string Nume { get; }
    double CalculeazaGreutate();
    void AfiseazaDetalii(int nivel);
}

public class Bagaj : IBagajComponent
{
    private List<IBagajComponent> _componente = new List<IBagajComponent>();

    public string Nume { get; }

    public Bagaj(string nume)
    {
        Nume = nume;
    }

    public void AdaugaComponenta(IBagajComponent componenta)
    {
        _componente.Add(componenta);
    }

    public void StergeComponenta(IBagajComponent componenta)
    {
        _componente.Remove(componenta);
    }

    public double CalculeazaGreutate()
    {
        double greutate = 0;

        foreach (var componenta in _componente)
        {
            greutate += componenta.CalculeazaGreutate();
        }

        return greutate;
    }

    public void AfiseazaDetalii(int nivel)
    {
        Console.WriteLine(new string('-', nivel) + Nume + $" ({CalculeazaGreutate()} kg)");

        foreach (var componenta in _componente)
        {
            componenta.AfiseazaDetalii(nivel + 1);
        }
    }
}

public class Obiect : IBagajComponent
{
    public string Nume { get; }
    public double Greutate { get; }

    public Obiect(string nume, double greutate)
    {
        Nume = nume;
        Greutate = greutate;
    }

    public double CalculeazaGreutate()
    {
        return Greutate;
    }

    public void AfiseazaDetalii(int nivel)
    {
        Console.WriteLine(new string('-', nivel) + Nume + $" ({CalculeazaGreutate()} kg)");
    }
}

class Program
{
    static void Main(string[] args)
    {
        var bagajPrincipal = new Bagaj("Bagaj principal");

        var obiect1 = new Obiect("Obiect 1", 10);
        bagajPrincipal.AdaugaComponenta(obiect1);

        var obiect2 = new Obiect("Obiect 2", 5);
        bagajPrincipal.AdaugaComponenta(obiect2);

        var bagajMic = new Bagaj("Bagaj mic");

        var obiect3 = new Obiect("Obiect 3", 2);
        bagajMic.AdaugaComponenta(obiect3);

        bagajPrincipal.AdaugaComponenta(bagajMic);

        bagajPrincipal.AfiseazaDetalii(0);

        Console.ReadKey();
    }
}

