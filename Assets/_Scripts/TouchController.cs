using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision col)
    {
        GameObject lightGameObject = new GameObject("touch-light");
        Light lightComp = lightGameObject.AddComponent<Light>();
        lightComp.color = Color.blue;
        var x = col.gameObject.transform.position.x;
        var y = col.gameObject.transform.position.y;
        var z = col.gameObject.transform.position.z;
        lightGameObject.transform.position = new Vector3(x, y, z);
        Destroy(col.gameObject);
    }
}
