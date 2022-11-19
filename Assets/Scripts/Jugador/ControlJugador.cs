using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlJugador : MonoBehaviour
{
    public float velocidad = 10.0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
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
    }
}
