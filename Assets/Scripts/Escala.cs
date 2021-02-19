using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escala : MonoBehaviour
{   
    float escala = 2.0f;
    public AudioSource scale;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {   
            scale.Play();
            transform.localScale += new Vector3(escala * Time.deltaTime,
                                                escala * Time.deltaTime,
                                                escala * Time.deltaTime);
        } else if (Input.GetKey(KeyCode.E))
        {   
            scale.Play();
            transform.localScale += new Vector3(-escala * Time.deltaTime,
                                                -escala * Time.deltaTime,
                                                -escala * Time.deltaTime);
        }

    }
    
}
