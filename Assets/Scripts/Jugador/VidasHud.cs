using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidasHud : MonoBehaviour
{
    public int vidas = 2;
    public bool escudo = false;

    public ParticleSystem humo;

    public GameObject Luz1;
    public GameObject Luz2;
    public GameObject Luz3;
    public GameObject EscudoVida;

    public void Start()
    {
        Luz1.SetActive(true);
        Luz2.SetActive(true);
        Luz3.SetActive(false);

        EscudoVida.SetActive(false);

        humo.Stop();
    }

    public void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Escudo") == true)
        {
            escudo = true;
            EscudoVida.SetActive(true);
        }

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
                humo.Stop();
            }
            
          

            }
        

       
        if (other.gameObject.CompareTag("Moneda") == true)
        {
           
           if (escudo == true)
            {

                EscudoVida.SetActive(false);
                escudo = false;
            } else if (vidas == 1)
            {
                Luz1.SetActive(false);
                vidas--;
            }

            else if (vidas == 2)
            {
                Luz2.SetActive(false);
                vidas--;
                humo.Play();
            }

          else  if (vidas == 3)
            {
                Luz3.SetActive(false);
                vidas--;
            }

        }


        if (other.gameObject.CompareTag("Bateria Grande") == true)
        {
            vidas = 3;
            Luz1.SetActive(true);
            Luz2.SetActive(true);
            Luz3.SetActive(true);

            escudo = true;
            EscudoVida.SetActive(true);
        }

    }

   
    }


