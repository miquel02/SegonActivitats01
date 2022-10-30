using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activitat_10_1 : MonoBehaviour
{
    private Activitat_10 manager;

    private void Start()
    {
        // We acces the main script
        manager = FindObjectOfType<Activitat_10>();
    }

    // If the mouse is over the GameObject 
    private void OnMouseDown()
    { 
        //We add point to score
        manager.AddPoint();

        //Destroy the sphere
        Destroy(gameObject);
    }
}