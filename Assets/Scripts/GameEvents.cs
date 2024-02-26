using System;

public static class GameEvents
{
    public static Action OnPizzaCountChanged;
    public static Action OnStarCountChanged;


    public static void CallPizzaCountChanged()
    {
        OnPizzaCountChanged?.Invoke();
    }
    public static void CallStarCountChanged()
    {
        OnStarCountChanged?.Invoke();
    }
}
