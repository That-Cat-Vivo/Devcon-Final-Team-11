using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr : MonoBehaviour
{
    public Collider platform;
    float pRotationX;
    float pRotationZ;
    float hold = 0;
    // Start is called before the first frame update
    void Start()
    {
        pRotationX = platform.transform.rotation.x;
        pRotationZ = platform.transform.rotation.z;
    }

    // Update is called once per frame
    void Update()
    {
        pRotationX = platform.transform.rotation.x;
        pRotationZ = platform.transform.rotation.z;

        //Player 1 Controls
        if (Input.GetKey(KeyCode.A) && pRotationZ <= 20)
        {
            hold += Time.deltaTime * 20;
            Debug.Log("Left");

            platform.transform.rotation = Quaternion.Euler(pRotationX, 0, pRotationZ + hold);
        }
        else if (Input.GetKey(KeyCode.D) && pRotationZ >= -20)
        {
            hold += Time.deltaTime * 20;
            Debug.Log("Right");

            platform.transform.rotation = Quaternion.Euler(pRotationX + hold, 0, pRotationZ);
        }
        else
        {
            hold = 0;
        }
    }
}
