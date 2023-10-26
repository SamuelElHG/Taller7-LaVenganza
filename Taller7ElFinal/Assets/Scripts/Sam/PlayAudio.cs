using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudio : MonoBehaviour
{
    public static PlayAudio instance;
    public bool isMute = false;
    [SerializeField] private AudioSource m_AudioSource;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
    private void Start()
    {
        m_AudioSource = GetComponent<AudioSource>();
    }

    public void playSound(AudioClip AClip, float volume)
    {
        m_AudioSource.PlayOneShot(AClip, volume);
        Debug.Log("working");
        
    }
}
