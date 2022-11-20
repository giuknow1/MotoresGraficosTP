using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vertical1 : MonoBehaviour
{
    bool tengoQueBajar = false;

    float rapidez = 4f;

    void Update()

    {
        if (transform.position.y >= 25)
        {
            tengoQueBajar = true;
        }

        if (transform.position.y <= 20)
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
