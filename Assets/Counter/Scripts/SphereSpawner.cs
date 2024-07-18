using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereSpawner : MonoBehaviour
{
    [SerializeField] GameObject spherePrefab;

    public float xRange;
    public float spawnY;
    public float zRange;
    public float spawnRate;

    public float minScale;
    public float maxScale;

    [SerializeField] float waitTime;

    IEnumerator SetGravity(GameObject sphere)
    {
        yield return new WaitForSeconds(waitTime);

        Rigidbody rigidbody = sphere.GetComponent<Rigidbody>();
        rigidbody.useGravity = true;
    }

    void SpawnSphere()
    {
        float spawnX = Random.Range(-xRange, xRange);
        float spawnZ = Random.Range(-zRange, zRange);
        Vector3 spawnPosition = new Vector3(spawnX, spawnY, spawnZ);

        GameObject sphere = Instantiate(spherePrefab, spawnPosition, spherePrefab.transform.rotation);
        sphere.transform.localScale = Vector3.one * Random.Range(minScale, maxScale);
        sphere.GetComponent<MeshRenderer>().material.color = Random.ColorHSV();

        StartCoroutine(SetGravity(sphere));
    }

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnSphere", spawnRate, spawnRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
