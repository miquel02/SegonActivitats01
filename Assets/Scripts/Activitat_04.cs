using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Activitat_04 : MonoBehaviour
{
    public GameObject sphere;

    // Change the scale according to the slider value.
    public void ChangeObjectScale(float value)
    {
        sphere.transform.localScale = new Vector3(value, value, value);
    }
}