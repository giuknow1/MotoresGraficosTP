using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JetPack : MonoBehaviour
{

    public float combustible = 4f;
    public float empuje = 0.5f;
    public Rigidbody rb;
    public Transform groundedTransform;
    public ParticleSystem effect;
    public ParticleSystem effect2;
    private float c_combust;

    void Start()
    {
        c_combust = combustible;
    }

 
    void Update()
    {
       

            if (Input.GetAxis("Jump") > 0f && c_combust > 0f)
            {
                c_combust -= Time.deltaTime;
                rb.AddForce(rb.transform.up * empuje, ForceMode.Impulse);
                effect.Play();
                effect2.Play();
            }
            else if (Physics.Raycast(groundedTransform.position, Vector3.down, 0.05f, LayerMask.GetMask("Grounded")) && c_combust < combustible)
            {
                c_combust += Time.deltaTime;
                effect.Stop();
                effect2.Stop();
            }
            else
            {
                effect.Stop();
                effect2.Stop();
            }

        }
    

  
}
