using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeDamage : MonoBehaviour
{
    public float DamageRate = 1f;
    float nextDamage = 0.0f;

    public void OnTriggerStay2D(Collider2D other)
    {
        if (Time.time > nextDamage)
        {
            nextDamage = Time.time + DamageRate;
            if (other.gameObject.CompareTag("Zaidejas"))
            {
          
            other.gameObject.GetComponent<gyvybes1>().TakeDamage(1);
            }

        }
        
    }
}
