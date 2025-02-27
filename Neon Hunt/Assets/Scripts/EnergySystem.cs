using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class EnergySystem : MonoBehaviour
{
    public float energia = 100;
    public float energiaConsumida = 33;
    public bool disparoPosible = false;
    public TextMeshProUGUI textoEnergia;

    public float tiempoUltimoDisparo = 0;
    public float tiempoPowerUp = 30;
    public bool powerUp = false;


    public static EnergySystem instance { get; private set; }
    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        ActualizarTextoEnergia();
    }

    // Update is called once per frame
    void Update()
    {
        if (energia < energiaConsumida)
        {
            disparoPosible = false;
        }

        if (energia > energiaConsumida)
        {
            disparoPosible = true;
        }

        if (tiempoUltimoDisparo > 10)
        {
            ActualizarTextoEnergia();
            AumentoEnergia();
        }

        ActualizarTiempoDisparo();

        if ( energia > 100)
        {
            energia = 100;
            ActualizarTextoEnergia();
        }
        if (powerUp == true)
        {
            tiempoPowerUp -= Time.deltaTime;
            energia++;

        }
        if( tiempoPowerUp < 0 )
        {
            powerUp = false;
        }
    }

    public void Disparo()
    {
        if (disparoPosible)
        {
            energia = energia - energiaConsumida;
            ActualizarTextoEnergia();
            tiempoUltimoDisparo = 0;
        }
    }

    public void ActualizarTiempoDisparo()
    {
        tiempoUltimoDisparo += Time.deltaTime;
    }

    public void ActualizarTextoEnergia()
    {
        textoEnergia.text = " " + energia + "%";

    }

    public void Energia100()
    {
        energia = 100;
        ActualizarTextoEnergia();
    }

    public void Energia30s()
    {
        powerUp = true;
        ActualizarTextoEnergia();
    }

    public void AumentoEnergia()
    {
        energia += Time.deltaTime * 3;
    }

}
