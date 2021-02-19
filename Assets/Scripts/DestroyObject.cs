using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    public AudioSource dead;
    void OnTriggerEnter (Collider collider) {
        Destroy(collider.gameObject);
        dead.Play();
    }
}
