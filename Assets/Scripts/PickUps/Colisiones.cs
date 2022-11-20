using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colisiones : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Corazon") == true)
        {
            other.gameObject.SetActive(false);
        }

        if (other.gameObject.CompareTag("Escudo") == true)
        {
            other.gameObject.SetActive(false);
        }

        if (other.gameObject.CompareTag("Bateria") == true)
        {
            other.gameObject.SetActive(false);
        }

        if (other.gameObject.CompareTag("Bateria Grande") == true)
        {
            other.gameObject.SetActive(false);
        }

        if (other.gameObject.CompareTag("Energia Mala") == true)
        {
            other.gameObject.SetActive(false);
        }

        if (other.gameObject.CompareTag("Moneda") == true)
        {
            other.gameObject.SetActive(false);
        }



    }
}
