using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI textoPuntos;
    private int score = 0; // Variable para almacenar los puntos

    public static ScoreManager instance { get; private set; }
    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        UpdateScoreText(); // Actualiza el texto al inicio
    }

    public void AddPoints(int points)
    {
        score += points;
        UpdateScoreText();
    }

    public void RestPoints(int points)
    {
        score -= points;
        UpdateScoreText();
    }

    private void UpdateScoreText()
    {
        textoPuntos.text = " " + score.ToString("D4"); // Actualiza el texto en la UI

    }
}