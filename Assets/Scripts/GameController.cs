using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController Instance { get; private set; }

    [SerializeField] private List<Pizza> pizzaList = new List<Pizza>();
    [SerializeField] private List<Star> starList = new List<Star>();

    [SerializeField] private PlayerController player;

    private void RefreshCollectibles()
    {
        foreach (var pizza in pizzaList)
        {
            pizza.Create();
        }
        foreach (var star in starList)
        {
            star.Create();
        }
    }

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        RestartGame();
    }
    
    public void RestartGame()
    {
        GameData.ResetData();
        
        player.ResetPlayer();
        RefreshCollectibles();
    }

    public void LevelComplete()
    {
        GameData.isPaused = true;
        NMenuManager.Manager.ShowLevelCompleteMenu();
    }
}
