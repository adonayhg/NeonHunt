using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    [SerializeField]
    int maxHealth = 5;
    [SerializeField]
    int currentHealth = 2;
    Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        UpdateAnimator();
    }

    public void ModifyHealth(int amount)
    {
        if (currentHealth + amount <= 0)
        {
            currentHealth = 0;
            Debug.Log("MUERTO");
        }
        else if (currentHealth + amount >= maxHealth)
        {
            Debug.Log("Vida a tope");
            currentHealth = maxHealth;
        }
        else
        {
            Debug.Log("Recupera " + amount + " de vida");
            currentHealth += amount;
        }
    }

    void UpdateAnimator()
    {

    }
}