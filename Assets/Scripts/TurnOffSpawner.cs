using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOffSpawner : MonoBehaviour
{
    public Transform spawner;
    public void OnTriggerEnter2D(Collider2D other)
    {
       
         
          if (other.gameObject.CompareTag("Zaidejas"))
        {
        spawner.GetComponent<RandomSpawner>().SpawnRate(10);
        }
      
    }
    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Zaidejas"))
        {
            spawner.GetComponent<RandomSpawner>().SpawnRate(-10);
        }
    }

}
