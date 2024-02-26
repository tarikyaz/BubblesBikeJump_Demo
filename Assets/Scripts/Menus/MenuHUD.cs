using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class MenuHUD : IMenu
{
    [SerializeField] private Button pauseButton;

    [SerializeField] private TextMeshProUGUI pizzasCollectedText;
    [SerializeField] private TextMeshProUGUI starsCollectedText;


    private void Start()
    {
        pauseButton.onClick.AddListener(PauseOnClick);
        RefreshScore();
    }
    private void OnEnable()
    {
        GameEvents.OnPizzaCountChanged += OnPizzaCollectedHandler;
        GameEvents.OnStarCountChanged += OnStarCollectedHandler;

    }
    private void OnDisable()
    {
        GameEvents.OnPizzaCountChanged += OnPizzaCollectedHandler;
        GameEvents.OnStarCountChanged += OnStarCollectedHandler;
    }

    private void OnPizzaCollectedHandler()
    {
        pizzasCollectedText.text = $"Pizzas Collected: {GameData.pizzasCollected}/25";
    }

    private void OnStarCollectedHandler()
    {
        starsCollectedText.text = $"Stars Collected: {GameData.starsCollected}/3";
    }
     private void RefreshScore()
    {
        pizzasCollectedText.text = $"Pizzas Collected: {0}/25";
        starsCollectedText.text = $"Stars Collected: {0}/3";
    }
    public override void Show()
    {
        base.Show();
        GameData.isPaused = false;
    }

    private void PauseOnClick()
    {
        GameData.isPaused = true;
        NMenuManager.Manager.ShowPauseMenu();
    }
}
