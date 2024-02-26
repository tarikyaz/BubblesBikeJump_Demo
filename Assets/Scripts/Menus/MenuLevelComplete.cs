﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MenuLevelComplete : IMenu
{
    [SerializeField] private Button homeButton;
    [SerializeField] private Button retryButton;

    [SerializeField] private TextMeshProUGUI pizzasCollectedText;
    [SerializeField] private TextMeshProUGUI starsCollectedText;

    
    private void Start()
    {
        homeButton.onClick.AddListener(HomeOnClick);
        retryButton.onClick.AddListener(RetryOnClick);
    }

    public override void Show()
    {
        base.Show();
        AudioManager.Instance.PlatSound(AudioManager.SoundsEnum.LevelComplete);
        pizzasCollectedText.text = $"Pizzas Collected: {GameData.pizzasCollected}/25";
        starsCollectedText.text = $"Stars Collected: {GameData.starsCollected}/3";
    }

    private void HomeOnClick()
    {
        NMenuManager.Manager.ClearToMainMenu();
    }

    private void RetryOnClick()
    {
        NMenuManager.Manager.ClearToMainMenu();
        NMenuManager.Manager.StartGame();
    }
}
