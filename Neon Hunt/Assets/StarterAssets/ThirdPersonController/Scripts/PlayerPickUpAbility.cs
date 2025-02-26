using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPickUpAbility : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<IPowerUp>(out IPowerUp pickUpPowerUp))
        {
            pickUpPowerUp.PickUpPowerUp(this.gameObject);
            Destroy(other.gameObject);
        }
    }
}
