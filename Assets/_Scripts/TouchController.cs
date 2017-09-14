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
        /*
        GameObject lightGameObject = new GameObject("touch-light");
        Light lightComp = lightGameObject.AddComponent<Light>();
        lightComp.color = Color.blue;
        lightComp.areaSize = new Vector2(1f, 1f);
        var x = col.gameObject.transform.position.x;
        var y = col.gameObject.transform.position.y;
        var z = col.gameObject.transform.position.z;
        lightGameObject.transform.position = new Vector3(x, y, z);
        Destroy(col.gameObject);*/
        
    }
}
