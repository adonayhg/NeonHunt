using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float tiempoRestante = 420f; // 7 minutos en segundos
    public TextMeshProUGUI textoTiempo;
    private bool tiempoAgotado = false;

    public static GameManager instance { get; private set; }


    void Start()
    {

    }

    void Update()
    {
        if (!tiempoAgotado)
        {
            tiempoRestante -= Time.deltaTime;
            ActualizarTextoTiempo();

            if (tiempoRestante <= 0)
            {
                tiempoRestante = 0;
                tiempoAgotado = true;
                MostrarPantallaPerdiste();
            }
        }
    }

    void ActualizarTextoTiempo()
    {
        int minutos = Mathf.FloorToInt(tiempoRestante / 60);
        int segundos = Mathf.FloorToInt(tiempoRestante % 60);
        textoTiempo.text = $"{minutos:D2}:{segundos:D2}";
    }

    public void MostrarPantallaPerdiste()
    {
        SceneManager.LoadScene("Final");
        Time.timeScale = 0;
    }

}
