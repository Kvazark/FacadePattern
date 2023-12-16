namespace PatternStrategy;

public class PizzaCooking : CookStrategy
{
    public override void Cook()
    {
        Console.WriteLine("Повар готовит пиццу...");
    }
}