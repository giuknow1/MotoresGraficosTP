using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotador : MonoBehaviour
{
   void Start()
    {
        transform.Rotate(new Vector3(20, 20, 20) * Time.deltaTime);
   
    }
  
    void Update()
    {
        
    }
}
