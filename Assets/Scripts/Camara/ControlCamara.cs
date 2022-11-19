using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCamara : MonoBehaviour
{
    Vector2 VisionMouse; 
    Vector2 Suav_V;
    
    public float sensibilidad = 5.0f;
    public float suav = 2.0f;
    
    GameObject jugador; 
    
    void Start()
    { 
        jugador = this.transform.parent.gameObject;
    }

    void Update() 
    { 
        var md = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));

        md = Vector2.Scale(md, new Vector2(sensibilidad * suav, sensibilidad * suav));

        Suav_V.x = Mathf.Lerp(Suav_V.x, md.x, 1f / suav); 
        Suav_V.y = Mathf.Lerp(Suav_V.y, md.y, 1f / suav); 
        
        VisionMouse += Suav_V; VisionMouse.y = Mathf.Clamp(VisionMouse.y, -90f, 90f); 
        transform.localRotation = Quaternion.AngleAxis(-VisionMouse.y, Vector3.right); 
        jugador.transform.localRotation = Quaternion.AngleAxis(VisionMouse.x, jugador.transform.up);
    }
}