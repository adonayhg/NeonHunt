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

    public GameObject canvasGanaste;
    public TextMeshProUGUI textoPuntosFinal;
    private bool juegoGanado = false;



    public static GameManager instance { get; private set; }

    private void Awake()
    {
        instance = this;
    }


    void Start()
    {
        canvasGanaste.SetActive(false);
        Time.timeScale = 1;
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
        Cursor.lockState = CursorLockMode.None;
    }
    public void GanarJuego()
    {
        if (juegoGanado) return; //Si ya se gane, no repetir la ejecución
        juegoGanado = true; // Marcar el juego como ganado
        Time.timeScale = 0; // Pausar el tiempo
        int segundosRestantes = Mathf.FloorToInt(tiempoRestante); // Convertir a entero
        int puntosExtra = segundosRestantes * 10; // Multiplicar por 10
        ScoreManager.instance.AddPoints(puntosExtra); // Sumar al puntaje
        textoPuntosFinal.text = "Score" + ScoreManager.instance.textoPuntos.text;
        Cursor.lockState = CursorLockMode.None;
        canvasGanaste.SetActive(true);
    }
}
