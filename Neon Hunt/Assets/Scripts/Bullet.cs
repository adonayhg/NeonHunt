using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public ObjectPool bulletPool; // Referencia al pool de balas
    public float bulletSpeed = 20f;

    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Este m�todo se llama cuando la bala colisiona con otro objeto
    private void OnCollisionEnter(Collision collision)
    {
        // Si colisiona con cualquier objeto, desact�vala
        DeactivateBullet();
    }

    // M�todo para desactivar la bala y devolverla al pool
    private void DeactivateBullet()
    {
        gameObject.SetActive(false); // Desactiva la bala
        bulletPool.Push(gameObject);  // La regresa al pool
    }
}
