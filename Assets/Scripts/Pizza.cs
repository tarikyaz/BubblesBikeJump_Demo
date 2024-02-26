using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pizza : MonoBehaviour
{
    public void Create()
    {
        gameObject.SetActive(true);
    }

    public void Collect()
    {
        AudioManager.Instance.PlatSound(AudioManager.SoundsEnum.PizzaCollected);
        GameData.pizzasCollected++;
        GameEvents.CallPizzaCountChanged();
        gameObject.SetActive(false);
    }
}
