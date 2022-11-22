using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPad : MonoBehaviour
{

    [Range(100, 1000)]
    public float altura;

    private void OnCollisionEnter (Collision collision)
    {
        GameObject jumpPad = collision.gameObject;
        Rigidbody rb = jumpPad.GetComponent<Rigidbody>();
        rb.AddForce(Vector3.up * altura);
        GestorDeAudio.instancia.ReproducirSonido("Boing");
    }
}
