using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoBlinker : MonoBehaviour {

    public float duration = 2.0f;
    
    public float intensity = 1f;

    private Light lt;

    void Start()
    {
        lt = GetComponent<Light>();
    }
    void Update()
    {
        float phi = Time.time / duration * 2 * Mathf.PI;
        float amplitude = Mathf.Cos(phi) * intensity + 2 * intensity;
        lt.intensity = amplitude;
    }
}
