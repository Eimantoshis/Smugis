using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup : MonoBehaviour
{
    
    
    public int kiek;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Zaidejas"))
        {

            
            collision.gameObject.GetComponent<gyvybes1>().BonusHealth(kiek);
            if (CompareTag("sirdele"))
            {

                Destroy(gameObject);

            }

        }
        if (collision.gameObject.CompareTag("priesas"))
        {
            if (CompareTag("sirdele"))
            {

                Destroy(gameObject);

            }
        }
    }
}
