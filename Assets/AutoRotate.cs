using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoRotate : MonoBehaviour {

    public float interval = 1f;

    public Vector3 angle;

    // Use this for initialization
    void Start () {
        StartCoroutine(Rotate());
	}
	
	IEnumerator Rotate () {
		while (true) {

            yield return new WaitForSeconds(interval);
            transform.Rotate(angle);
        }
	}
}
