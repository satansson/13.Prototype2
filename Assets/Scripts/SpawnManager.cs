using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] humanPrefabs;
    public float xRange = 5;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomHuman", 2, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomHuman()
    {
        int humanIndex = Random.Range(0, humanPrefabs.Length);
        float spawnPosX = Random.Range(-xRange, xRange);
        float spawnPosZ = -3;

        Instantiate(humanPrefabs[humanIndex], new Vector3(spawnPosX, 0, spawnPosZ), humanPrefabs[humanIndex].transform.rotation);
    }
}
