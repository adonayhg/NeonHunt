using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UIElements;
using System.Xml.Linq;

public class EnemiesContainer : MonoBehaviour
{
    int enemigosVivos;
    int enemigosTotales;
    [SerializeField] public TextMeshProUGUI NumeroEnemigos;
    public static EnemiesContainer instance { get; private set; }

    private void Awake()
    {
        instance = this;
    }


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        NumeroEnemigos.text = enemigosVivos.ToString() + "/" + enemigosTotales.ToString();
        if (enemigosVivos == 0)
        {
            GameManager.instance.GanarJuego();
        }
    }

    public void AddEnemie()
    {
        enemigosTotales++;
        enemigosVivos++;
    }
    public void RemoveEnemie()
    {
        enemigosVivos--;
        Debug.Log("Numero de enemigos =" + enemigosVivos + "/" + enemigosTotales);
    }

}
