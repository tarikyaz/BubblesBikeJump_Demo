using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance { get; private set; }

    [SerializeField] private AudioSource audioSource;
    [SerializeField] AudioClip pizzaCollected, starCollected, jump, levelComplete;
    public enum SoundsEnum {
    None, PizzaCollected , StarColleced,Jump,LevelComplete
    }
    public void PlatSound(SoundsEnum sound)
    {
        AudioClip clip;
        switch (sound)
        {
            case SoundsEnum.PizzaCollected:
                clip = pizzaCollected;
                break;
            case SoundsEnum.StarColleced:
                clip = starCollected;
                break;
            case SoundsEnum.Jump:
                clip = jump;
                break;
            case SoundsEnum.LevelComplete:
                clip = levelComplete;
                break;
            default:
                clip = null;
                break;
        }
        audioSource.PlayOneShot(clip);
    }
    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {

    }
    
    private void Update()
    {
        
    }
}
