using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float speed;
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
        if (Input.GetKey(KeyCode.A))
        {
            inputX = -1;
        }
        else if(Input.GetKey(KeyCode.D))
        {
            inputX = 1;
        }
        else
        {
            inputX = 0;
        }

        transform.position = new Vector2(transform.position.x + inputX * speed *Time.deltaTime, transform.position.y);
    }
}
