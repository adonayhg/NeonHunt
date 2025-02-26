using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip sonidoDisparo;
    public AudioClip sonidoExplosion;
    public AudioClip sonidoMovimiento;
    public AudioClip sonidoAlarma;




    public static SoundManager instance;

    private void Awake()
    {
        instance = this;
    }

    public void ReproducirSonidoDisparo()
    {
        audioSource.PlayOneShot(sonidoDisparo);
    }
    public void ReproducirSonidoExplosion()
    {
        audioSource.PlayOneShot(sonidoExplosion);
    }
    public void ReproducirSonidoMovimiento()
    {
        audioSource.PlayOneShot(sonidoMovimiento);
    }
    public void ReproducirSonidoAlarma()
    {
        audioSource.PlayOneShot(sonidoAlarma);
    }
}