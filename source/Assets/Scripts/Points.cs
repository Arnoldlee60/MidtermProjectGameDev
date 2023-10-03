using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{
    public int pointValue = 10; // Points awarded for collecting this object
    
    // Update is called once per frame
    void Update()
    {
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            // Destroy the Points object
            Destroy(gameObject);

            // Check if the PointCounter script instance exists
            if (PointCounter.instance != null)
            {
                // Increase points using the PointCounter instance
                PointCounter.instance.IncreasePoints(pointValue);
            }

        }
    }
}
