using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageOnCollision : MonoBehaviour
{
    public int HowMuchDamage;
    public RandomSpawner spawner;

    private void Start()
    {
        spawner = GameObject.FindObjectOfType<RandomSpawner>();
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Zaidejas"))
        {
           
            collision.gameObject.GetComponent<gyvybes1>().TakeDamage(HowMuchDamage);
            
            if (CompareTag("Goblin"))
            {
               
                Destroy(gameObject);
                spawner.OnKill();
            }
        }
    }
}
