using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelRotation : MonoBehaviour
{
    public Transform wheel;
    public float rotationSpeed = 500f;

    private StarterAssets.StarterAssetsInputs playerInput;

    void Start()
    {
        playerInput = FindObjectOfType<StarterAssets.StarterAssetsInputs>();
    }

    void Update()
    {

        if (playerInput == null || wheel == null) return;

        // 🔄 Rotación hacia adelante en el eje Z
        float forwardRotation = playerInput.move.y * rotationSpeed * Time.deltaTime;
        wheel.Rotate(Vector3.forward * forwardRotation, Space.Self);

    }
}
