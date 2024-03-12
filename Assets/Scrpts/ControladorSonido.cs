using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorSonido : MonoBehaviour
{
    public static ControladorSonido Instance;
    private AudioSource audioSource;

    private void Awake()
    {
        if (Instance == null)
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
        if (sonido != null)
        {
            audioSource.PlayOneShot(sonido);
        }
        else
        {
            Debug.LogWarning("Se intentó reproducir un sonido nulo.");
        }
    }
}
