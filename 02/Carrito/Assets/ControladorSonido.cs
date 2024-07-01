using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorSonido : MonoBehaviour
{
    // Start is called before the first frame update
    public static ControladorSonido Instance;
    private AudioSource audioSource;
    
    public void Awake()
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
        audioSource = GetComponent<AudioSource>();
    }

    public void EjecutarSonido(AudioClip sonido)
{
    if(audioSource != null)
    {
        audioSource.PlayOneShot(sonido);
    }
    else
    {
        Debug.LogWarning("AudioSource no está asignado.");
    }
}
    
}
