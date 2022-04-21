using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarcuryOrbit : MonoBehaviour
{
    private float angle = 0f;
    public float speed = 10.0f;


    // Update is called once per frame
    void Update()
    {
        var xPos = Mathf.Sin(angle);
        var zPos = Mathf.Cos(angle);
        
       
        transform.Rotate (Vector3.up, speed*Time.deltaTime);

        angle += 10f * Time.deltaTime;
    }
}
