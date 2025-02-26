using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoWheel : MonoBehaviour
{
    public Transform wheel;

    void Start()
    {
        EnemiesContainer.instance.AddEnemie();

    }

    // Update is called once per frame
    void Update()
    {
        wheel.Rotate(0, 1, 0);

    }
}
