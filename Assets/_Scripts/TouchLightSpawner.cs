using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchLightSpawner : MonoBehaviour
{

    public Transform prefab;
    public float speed = 20;
    public float fireRate = 0.2F;
    private float nextFire = 0.0F;
    public float destructionTime = 0.05f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            shoot();
        }
    }

    public void shoot()
    {
        var position = transform.position;

        Transform bullet = Instantiate(prefab, position, Random.rotation);
        Rigidbody rigidbody = bullet.GetComponent<Rigidbody>();
        rigidbody.velocity = transform.forward * speed;

        Destroy(bullet.gameObject, destructionTime);
    }
}
