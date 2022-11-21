using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using UnityEngine.SceneManagement;

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
                GestorDeAudio.instancia.ReproducirSonido("Repos");
                GestorDeAudio.instancia.PausarSonido("Alarma");
            }
            
          

            }
        

       
        if (other.gameObject.CompareTag("Energia Mala") == true || other.gameObject.CompareTag("Enemigo") == true)
        {
           
           if (escudo == true)
            {

                EscudoVida.SetActive(false);
                escudo = false;
            } else if (vidas == 1)
            {
                Luz1.SetActive(false);
                vidas--;

                GestorDeAudio.instancia.PausarSonido("Alarma");

                humo.Stop();
                SceneManager.LoadScene(0);
                GestorDeAudio.instancia.ReproducirSonido("Reset");
            }

            else if (vidas == 2)
            {
                GestorDeAudio.instancia.ReproducirSonido("Backup");
                Luz2.SetActive(false);
                vidas--;
                GestorDeAudio.instancia.ReproducirSonido("Alarma");
                humo.Play();

                
            }

          else  if (vidas == 3)
            {
                Luz3.SetActive(false);
                vidas--;
                GestorDeAudio.instancia.ReproducirSonido("Ouch");
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

            GestorDeAudio.instancia.PausarSonido("Alarma");
            GestorDeAudio.instancia.ReproducirSonido("Repos");
            humo.Stop();

            

        }

        if (other.gameObject.CompareTag("Enemigo") == true)
        {

            GestorDeAudio.instancia.ReproducirSonido("Bateria Mala");


        }
    }

    
   
    }


