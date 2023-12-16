namespace PatternStrategy;

public class SteakCooking:CookStrategy
{
    public override void Cook()
    {
        Console.WriteLine("Повар готовит стейк...");
    }
}