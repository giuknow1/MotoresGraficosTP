using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlJugador : MonoBehaviour
{
    public float velocidad = 10.0f;

 

    private Rigidbody rb;
    public float saltoVelocidad;
    private bool enSuelo = true;
    public int maxnSaltos = 2;
    public int actual = 0;


    void Start()
    {
        
        Cursor.visible = false;
        GestorDeAudio.instancia.ReproducirSonido("Musica");
        GestorDeAudio.instancia.ReproducirSonido("Reset");
        rb = GetComponent<Rigidbody>();
    }


    void Update()
{
    float mov_vertical = Input.GetAxis("Vertical") * velocidad;
    float mov_horizontal = Input.GetAxis("Horizontal") * velocidad;

    mov_vertical *= Time.deltaTime;
    mov_horizontal *= Time.deltaTime;

    transform.Translate(mov_horizontal, 0, mov_vertical);

    

    //Salto

    if (Input.GetKeyDown(KeyCode.Space) && (enSuelo || maxnSaltos > actual))
    {
            GestorDeAudio.instancia.ReproducirSonido("Salto");
            rb.velocity = new Vector3(0f, saltoVelocidad, 0f * Time.deltaTime);

        enSuelo = false;
        actual++;
          
        }

}

    private void OnCollisionEnter(Collision collision)
    {
        enSuelo = true;
        actual = 0;
    }

    public void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Bateria") == true)
        {
            velocidad += 0.33f;
        }


        if (other.gameObject.CompareTag("Energia Mala") == true)
        {
            if (velocidad > 5f)
            {
                velocidad--;
            }
        }


        if (other.gameObject.CompareTag("Bateria Grande") == true)
        {
            velocidad += 2.5f;
        }

        if (other.gameObject.CompareTag("Hongo") == true)
        {
            saltoVelocidad += 2f;
        }

    }


    

    }




