using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlJugador : MonoBehaviour
{
    public float velocidad = 10.0f;

    public int vida = 3;

    private Rigidbody rb;
    public float saltoVelocidad;
    private bool enSuelo = true;
    public int maxnSaltos = 4;
    public int actual = 0;


    void Start()
    {
        GestorDeAudio.instancia.ReproducirSonido("Musica");
        rb = GetComponent<Rigidbody>();
    }


    void Update()
{
    float mov_vertical = Input.GetAxis("Vertical") * velocidad;
    float mov_horizontal = Input.GetAxis("Horizontal") * velocidad;

    mov_vertical *= Time.deltaTime;
    mov_horizontal *= Time.deltaTime;

    transform.Translate(mov_horizontal, 0, mov_vertical);

    if (Input.GetKeyDown("escape"))
    {
        Cursor.lockState = CursorLockMode.None;
    }

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


    }

    

