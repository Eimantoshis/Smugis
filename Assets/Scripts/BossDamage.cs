using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossDamage : MonoBehaviour
{
    public int HowMuchDamage;
    public void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Zaidejas"))
        {

            collision.gameObject.GetComponent<gyvybes1>().TakeDamage(HowMuchDamage);

            
        }
    }
}
