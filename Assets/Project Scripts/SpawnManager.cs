using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] gemPrefabs;
    private float spawnRangeX = 30;
    private float spawnRangeZ = 30;
    private float startDelay = 1;
    private float spawnInterval = 0.25f;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomGem", startDelay, spawnInterval);

    }

    // Update is called once per frame
    void Update()
    {



    }
    void SpawnRandomGem()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, Random.Range(-spawnRangeZ, spawnRangeZ));

        int gemIndex = Random.Range(0, gemPrefabs.Length);
        Instantiate(gemPrefabs[gemIndex], spawnPos, gemPrefabs[gemIndex].transform.rotation);
    }
}



