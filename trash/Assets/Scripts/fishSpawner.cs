using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fishSpawner : MonoBehaviour
{
    float wait = 3.5f;
    public float lowerBound = -10;
    public GameObject fallingObject;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Fall", wait, wait);
    }

    void update()
    {

    }
    // Update is called once per frame
    void Fall()
    {
        Instantiate(fallingObject, new Vector3(Random.Range(-10, 10), 10 ,0), Quaternion.identity);
    }
}

       
  