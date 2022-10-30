using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Activitat_09 : MonoBehaviour
{

    public GameObject light;

    //Function to cahnge de state of the point light 
    public void SwitchLight(bool isOn)
    {
        // If the toggle is on the light is on if it is off the light is off
        if (isOn)
        {        
            light.GetComponent<Light>().enabled = true;
        }
        else
        {
            light.GetComponent<Light>().enabled = false;
        }
    }
}