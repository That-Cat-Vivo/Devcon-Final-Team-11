using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr : MonoBehaviour
{
    public GameObject gravCentre;
    int hold = 0;
    float gravX = 0;
    float gravZ = 0;
    float timer = 0;
    private Quaternion baseRotation;
    private Quaternion currentRotation;
    // Start is called before the first frame update
    void Start()
    {
        baseRotation = gravCentre.transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        currentRotation = gravCentre.transform.rotation;

        //Player 1 Controls
        gravCentre.transform.Rotate(gravZ, 0, gravX, Space.World);

        if (Input.GetKey(KeyCode.I) || Input.GetKey(KeyCode.K) || Input.GetKey(KeyCode.L) || Input.GetKey(KeyCode.J))
        {
            timer = Time.deltaTime * 500;
            hold = (int)timer;
        }
        else if (hold >= 0)
        {
            hold--;
            timer = 0;
            gravX = 0;
            gravZ = 0;
        }
        

        if (Input.GetKey(KeyCode.I))
        {
            gravZ = hold;

        }
        if (Input.GetKey(KeyCode.K))
        {
            gravZ = -hold;

        }
        if (Input.GetKey(KeyCode.J))
        {
            gravX = -hold;
        }
        if (Input.GetKey(KeyCode.L))
        {
            gravX = hold;
        }

        
    }

    private void FixedUpdate()
    {
        Physics.gravity = new Vector3(gravX, -1.0f, gravZ);
        if (currentRotation != baseRotation && !Input.anyKey)
        {
            gravCentre.transform.rotation = Quaternion.Lerp(baseRotation, currentRotation, 0.9f);
        }
    }
}
