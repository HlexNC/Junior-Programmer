using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject enemy;
    public GameObject pickUp;
    public int randSpawnRange = 9;
    public int waveNumber = 1;
    void Start()
    {
        SpawnEnemyWave(waveNumber);
    }

    void SpawnEnemyWave(int enemiesToSpawn)
    {
        for (int i = 0; i < enemiesToSpawn; i++)
        {
            Instantiate(enemy, RandSpawnGenerator(), enemy.transform.rotation);
        }
    }
    // Update is called once per frame
    void Update()
    {
        int enemyCount = FindObjectsOfType<Enemy>().Length;
        if (enemyCount == 0)
        {
            SpawnEnemyWave(waveNumber++);
            Instantiate(pickUp, RandSpawnGenerator(), pickUp.transform.rotation);
        }
            

    }

    private Vector3 RandSpawnGenerator()
    {
        int randSpawnX = Random.Range(-randSpawnRange, randSpawnRange);
        int randSpawnZ = Random.Range(-randSpawnRange, randSpawnRange);
        Vector3 randSpawn = new Vector3(randSpawnX, 0, randSpawnZ);
        return randSpawn;

    }
}
