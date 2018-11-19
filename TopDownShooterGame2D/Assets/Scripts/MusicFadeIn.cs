﻿using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class MusicFadeIn : MonoBehaviour
{
    [SerializeField]
    private int m_FadeInTime = 10;
    private AudioSource m_AudioSource;


    private void Awake()
    {
        m_AudioSource = GetComponent<AudioSource>();
    }


    private void Update()
    {
        if (m_AudioSource.volume < 0.2)
        {
            m_AudioSource.volume = m_AudioSource.volume + (Time.deltaTime / (m_FadeInTime + 1));
        }
        else
        {
            Destroy(this);
        }
    }
}