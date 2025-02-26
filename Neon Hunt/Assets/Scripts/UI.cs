using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    public GameObject BotonJugar;
    public GameObject BotonExit;
    public GameObject Sliders;
    public GameObject Logo;

    public GameObject canvasPerdiste;

    public void Play()
    {
        SceneManager.LoadScene("BaseScene");
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

