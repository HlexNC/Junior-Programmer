using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;


public class ObjectGenerator : MonoBehaviour
{
    public GameObject[] animalPrefabs;

    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("RandSpawnAnimals", 1, 0.25f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void RandSpawnAnimals()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        int randLocation = Random.Range(-10, 11);

        Instantiate(animalPrefabs[animalIndex], new Vector3(randLocation, 0, 30), animalPrefabs[animalIndex].transform.rotation);
    }
    
}
