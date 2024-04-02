using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saudalas : MonoBehaviour
{

    //public Animator animator;
    public GameObject hiteffect;
    private void OnTriggerEnter2D(Collider2D collision)
    {
       
        
        if (collision.gameObject.CompareTag("Goblin") || collision.gameObject.CompareTag("Wizard"))
        {  GameObject effect = Instantiate(hiteffect, transform.position, Quaternion.identity);
            Destroy(effect, 0.5f);
         // animator.SetTrigger("Hitas");
            collision.gameObject.GetComponent<Enemy>().EnemyTakeDamage(100);

            if (CompareTag("Saudalas"))
            {

                Destroy(gameObject);

            }
          
        }
        if (collision.gameObject.CompareTag("bosas"))
        {
            GameObject effect = Instantiate(hiteffect, transform.position, Quaternion.identity);
            Destroy(effect, 0.5f);
            collision.gameObject.GetComponent<Enemy>().EnemyTakeDamage(100);
            if (CompareTag("Saudalas"))
            {

                Destroy(gameObject);

            }

        }

        if (collision.gameObject.CompareTag("Durys"))
        {
            GameObject effect = Instantiate(hiteffect, transform.position, Quaternion.identity);
            Destroy(effect, 0.5f);
            Destroy(gameObject);
            Destroy(GameObject.FindWithTag("Durys"));


        }
        if (collision.gameObject.CompareTag("SienosMedziai"))
        {
            GameObject effect = Instantiate(hiteffect, transform.position, Quaternion.identity);
            Destroy(effect, 0.5f);
            Destroy(gameObject);
           


        }
    }

}
