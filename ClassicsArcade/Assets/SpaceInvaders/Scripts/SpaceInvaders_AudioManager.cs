using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceInvaders_AudioManager : MonoBehaviour
{
    // Create a singleton 
    public static SpaceInvaders_AudioManager Instance;


    [SerializeField] private AudioSource _musicSource, _effectsSource;
    [SerializeField] private AudioClip _explosion, _laser, _music, _lose;


    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        PlayMusic();
    }


    public void PlayExplosion()
    {
        _effectsSource.PlayOneShot(_explosion);
    }

    public void PlayLaser()
    {
        _effectsSource.PlayOneShot(_laser);
    }

    void PlayMusic()
    {
            _musicSource.PlayOneShot(_music);
    }
    public void DisableMusic()
    {
        _musicSource.enabled = false;
    }

    public void PlayLose()
    {
        _effectsSource.PlayOneShot(_lose);
        
    }
}
