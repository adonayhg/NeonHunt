using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp30s : MonoBehaviour, IPowerUp
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PickUpPowerUp(GameObject other)
    {
        EnergySystem.instance.Energia30s();
    }
}
