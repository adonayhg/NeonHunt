using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpAmmo : MonoBehaviour, IPowerUp
{
    public void PickUpPowerUp(GameObject other)
    {
        Debug.Log("Recoger municion");
    }

}
