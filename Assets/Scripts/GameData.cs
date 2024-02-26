using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Used for storing Temporary data
/// </summary>
public static class GameData
{
    public static int pizzasCollected = 0;
    public static int starsCollected = 0;

    public static bool isPaused = true;

    
    public static void ResetData()
    {
        pizzasCollected = 0;
        starsCollected = 0;
        GameEvents.OnPizzaCountChanged();
        GameEvents.OnStarCountChanged();
    }
}
