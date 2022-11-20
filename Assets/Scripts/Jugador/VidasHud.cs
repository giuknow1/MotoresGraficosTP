using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidasHud : MonoBehaviour
{
    public int vidas = 2;

    public GameObject Luz1;
    public GameObject Luz2;
    public GameObject Luz3;

    public void Start()
    {
        Luz1.SetActive(true);
        Luz2.SetActive(true);
        Luz3.SetActive(false);
    }

    public void OnTriggerEnter(Collider other)
    {

        

        if (other.gameObject.CompareTag("Corazon") == true)
            {

            if (vidas == 2)
            {
                Luz3.SetActive(true);
                vidas++;
            }

            if (vidas == 1)
            {
                Luz2.SetActive(true);
                vidas++;
            }
            
          

            }
        

       
        if (other.gameObject.CompareTag("Escudo") == true)
        {
           
           
            
            if (vidas == 1)
            {
                Luz1.SetActive(false);
                vidas--;
            }

            if (vidas == 2)
            {
                Luz2.SetActive(false);
                vidas--;
            }

            if (vidas == 3)
            {
                Luz3.SetActive(false);
                vidas--;
            }

        }

    }


}
