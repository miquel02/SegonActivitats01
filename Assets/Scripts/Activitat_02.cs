using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Activitat_02 : MonoBehaviour
{

    public TextMeshProUGUI textTMP;
    public int number;

    void Update()
    {
        //Function to determie if a number is even or odd
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //If the remainder , when diveded 2, is 0 the number is even, if not its odd  
            if (number % 2 == 0)
            {
                textTMP.text = number + " is even";
            }
            else
            {
                textTMP.text = "The number " + number + " is odd";
            }
        }
    }
}