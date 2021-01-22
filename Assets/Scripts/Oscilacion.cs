using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscilacion : MonoBehaviour
{
    Vector3 OriPos;
    float amplitude = 0.5f;
    float speed = 4.0f;

    // Start is called before the first frame update
    void Start()
    {
        OriPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = OriPos + new Vector3 (0,
                                                amplitude * Mathf.Sin(Time.time * speed) 
                                                ,0);
    }
}
