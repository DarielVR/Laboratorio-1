using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escala : MonoBehaviour
{   
    float escala = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.J))
        {
            transform.localScale += new Vector3(escala * Time.deltaTime,
                                                escala * Time.deltaTime,
                                                escala * Time.deltaTime);
        } else if (Input.GetKey(KeyCode.L))
        {
            transform.localScale += new Vector3(-escala * Time.deltaTime,
                                                -escala * Time.deltaTime,
                                                -escala * Time.deltaTime);
        }
    }
}
