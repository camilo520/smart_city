using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicaApartamentos : MonoBehaviour
{
    public AudioSource _audioSource;
    private static MusicaApartamentos playerInstance;

    private void Start()
    {

    }
    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
        _audioSource = GetComponent<AudioSource>();

        if (playerInstance == null)
        {
            playerInstance = this;
        }
        else
        {
            DestroyObject(gameObject);
        }
    }

        public void PlayMusic()
        {
            if (_audioSource.isPlaying) return;
            _audioSource.Play();
        }

        public void StopMusic()
        {
            _audioSource.Stop();
        }
}
