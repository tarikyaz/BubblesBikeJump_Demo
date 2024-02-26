using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
    public void Create()
    {
        gameObject.SetActive(true);
    }

    public void Collect()
    {
        AudioManager.Instance.PlatSound(AudioManager.SoundsEnum.StarColleced);
        GameData.starsCollected++;
        GameEvents.CallStarCountChanged();
        gameObject.SetActive(false);
    }
}
