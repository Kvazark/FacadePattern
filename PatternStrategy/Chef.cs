namespace PatternStrategy;

public class Chef
{
    private CookStrategy cookStrategy;

    public void SetCookStrategy(CookStrategy cookStrategy)
    {
        this.cookStrategy = cookStrategy;
    }

    public void Cook()
    {
        cookStrategy.Cook();
    }
}