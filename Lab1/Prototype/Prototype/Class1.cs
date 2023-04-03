// Clasa abstractă pentru toate meniurile
abstract class Menu
{
    public string name;
    public List<string> items;

    public Menu(string name, List<string> items)
    {
        this.name = name;
        this.items = items;
    }

    // Metoda Clone
    public abstract Menu Clone();

    // Metoda virtuală
    public virtual void DisplayMenu()
    {
        Console.WriteLine("Meniu: {0}\n", name);
        Console.WriteLine("Produse:");
        foreach (string item in items)
        {
            Console.WriteLine("- {0}", item);
        }
        Console.WriteLine();
    }
}

// Clasa pentru meniul de mic dejun
class BreakfastMenu : Menu
{
    public BreakfastMenu(string name, List<string> items) : base(name, items)
    {
    }

    // Implementarea metodei Clone
    public override Menu Clone()
    {
        return (Menu)this.MemberwiseClone();
    }
}

// Clasa pentru meniul de prânz
class LunchMenu : Menu
{
    public LunchMenu(string name, List<string> items) : base(name, items)
    {
    }

    // Implementarea metodei Clone
    public override Menu Clone()
    {
        return (Menu)this.MemberwiseClone();
    }
}
