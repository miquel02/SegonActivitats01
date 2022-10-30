using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activitat_03 : MonoBehaviour
{
    // Variables to store the cube's positions
    private float xPosition;
    private float yPosition;
    private float zPosition;

    // Screen limits
    private float xRange = 5f;
    private float yRange = 4f;
    private float zRange = 5f;

    void Update()
    {
        // If enter is pressed generate a random position amd move the cube to it
        if (Input.GetKeyDown(KeyCode.Return))
        {
            // Generates random values.
            xPosition = Random.Range(-xRange, xRange);
            yPosition = Random.Range(-yRange, yRange);
            zPosition = Random.Range(-zRange, zRange);

            
            transform.position = new Vector3(xPosition, yPosition, zPosition);
        }
    }
}
