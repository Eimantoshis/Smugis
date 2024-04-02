using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossTornados : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Zaidejas"))
        {
            collision.gameObject.GetComponent<gyvybes1>().TakeDamage(5);

        }
    }
}
