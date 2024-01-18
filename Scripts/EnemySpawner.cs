using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public GameObject enemy;
    public float xPositionlimit;
    public float spawnRate;

    // Start is called before the first frame update
    void Start()
    {
        //SpawnSpike(); 
        StartSpawning();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnSpike()
    {
        //tyxaio shmaio to instation 
        float randomX = Random.Range(-xPositionlimit, xPositionlimit);
        Vector2 spawnPosition = new Vector2(randomX, transform.position.y);
        Instantiate(enemy, spawnPosition, Quaternion.identity);
    }

    public void StartSpawning()
    {
        InvokeRepeating("SpawnSpike", 1f, spawnRate);
    }

    public void StopSpawning()
    {
        CancelInvoke("SpawnSpike");
    }
  
}
