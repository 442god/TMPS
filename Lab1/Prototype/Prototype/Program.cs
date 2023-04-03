class Program
{
    public static void Main(string[] args)
    {
        List<string> breakfastItems = new List<string>();
        breakfastItems.Add("Oua ochiuri");
        breakfastItems.Add("Cascaval");
        breakfastItems.Add("Paine prajita");
        BreakfastMenu breakfastMenu = new BreakfastMenu("Mic dejun", breakfastItems);

        List<string> lunchItems = new List<string>();
        lunchItems.Add("Burger");
        lunchItems.Add("Cartofi prajiti");
        lunchItems.Add("Coca-Cola");
        LunchMenu lunchMenu = new LunchMenu("Prânz", lunchItems);

        breakfastMenu.DisplayMenu();
        lunchMenu.DisplayMenu();

        BreakfastMenu breakfastMenuCopy = (BreakfastMenu)breakfastMenu.Clone();
    }
}
