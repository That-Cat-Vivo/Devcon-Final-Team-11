using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeTilt : MonoBehaviour
{
    public float tiltSpeed = 5f; // Adjust in the Inspector to change sensitivity
    public float maxTiltAngle = 20f; // Maximum angle the platform can tilt

    void Update()
    {
        // Get input from the WASD keys (Unity's Input Manager maps Horizontal/Vertical to WASD/Arrow Keys by default)
        float horizontalInput = Input.GetAxis("Horizontal"); // A/D keys
        float verticalInput = Input.GetAxis("Vertical"); // W/S keys

        // Calculate the target rotation based on input
        // W/S tilts along the X-axis, A/D tilts along the Z-axis
        // The rotation is inverted for S and A to match the intuitive "pushing the platform" feel
        Vector3 targetRotation = new Vector3(verticalInput * maxTiltAngle, 0f, -horizontalInput * maxTiltAngle);

        // Smoothly rotate the platform towards the target rotation
        // using Quaternion.Slerp for smooth, frame-rate independent rotation
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(targetRotation), tiltSpeed * Time.deltaTime);
    }
}