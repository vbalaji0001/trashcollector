using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollisionController : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] public static int scoreValue = 0;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("obstacle"))
        {
            scoreValue = scoreValue - 1;
            Destroy(other.gameObject);
        }
        if (other.gameObject.CompareTag("fish"))
        {
            scoreValue = scoreValue + 1;
            Destroy(other.gameObject);
        }
    }

    void Update()
    {
        scoreText.text = "Score: " + scoreValue;
    }
}