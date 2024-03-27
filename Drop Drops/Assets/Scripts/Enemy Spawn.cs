using System.Collections;
using System.Collections.Generic;
using System.Transactions;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject enemy;
    public float minTime; 
    public float maxTime;
    private float randTime; //tempo finale di respawn (compreso tra min e max)
    public GameObject badEnemy;
    public float minTimeBad;
    public float maxTimeBad;
    private float randTimeBad;
     public GameObject goodEnemy;
    public float minTimeGood;
    public float maxTimeGood;
    private float randTimeGood;
    private float spawnAtDifferentDensity; //coefficiente per la densità dello spawn dei nemici, così da diminuire la densità se il player rallenta
    
    

    void Start() 
    {
        randTime = Random.Range(minTime, maxTime);
        randTimeBad = Random.Range(minTimeBad, maxTimeBad);
        randTimeGood = Random.Range(minTimeGood, maxTimeGood);
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
        if(Time.time > randTimeGood){
            SpawnGood();
        }
        spawnAtDifferentDensity = 1-Player.velocityPercentage;
    }
    void Spawn()
    {
        randTime = Random.Range(Time.time + minTime, Time.time + maxTime)+spawnAtDifferentDensity;
        Instantiate(enemy, transform.position + new Vector3(0, 0, 0), transform.rotation);
    }

    void SpawnBad(){
        randTimeBad = Random.Range(Time.time + minTimeBad, Time.time + maxTimeBad)+spawnAtDifferentDensity;
        Instantiate(badEnemy, transform.position + new Vector3(0, 0, 0), transform.rotation);
    }
    void SpawnGood(){
        randTimeGood = Random.Range(Time.time + minTimeGood, Time.time + maxTimeGood)+spawnAtDifferentDensity;
        Instantiate(goodEnemy,transform.position + new Vector3(0, 0, 0), transform.rotation);
    }
}
