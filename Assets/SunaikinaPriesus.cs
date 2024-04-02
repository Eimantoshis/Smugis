using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunaikinaPriesus : MonoBehaviour
{
    public RandomSpawner spawner;

    private void Start()
    {
        spawner = GameObject.FindObjectOfType<RandomSpawner>();
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Zaidejas"))
        {

        
            spawner.spawnRate = 999999;
        DestroyWithTag("Goblin");
        DestroyWithTag("Wizard");
            spawner.limit = 0;

        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Zaidejas"))
        {
            spawner.spawnRate = 4;
            spawner.nextSpawn = 5f;
        }
    }


    public void DestroyWithTag(string destroyTag)
    {
        GameObject[] destroyObject;
        destroyObject = GameObject.FindGameObjectsWithTag(destroyTag);
        foreach (GameObject oneObject in destroyObject)
            Destroy(oneObject);
    }
}
