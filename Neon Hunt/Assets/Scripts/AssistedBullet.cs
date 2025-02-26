using System;
using UnityEngine;

public class AssistedBullet : MonoBehaviour
{
    public float detectionRadius = 10f; // Rango de detecci�n de enemigos
    public LayerMask enemyLayer; // Capa de los enemigos
    public float bulletSpeed = 20f; // Velocidad de la bala
    private Transform targetEnemy; // Enemigo al que se dirige la bala

    private Rigidbody rb; // Rigidbody de la bala
    private bool hasTarget = false; // Indica si la bala tiene un enemigo al que disparar

    public GameObject prefabExplosion;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (hasTarget && targetEnemy != null)
        {
            // Dirige la bala hacia el enemigo
            Vector3 direction = (targetEnemy.position - transform.position).normalized;
            rb.velocity = direction * bulletSpeed;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        // Si la bala colisiona con un enemigo, hacer algo (por ejemplo, aplicar da�o)
        if (collision.gameObject.CompareTag("Enemy"))
        {
            // Aqu� puedes aplicar el da�o al enemigo
            Debug.Log("Enemigo alcanzado: " + collision.gameObject.name);

            // Destruye el objeto enemigo
            Destroy(collision.gameObject);
            EnemiesContainer.instance.RemoveEnemie();
            ScoreManager.instance.AddPoints(2);
        }
        Instantiate(prefabExplosion, transform.position, Quaternion.identity);
        SoundManager.instance.ReproducirSonidoExplosion();
        ObjectPool.instance.Push(gameObject);
        ScoreManager.instance.RestPoints(2);


    }


    // Funci�n para asignar el enemigo m�s cercano
    public void AssignTarget(Vector3 position)
    {
        Collider[] enemiesInRange = Physics.OverlapSphere(position, detectionRadius, enemyLayer);

        Transform closestEnemy = null;
        float closestDistance = Mathf.Infinity;

        foreach (var enemy in enemiesInRange)
        {
            // Encontrar el enemigo m�s cercano al centro de la pantalla (mejor si el enemigo est� alineado con la c�mara)
            float distance = Vector3.Distance(position, enemy.transform.position);
            if (distance < closestDistance)
            {
                closestEnemy = enemy.transform;
                closestDistance = distance;
            }
        }

        // Si se encontr� un enemigo, asignarlo como objetivo
        if (closestEnemy != null)
        {
            targetEnemy = closestEnemy;
            hasTarget = true; // La bala ahora tiene un objetivo al que disparar
        }
    }

    // Funci�n para visualizar el rango de detecci�n (para depuraci�n)
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, detectionRadius);
    }

}
