using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public float spawnRangeX = 13;
    public float spawnPositionZ = 20;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", 2, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomAnimal()
    {
        //Debug.Log("�X�|�[��������");
        int animalIndex = Random.Range(0, animalPrefabs.Length);

        Vector3 spawnPosition = new Vector3(Random.Range(spawnRangeX, -spawnRangeX),
                                            0,
                                            spawnPositionZ);

        Instantiate(animalPrefabs[animalIndex],
                    spawnPosition,
                    animalPrefabs[animalIndex].transform.rotation);
    }
}
