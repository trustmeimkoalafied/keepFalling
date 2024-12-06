using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource waterdropsSource;
    [SerializeField] AudioSource heartbeatSource;
    [SerializeField] AudioSource extraSource;

    public AudioClip background;
    public AudioClip waterdrops;
    public AudioClip heartbeat;
    public AudioClip extra;

    private void Start()
    {
        // Set the clips for each AudioSource
        musicSource.clip = background;
        waterdropsSource.clip = waterdrops;
        heartbeatSource.clip = heartbeat;
        extraSource.clip = extra;

        // Play each AudioSource
        musicSource.Play();
        waterdropsSource.Play();
        heartbeatSource.Play();
        extraSource.Play();
    }
}

