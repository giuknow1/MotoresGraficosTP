using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovCamara : MonoBehaviour
{
    public Transform posCamara;

    void Update()
    {
        transform.position = posCamara.position; 
    }
}
