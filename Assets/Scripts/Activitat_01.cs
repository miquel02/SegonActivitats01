using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Activitat_01 : MonoBehaviour
{
    //We get acces to the text and declare min and max
    public TextMeshProUGUI numText;
    private int min = 0;
    private int max = 9;

    //function to generate a random number
    public void RandomNun()
    {
        
        numText.text = Random.Range(min, max).ToString();
    }
}
