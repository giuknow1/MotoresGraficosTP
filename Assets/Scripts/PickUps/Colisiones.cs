using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Colisiones : MonoBehaviour

{
    public GameObject llave;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Corazon") == true)
        {
            other.gameObject.SetActive(false);
            GestorDeAudio.instancia.ReproducirSonido("Vida");
        }

        if (other.gameObject.CompareTag("Escudo") == true)
        {
            other.gameObject.SetActive(false);
            GestorDeAudio.instancia.ReproducirSonido("Escudo");
        }

        if (other.gameObject.CompareTag("Bateria") == true)
        {
            other.gameObject.SetActive(false);
            GestorDeAudio.instancia.ReproducirSonido("Bateria");
        }

        if (other.gameObject.CompareTag("Bateria Grande") == true)
        {
            other.gameObject.SetActive(false);
            GestorDeAudio.instancia.ReproducirSonido("Gran Bateria");
        }

        if (other.gameObject.CompareTag("Energia Mala") == true)
        {
            other.gameObject.SetActive(false);
            GestorDeAudio.instancia.ReproducirSonido("Bateria Mala");
        }

        if (other.gameObject.CompareTag("Moneda") == true)
        {
            other.gameObject.SetActive(false);
            GestorDeAudio.instancia.ReproducirSonido("Moneda");
        }

        if (other.gameObject.CompareTag("Llave") == true)
        {
            other.gameObject.SetActive(false);
            GestorDeAudio.instancia.ReproducirSonido("Moneda");
            llave.SetActive(false);
        }


    }
}
