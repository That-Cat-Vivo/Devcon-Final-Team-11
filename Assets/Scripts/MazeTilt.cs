using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeTilt : MonoBehaviour
{
    public float tiltSpeed = 5f; // Change sensitivity
    public float maxTiltAngle = 20f; // Maximum angle the platform can tilt

    void Update()
    {
        // Get input from the WASD keys
        float horizontalInput = Input.GetAxis("Horizontal"); // A/D keys
        float verticalInput = Input.GetAxis("Vertical"); // W/S keys

        // W/S tilts along the X-axis, A/D tilts along the Z-axis
        Vector3 targetRotation = new Vector3(verticalInput * maxTiltAngle, 0f, -horizontalInput * maxTiltAngle);

        // Smoothly rotate the platform towards the target rotation
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(targetRotation), tiltSpeed * Time.deltaTime);
    }
}