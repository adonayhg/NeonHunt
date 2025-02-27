using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp100 : MonoBehaviour, IPowerUp
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
            EnergySystem.instance.Energia100();
    }
}
