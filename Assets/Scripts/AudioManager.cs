using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioClip musicBgm;
    public AudioClip musicEffect;
    public AudioListener audioListener;
    public AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        audioListener = GetComponent<AudioListener>();
    }

    public void PlayBackgroundMusic()
    {
        audioSource.PlayOneShot(musicBgm);
    }

    public void PlayEffect()
    {
        audioSource.PlayOneShot(musicEffect);
    }
}
