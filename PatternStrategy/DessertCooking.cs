namespace PatternStrategy;

public class DessertCooking:CookStrategy
{
    public override void Cook()
    {
        Console.WriteLine("Повар готовит десерт...");
    }
}