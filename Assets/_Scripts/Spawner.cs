using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public Transform prefab;
    public float spawnInterval;

    [Range(0.01f, 1)]
    public float scale = 0.1f;

    public float minAngle;
    public float maxAngle;

	// Use this for initialization
	void Start () {
        if (minAngle < maxAngle) {
            StartCoroutine(SpawnCor());
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public IEnumerator SpawnCor()
    {
        while (true)
        {
            float waitTime = Random.Range(0, 2) * spawnInterval;
            yield return new WaitForSeconds(waitTime);

            float yRotation = transform.rotation.y + Random.Range(minAngle, maxAngle);
            Quaternion rotation = Quaternion.Euler(transform.rotation.x, yRotation, transform.rotation.z);

            float randomScale = Random.Range(0.01f, scale);

            Transform newObject = Instantiate(prefab, transform.position, rotation);
           
            newObject.gameObject.transform.localScale = new Vector3(randomScale, randomScale, randomScale);

            Destroy(newObject.gameObject, 13);
        }
    }
}
