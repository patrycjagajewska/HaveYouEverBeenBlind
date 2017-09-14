using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeScript : MonoBehaviour {

    public Vector3 rotation;
    public int countTo = 10;
    public float interval = 0.1f;

    private int counter = 0;

	// Use this for initialization
	void Start () {
        counter = countTo / 2;
        StartCoroutine(Rotate());
	}
	
	// Update is called once per frame
	IEnumerator Rotate () {
        while(true) {
            if (counter > countTo)
            {
                counter = 0;
                rotation *= -1;
            }

            transform.Rotate(rotation);
            counter++;

            yield return new WaitForSeconds(interval);
        }
    }
}
