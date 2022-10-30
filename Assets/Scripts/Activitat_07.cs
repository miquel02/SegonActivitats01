using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activitat_07 : MonoBehaviour
{
    public GameObject sphere;

    private Material sphereMat;

    private void Start()
    {
        //We get acces to the material
        sphereMat = sphere.GetComponent<Renderer>().material;
    }

    //Function to acces the tranparency
    public void ChangeSphereAlpha(float value)
    {
        sphereMat.color = new Vector4(sphereMat.color.r, sphereMat.color.g, sphereMat.color.b, value);
    }
}