using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossSpawner : MonoBehaviour
{
    public GameObject boss;
    public Transform bossSpawnerPoint;
    public Transform spawner;
    public Transform BossSpawneris;
    public float spawnRate = 3f;
    float nextSpawn = 0.0f;
    public GameObject BossHealth;
    public GameObject BosoLaikiklis;

    public void Start()
    {
       
        bossSpawnerPoint = GameObject.FindGameObjectWithTag("BossSpawner").transform;
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Zaidejas"))    
        {
            if (Time.time > nextSpawn)
            {
                nextSpawn = Time.time + spawnRate;
                //Instantiate(boss, bossSpawnerPoint.position, Quaternion.identity);
                
                BossSpawnRate(999999);
                BossHealth.SetActive(true);
                BosoLaikiklis.SetActive(false);

               // if (collision.gameObject.CompareTag("Zaidejas"))
               // {
                //     DestroyWithTag("priesas");
               // }


            }
            

            
        }
        
        
    }
    public void DestroyWithTag(string destroyTag)
    {
        GameObject[] destroyObject;
        destroyObject = GameObject.FindGameObjectsWithTag(destroyTag);
        foreach (GameObject oneObject in destroyObject)
            Destroy(oneObject);
    }
    public void BossSpawnRate(int Rate)
    {
        nextSpawn += Rate;
    }

}
