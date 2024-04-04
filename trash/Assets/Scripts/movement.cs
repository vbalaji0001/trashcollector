using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float speed = 0f;
    private int inputX;
    public float xRange = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }

    void move()
    {
        if (Input.GetKey(KeyCode.A) && speed > -9f)
        {
            speed = speed - 1f;
        }
        else if(Input.GetKey(KeyCode.D) && speed < 9f)
        {
            speed = speed + 1f;
        }
        else{
            speed = speed / 1.1f;
        }
       
     transform.position = new Vector2(transform.position.x +  (speed *Time.deltaTime), transform.position.y);

        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
    } 
}
