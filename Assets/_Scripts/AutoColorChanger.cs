using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoColorChanger : MonoBehaviour {

    private Material material;

    private float duration = 3.0f;

	// Use this for initialization
	void Start () {
        material = gameObject.GetComponent<Renderer>().material;
        StartCoroutine(ChangeColor());
    }
	
	// Update is called once per frame
	IEnumerator ChangeColor() {
        while (true) {
            material.SetColor("_EmissionColor", Random.ColorHSV());
            yield return new WaitForSeconds(Random.Range(0.001F, 0.8F));
        }
    }
}
