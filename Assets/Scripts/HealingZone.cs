using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealingZone : MonoBehaviour
{
    public float HealRate = 1f;
    float nextHeal = 0.0f;

    public void OnTriggerStay2D(Collider2D other)
    {
        if (Time.time > nextHeal)
        {
            nextHeal = Time.time + HealRate;
            if (other.gameObject.CompareTag("Zaidejas"))
            {

                other.gameObject.GetComponent<gyvybes1>().BonusHealth(1);
            }

        }

    }
}
