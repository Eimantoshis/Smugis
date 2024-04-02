using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combat : MonoBehaviour
{

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (collision.gameObject.CompareTag("priesas"))
             {
                    
                    collision.gameObject.GetComponent<Enemy>().EnemyTakeDamage(25);
                    gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
            }
        
        }
    }

}


