using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    public GameObject BotonJugar;
    public GameObject BotonOptions;
    public GameObject BotonExit;
    public GameObject PopUpOptions;
    public GameObject Sliders;
    public GameObject Logo;

    public GameObject canvasPerdiste;


    /* [SerializeField] Slider sliderMusica;
     [SerializeField] float volumenMusica;
     [SerializeField] float recordScore;*/


    void Start()
    {        

        // Configuración inicial del volumen
        /*sliderMusica.value = PlayerPrefs.GetFloat("volumenAudio", 0.5f);
        MusicManager musicManager = FindObjectOfType<MusicManager>();
        if (musicManager != null)
        {
            musicManager.SetVolume(sliderMusica.value);
        }
        recordScore = PlayerPrefs.GetInt("Player Score");*/

    }


    /*public void ChangeSlider(float valor)
    {
        volumenMusica = valor;
        PlayerPrefs.SetFloat("volumenAudio", volumenMusica);

        MusicManager musicManager = FindObjectOfType<MusicManager>();
        if (musicManager != null)
        {
            musicManager.SetVolume(sliderMusica.value);
        }
    }*/

    public void Play()
    {
        SceneManager.LoadScene("BaseScene");
    }

    public void Options()
    {
        PopUpOptions.SetActive(true);
    }

    public void CerrarOptions()
    {
        PopUpOptions.SetActive(false);
    }

    public void Exit()
    {
        Application.Quit();
    }
    public void ReStart()
    {
        SceneManager.LoadScene("BaseScene");
    }
    public void Menu()
    {
        SceneManager.LoadScene("UI");
    }
}

