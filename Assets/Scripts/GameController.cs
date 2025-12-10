using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scr : MonoBehaviour
{
    public GameObject gravCentre;
    int hold = 0;
    float gravX = 0;
    float gravZ = 0;
    float timer = 0;
    private Quaternion baseRotation;
    private Quaternion currentRotation;
    private Quaternion rotL;
    private Quaternion rotR;
    private Quaternion rotU;
    private Quaternion rotD;
    // Start is called before the first frame update
    void Start()
    {
        //rotation destinations.
        baseRotation = gravCentre.transform.rotation;
        rotL = new Quaternion(0, 0, -0.2f, baseRotation.w);
        rotR = new Quaternion(0, 0, 0.2f, baseRotation.w);
        rotU = new Quaternion(-0.2f, 0, 0, baseRotation.w);
        rotD = new Quaternion(0.2f, 0, 0, baseRotation.w);
    }

    // Update is called once per frame
    void Update()
    {
        currentRotation = gravCentre.transform.rotation;

        //Player 1 Controls
        if (Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene("SampleScene");
        }

        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }


        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.A))
        {
            timer = Time.deltaTime * 2000;
            hold = (int)timer;
        }
        else if (hold >= 0)
        {
            hold--;
            timer = 0;
            gravX = 0;
            gravZ = 0;
        }
        

        if (Input.GetKey(KeyCode.W))
        {
            gravZ = hold;
            gravCentre.transform.rotation = Quaternion.Lerp(rotU, currentRotation, 0.9f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            gravZ = -hold;
            gravCentre.transform.rotation = Quaternion.Lerp(rotD, currentRotation, 0.9f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            gravX = -hold;
            gravCentre.transform.rotation = Quaternion.Lerp(rotL, currentRotation, 0.9f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            gravX = hold;
            gravCentre.transform.rotation = Quaternion.Lerp(rotR, currentRotation, 0.9f);
        }
        
        
    }

    private void FixedUpdate()
    {
        Physics.gravity = new Vector3(gravX, -9.0f, gravZ);
        if (currentRotation != baseRotation && !Input.anyKey)
        {
            gravCentre.transform.rotation = Quaternion.Lerp(baseRotation, currentRotation, 0.9f);
        }
    }
}

