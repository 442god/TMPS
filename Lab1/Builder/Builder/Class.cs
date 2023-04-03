using System;
using System.Collections.Generic;

// Produsul final, meniul restaurantului
public class Menu
{
    private List<string> _appetizers = new List<string>();
    private List<string> _mains = new List<string>();
    private List<string> _desserts = new List<string>();

    public void AddAppetizer(string appetizer)
    {
        _appetizers.Add(appetizer);
    }

    public void AddMain(string main)
    {
        _mains.Add(main);
    }

    public void AddDessert(string dessert)
    {
        _desserts.Add(dessert);
    }

    public void Show()
    {
        Console.WriteLine("====== Meniu restaurant ======");
        Console.WriteLine("Aperitive:");
        foreach (string appetizer in _appetizers)
        {
            Console.WriteLine("- " + appetizer);
        }

        Console.WriteLine("\nFeluri principale:");
        foreach (string main in _mains)
        {
            Console.WriteLine("- " + main);
        }

        Console.WriteLine("\nDeserturi:");
        foreach (string dessert in _desserts)
        {
            Console.WriteLine("- " + dessert);
        }
    }
}

public interface IMenuBuilder
{
    void BuildAppetizers();
    void BuildMains();
    void BuildDesserts();
    Menu GetMenu();
}

public class VegetarianMenuBuilder : IMenuBuilder
{
    private Menu _menu = new Menu();

    public void BuildAppetizers()
    {
        _menu.AddAppetizer("Salată Caesar");
    }

    public void BuildMains()
    {
        _menu.AddMain("Burger vegetarian");
    }

    public void BuildDesserts()
    {
        _menu.AddDessert("Tort de fructe");
    }

    public Menu GetMenu()
    {
        return _menu;
    }
}

public class NonVegetarianMenuBuilder : IMenuBuilder
{
    private Menu _menu = new Menu();

    public void BuildAppetizers()
    {
        _menu.AddAppetizer("Bruschette");
    }

    public void BuildMains()
    {
        _menu.AddMain("Pui la grătar");
    }

    public void BuildDesserts()
    {
        _menu.AddDessert("Cheesecake");
    }

    public Menu GetMenu()
    {
        return _menu;
    }
}

public class MenuDirector
{
    private IMenuBuilder _builder;

    public MenuDirector(IMenuBuilder builder)
    {
        _builder = builder;
    }

    public void ConstructMenu()
    {
        _builder.BuildAppetizers();
        _builder.BuildMains();
        _builder.BuildDesserts();
    }
}
