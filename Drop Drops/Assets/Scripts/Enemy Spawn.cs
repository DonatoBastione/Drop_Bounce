using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject enemy;
    public float minTime;
    public float maxTime;
    private float randTime;
    public GameObject badEnemy;
    public float minTimeBad;
    public float maxTimeBad;
    private float randTimeBad;
    private float spawnAtDifferentSpeed;
    
    

    void Start() 
    {
        randTime = Random.Range(minTime, maxTime);
        randTimeBad = Random.Range(minTimeBad, maxTimeBad);
    }
    // Update is called once per frame
    void Update()
    {
        if(Time.time > randTime){
            Spawn();
        }
        if(Time.time > randTimeBad){
            SpawnBad();
        }
        spawnAtDifferentSpeed = 1-Player.velocityPercentage;
    }
    void Spawn()
    {
        randTime = Random.Range(Time.time + minTime, Time.time + maxTime)+spawnAtDifferentSpeed;
        Instantiate(enemy, transform.position + new Vector3(0, 0, 0), transform.rotation);
    }

    void SpawnBad(){
        randTimeBad = Random.Range(Time.time + minTimeBad, Time.time + maxTimeBad)+spawnAtDifferentSpeed;
        Instantiate(badEnemy, transform.position + new Vector3(0, 0, 0), transform.rotation);
    }
}
