using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activitat_06 : MonoBehaviour
{
    public GameObject cylinder;

    private Material cylinderMat;

    private void Start()
    {
        //We get acces to the material
        cylinderMat = cylinder.GetComponent<Renderer>().material;
    }

    // We assaign a an order for each of the options of the dropdown 
    public void CylinderColor(int index)
    {
        switch (index)
        {
            case 0:
                cylinderMat.color = Color.cyan;
                break;

            case 1:
                cylinderMat.color = Color.green;
                break;

            case 2:
                cylinderMat.color = Color.red;
                break;

            case 3:
                cylinderMat.color = Color.blue;
                break;

            case 4:
                cylinderMat.color = Color.yellow;
                break;

            case 5:
                cylinderMat.color = Color.black;
                break;
        }
    }
}
