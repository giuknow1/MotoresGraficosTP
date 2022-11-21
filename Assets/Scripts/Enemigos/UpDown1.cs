using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpDown1 : MonoBehaviour
{
    bool tengoQueBajar = false;


    public float min = 5f;
    public float max = 10f;
    public float rapidez = 2.5f;

    void Update()

    {
        if (transform.position.y >= max)
        {
            tengoQueBajar = true;
        }

        if (transform.position.y <= min)
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
