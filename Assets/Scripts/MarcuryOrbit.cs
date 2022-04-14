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
        
        transform.localPosition = new Vector3(xPos, 1f, zPos);
        transform.Rotate (Vector3.up, speed*Time.deltaTime);

        angle += 10f * Time.deltaTime;
    }
}
