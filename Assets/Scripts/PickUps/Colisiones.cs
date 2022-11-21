using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Colisiones : MonoBehaviour

{
    public int key = 0;

    public GameObject llave;
    public GameObject llave1;
    public GameObject llave2;

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

            key++;

            if (key == 1)
            {
                llave2.SetActive(false);
            }
            if (key == 4)
            {
                llave1.SetActive(false);
            }

            if (key == 7)
            {
                llave.SetActive(false);
            }

        }



    }

   
        
    
}
