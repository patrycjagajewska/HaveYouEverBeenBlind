using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchController : MonoBehaviour {

    private Rigidbody rigidbody;
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    void OnCollisionEnter(Collision col)
    {
        rigidbody.velocity = new Vector3(0, 0, 0);
        rigidbody.useGravity = false;
        Destroy(gameObject, 1);
    }
}
