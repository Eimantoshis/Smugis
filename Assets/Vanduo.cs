using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vanduo : MonoBehaviour
{
   public Transform kojos;
    public Transform zaidejas;
    private void Update()
    {
        kojos.position = new Vector3(zaidejas.position.x, zaidejas.position.y-1, 1);
    }
    public void OnCollisionStay2D(Collision2D collision)
    {
     
        if (collision.gameObject.CompareTag("Zaidejas"))
        {
             if (collision.collider.GetType() == typeof(CircleCollider2D) && zaidejas.transform.parent == null )
            {
                collision.gameObject.GetComponent<gyvybes1>().TakeDamage(500);
           // do stuff only for the circle collider
            }
            

        }
    }
}
