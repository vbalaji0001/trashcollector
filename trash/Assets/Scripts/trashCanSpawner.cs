using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trashCanSpawner : MonoBehaviour
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
        if (transform.position.y < lowerBound)
        {
            Destroy(fallingObject);
        }
    }
    // Update is called once per frame
    void Fall()
    {
        Instantiate(fallingObject, new Vector3(Random.Range(-10, 10), 18 ,0), Quaternion.identity);
    }
}

       
  