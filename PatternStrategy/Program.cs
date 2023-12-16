using PatternStrategy;

public class Program
{
    private static void Main(string[] args)
    {
        Chef chef = new Chef();
        chef.SetCookStrategy(new SteakCooking());
        chef.Cook();
        chef.SetCookStrategy(new PizzaCooking());
        chef.Cook();
        chef.SetCookStrategy(new DessertCooking());
        chef.Cook();
    }
}