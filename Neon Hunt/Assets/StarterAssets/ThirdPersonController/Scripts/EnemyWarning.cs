using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EnemyWarning : MonoBehaviour
{
    public float rangoDeteccion = 10f; // Distancia en la que se activa la alerta
    public LayerMask enemyLayer; // Capa de los enemigos
    public GameObject aviso;
    private bool avisoActivo = false;

    private void Start()
    {
        aviso.SetActive(false);
    }

    private void Update()
    {
        // Buscar enemigos dentro del radio de detección
        Collider[] enemigosCercanos = Physics.OverlapSphere(transform.position, rangoDeteccion, enemyLayer);

        if (enemigosCercanos.Length > 0 && !avisoActivo)
        {
            ActivarAviso();
        }
        else if (enemigosCercanos.Length == 0 && avisoActivo)
        {
            DesactivarAviso();
        }
    }

    private void ActivarAviso()
    {
        aviso.SetActive(true);
        avisoActivo = true;
    }

    private void DesactivarAviso()
    {
        aviso.SetActive(false);
        avisoActivo = false;
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, rangoDeteccion);
    }
}
