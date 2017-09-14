using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderScript : MonoBehaviour {
    
    public float minSpeed = 0.8f;
    public float maxSpeed = 1.2f;

    void Update () {
        transform.Translate(Vector3.forward * Time.deltaTime * Random.Range(minSpeed, maxSpeed));
    }
}
