using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotador : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(new Vector3(45, 0, 0) * Time.deltaTime);
    }
}

