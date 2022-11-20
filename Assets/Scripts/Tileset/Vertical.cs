using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vertical : MonoBehaviour
{
    bool tengoQueBajar = false;

    float rapidez = 2.5f;

    void Update()

    {
        if (transform.position.y >= 25)
        {
            tengoQueBajar = true;
        }

        if (transform.position.y <= 15)
        {
            tengoQueBajar = false;
        }
        if (tengoQueBajar)
        {
            Bajar();

        }
        else
        {
            Subir();
        }
    }

    void Subir()
    {
        transform.position += transform.up * rapidez * Time.deltaTime;
    }

    void Bajar()

    {
        transform.position -= transform.up * rapidez * Time.deltaTime;
    }
}
