using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] enemyPrefabs;
    public float spawnRate = 3f;
    public float nextSpawn = 0.0f;
    public int limit;
    public static RandomSpawner randomSpawner;
    public int bosasMires = 0;

    void Awake()
    {
        limit = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (bosasMires > 0)
        {

        QuestManager.questManager.AddQuestItem("Nuþudytas bosas", 1);
        }

        if (Time.time > nextSpawn && limit < 2)
        {
            nextSpawn = Time.time + spawnRate;
            int randEnemy = Random.Range(0, enemyPrefabs.Length);
            int randSpawnPoint = Random.Range(0, spawnPoints.Length);

            Instantiate(enemyPrefabs[randEnemy], spawnPoints[randSpawnPoint].position, transform.rotation);
            OnSpawn();

            if (limit > 3)
            {
                DestroyWithTag("Goblin");
                DestroyWithTag("Wizard");
            }
           
            
        }
    }
    public void SpawnRate(int Rate)
    {
        spawnRate = spawnRate + Rate;
        nextSpawn = 5f;
    }
    public void OnKill()
    {
        limit--;
        
        
    }
    public void OnSpawn()
    {
        limit++;
        
        
    }
    public void DestroyWithTag(string destroyTag)
    {
        GameObject[] destroyObject;
        destroyObject = GameObject.FindGameObjectsWithTag(destroyTag);
        foreach (GameObject oneObject in destroyObject)
            Destroy(oneObject);
    }


}
