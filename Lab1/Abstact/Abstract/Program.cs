class Program
{
    static void Main(string[] args)
    {
        ICarFactory luxuryCarFactory = new LuxuryCarFactory();


        ICar luxurySportsCar = luxuryCarFactory.CreateSportsCar();
        luxurySportsCar.Drive();

        ICar luxurySUV = luxuryCarFactory.CreateSUV();
        luxurySUV.Drive();

        ICarFactory economyCarFactory = new EconomyCarFactory();

        ICar economySportsCar = economyCarFactory.CreateSportsCar();
        economySportsCar.Drive();

        ICar economySUV = economyCarFactory.CreateSUV();
        economySUV.Drive();

        Console.ReadKey();
    }
}
