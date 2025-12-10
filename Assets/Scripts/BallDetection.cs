using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallDetection : MonoBehaviour
{
    public GameObject Won;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 6)
        {
            SceneManager.LoadScene("SampleScene");
        }
        if (other.gameObject.layer == 7)
        {
            Won.transform.position = new Vector3(0, 11, 0);
        }
    }
}
