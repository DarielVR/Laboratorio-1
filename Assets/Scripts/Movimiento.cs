using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{   
    Rigidbody rb;
    public float force = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        rb.AddForce(Input.GetAxis("Horizontal")*force,
                            0,
                            Input.GetAxis("Vertical")*force);
    }

}
