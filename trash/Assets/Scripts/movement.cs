using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float speed = 0f;
    private int inputX;

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
        if (Input.GetKey(KeyCode.A) && speed > -7f)
        {
            speed = speed - 1f;
        }
        else if(Input.GetKey(KeyCode.D) && speed < 7f)
        {
            speed = speed + 1f;
        }
        else{
            speed = speed / 1.5f;
        }
       
     transform.position = new Vector2(transform.position.x +  (speed *Time.deltaTime), transform.position.y);
    }
}
