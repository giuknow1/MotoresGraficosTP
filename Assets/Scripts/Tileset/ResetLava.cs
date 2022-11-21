using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetLava : MonoBehaviour
{
    public ParticleSystem humo;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Lava") == true)
        {

            GestorDeAudio.instancia.PausarSonido("Alarma");
            humo.Stop();
            SceneManager.LoadScene(0);
            GestorDeAudio.instancia.ReproducirSonido("Reset");
        }
    }
}