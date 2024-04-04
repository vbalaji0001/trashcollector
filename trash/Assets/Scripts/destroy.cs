using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{

    // Update is called once per frame
     private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("obstacle") || other.gameObject.CompareTag("fish")){
            Destroy(other.gameObject);
        }
    }

}
