using System;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {
        // Construirea meniului vegetarian
        IMenuBuilder vegetarianBuilder = new VegetarianMenuBuilder();
        MenuDirector vegetarianDirector = new MenuDirector(vegetarianBuilder);
        vegetarianDirector.ConstructMenu();
        Menu vegetarianMenu = vegetarianBuilder.GetMenu();
        vegetarianMenu.Show();

        Console.WriteLine();

    }
}
