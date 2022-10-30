using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activitat_05 : MonoBehaviour
{
    public GameObject capsulePrefab;
    public Vector3[] positions;

    void Update()
    {
        // When the S key is pressed the capsules apear in each of the positions
        if (Input.GetKeyDown(KeyCode.S))
        {
            foreach (Vector3 pos in positions)
            {
                Instantiate(capsulePrefab, pos, capsulePrefab.transform.rotation);
            }
        }
    }
}
