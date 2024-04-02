using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kojos : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Vanduo"))
        {

            collision.gameObject.GetComponent<gyvybes1>().TakeDamage(100);


        }
    }
}
